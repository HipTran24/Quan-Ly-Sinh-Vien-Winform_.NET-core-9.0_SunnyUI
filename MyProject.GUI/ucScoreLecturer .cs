using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProject.BLL.Auth;
using MyProject.DAL;
using MyProject.DAL.Models;
using Sunny.UI;

namespace MyProject.GUI
{
    public partial class ucScoreLecturer : UserControl
    {
        public ucScoreLecturer()
        {
            InitializeComponent();
            this.Load += ucScoreLecturer_Load;
            cbLop.SelectedIndexChanged += (_, __) => LoadGrid();
            cbMon.SelectedIndexChanged += (_, __) => LoadGrid();
            cbHocKy.SelectedIndexChanged += (_, __) => LoadGrid();
            btnUpdate.Click += btnUpdate_Click;

            UpdateScoreDisplay.CellEndEdit += UpdateScoreDisplay_CellEndEdit;
            UpdateScoreDisplay.CellValidating += UpdateScoreDisplay_CellValidating;
            UpdateScoreDisplay.DataError += (s, e) => e.ThrowException = false;

            // datagrid basic
            UpdateScoreDisplay.AutoGenerateColumns = false;
            UpdateScoreDisplay.EditMode = DataGridViewEditMode.EditOnEnter;
            UpdateScoreDisplay.SelectionMode = DataGridViewSelectionMode.CellSelect;
            UpdateScoreDisplay.AllowUserToAddRows = false;
            UpdateScoreDisplay.AllowUserToDeleteRows = false;
        }
        private string CurrentMaGV =>
           AuthContextService.CurrentUser?.lecturers?.MaGV ??
           AuthContextService.CurrentUser?.MaGV ?? string.Empty;


        private void ucScoreLecturer_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CurrentMaGV))
            {
                UIMessageBox.ShowError("Không xác định được mã giảng viên.");
                return;
            }

            using var db = new AppDbContext();

            // Lớp do GV này phụ trách
            var lopList = db.Set<ClassRoom>()
                            .Where(x => x.MaGV == CurrentMaGV)
                            .Select(x => new { x.MaLop, x.TenLop })
                            .Distinct()
                            .ToList();

            cbLop.DataSource = lopList;
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";

            // Môn GV dạy (từ lịch giảng dạy)
            var monList = (from c in db.Set<Calendars>()
                           where c.MaGV == CurrentMaGV
                           join sj in db.Set<Subjects>() on c.MaMH equals sj.MaMH
                           select new { MaMH = sj.MaMH, TenMH = sj.TenMH })
                           .Distinct()
                           .ToList();

            cbMon.DataSource = monList;
            cbMon.DisplayMember = "TenMH";
            cbMon.ValueMember = "MaMH";

            // Học kỳ: có thể lấy từ bảng điểm nếu muốn
            var hocky = db.Set<Score>().Select(s => s.HocKy).Distinct().OrderBy(s => s).ToList();
            cbHocKy.Items.Clear();
            cbHocKy.Items.AddRange(hocky.Count > 0 ? hocky.Cast<object>().ToArray()
                                                   : new object[] { "HK1-2025-2026", "HK2-2025-2026", "HK3-2025-2026" });
            if (cbHocKy.Items.Count > 0) cbHocKy.SelectedIndex = 0;

            LoadGrid();
        }
        private void LoadGrid()
        {

            if (cbLop.SelectedValue == null || cbMon.SelectedValue == null || cbHocKy.SelectedItem == null) return;

            string maLop = cbLop.SelectedValue.ToString();
            string maMH = cbMon.SelectedValue.ToString();
            string hocKy = cbHocKy.SelectedItem.ToString();

            using var db = new AppDbContext();

            var svList = db.Set<Students>()
                           .Where(s => s.MaLop == maLop)           
                           .Select(s => new { s.MaSV, HoTen = s.HoTen }) 
                           .OrderBy(s => s.MaSV)
                           .ToList();

            var diemDict = db.Set<Score>()
                             .Where(d => d.MaMH == maMH && d.HocKy == hocKy)
                             .ToDictionary(d => d.MaSV, d => d);

            var t = new DataTable();
            t.Columns.Add("MaSV", typeof(string));
            t.Columns.Add("HoTen", typeof(string));
            t.Columns.Add("MaMH", typeof(string));
            t.Columns.Add("HocKy", typeof(string));
            t.Columns.Add("DiemGK", typeof(float));
            t.Columns.Add("DiemCK", typeof(float));
            t.Columns.Add("DiemTrungBinh", typeof(float));

            foreach (var sv in svList)
            {
                if (diemDict.TryGetValue(sv.MaSV, out var sc))
                    t.Rows.Add(sv.MaSV, sv.HoTen, maMH, hocKy, sc.DiemGK, sc.DiemCK, sc.DiemTrungBinh);
                else
                    t.Rows.Add(sv.MaSV, sv.HoTen, maMH, hocKy, DBNull.Value, DBNull.Value, DBNull.Value);
            }

            UpdateScoreDisplay.DataSource = t;

            UpdateScoreDisplay.Columns["MaSV"].DataPropertyName = "MaSV";
            UpdateScoreDisplay.Columns["HoTen"].DataPropertyName = "HoTen";
            UpdateScoreDisplay.Columns["MaMH"].DataPropertyName = "MaMH";
            UpdateScoreDisplay.Columns["HocKy"].DataPropertyName = "HocKy";
            UpdateScoreDisplay.Columns["DiemGK"].DataPropertyName = "DiemGK";
            UpdateScoreDisplay.Columns["DiemCK"].DataPropertyName = "DiemCK";
            UpdateScoreDisplay.Columns["DiemTrungBinh"].DataPropertyName = "DiemTrungBinh";

            // ReadOnly đúng như bạn đang làm
            UpdateScoreDisplay.Columns["MaSV"].ReadOnly = true;
            UpdateScoreDisplay.Columns["HoTen"].ReadOnly = true;
            UpdateScoreDisplay.Columns["MaMH"].ReadOnly = true;
            UpdateScoreDisplay.Columns["HocKy"].ReadOnly = true;
        }

        private void UpdateScoreDisplay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = UpdateScoreDisplay.Rows[e.RowIndex];

            float gk = ParseScoreF(row.Cells["DiemGK"].Value);
            float ck = ParseScoreF(row.Cells["DiemCK"].Value);

            if (!float.IsNaN(gk) && !float.IsNaN(ck))
                row.Cells["DiemTrungBinh"].Value = MathF.Round(gk * 0.5f + ck * 0.5f, 2);
            else
                row.Cells["DiemTrungBinh"].Value = DBNull.Value;
        }

        private void UpdateScoreDisplay_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var col = UpdateScoreDisplay.Columns[e.ColumnIndex].Name;
            if (col != "DiemGK" && col != "DiemCK") return;

            var txt = (e.FormattedValue ?? "").ToString();
            if (string.IsNullOrWhiteSpace(txt)) return;

            if (!float.TryParse(txt, out var v) || v < 0f || v > 10f)
            {
                e.Cancel = true;
                UIMessageTip.ShowWarning("Điểm phải là số từ 0 đến 10.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateScoreDisplay.DataSource is not DataTable t) return;

            using var db = new AppDbContext();

            foreach (DataRow r in t.Rows)
            {
                var maSV = r["MaSV"]?.ToString();
                var maMH = r["MaMH"]?.ToString();
                var hocKy = r["HocKy"]?.ToString();
                if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(maMH) || string.IsNullOrWhiteSpace(hocKy))
                    continue;

                float? gk = TryF(r["DiemGK"]);
                float? ck = TryF(r["DiemCK"]);
                float? tb = TryF(r["DiemTrungBinh"]);

                var exist = db.Set<Score>().FirstOrDefault(x => x.MaSV == maSV && x.MaMH == maMH);

                if (exist == null)
                {
                    db.Set<Score>().Add(new Score
                    {
                        MaSV = maSV,
                        MaMH = maMH,
                        HocKy = hocKy,
                        DiemGK = gk ?? 0f,
                        DiemCK = ck ?? 0f,
                        DiemTrungBinh = tb ?? CalcTBF(gk, ck)
                    });
                }
                else
                {
                    exist.DiemGK = gk ?? 0f;
                    exist.DiemCK = ck ?? 0f;
                    exist.DiemTrungBinh = tb ?? CalcTBF(gk, ck);
                }
            }

            db.SaveChanges();
            MessageBox.Show("Đã lưu điểm!");
            LoadGrid(); ;
        }
        private static float CalcTBF(float? gk, float? ck)
        {
            if (gk.HasValue && ck.HasValue) return MathF.Round(gk.Value * 0.5f + ck.Value * 0.5f, 2);
            if (gk.HasValue) return gk.Value;
            if (ck.HasValue) return ck.Value;
            return 0f;
        }

        private static float? TryF(object v)
        {
            if (v == null || v == DBNull.Value) return null;
            return float.TryParse(v.ToString(), out var d) ? d : null;
        }

        private static float ParseScoreF(object val)
        {
            if (val == null) return float.NaN;
            return float.TryParse(val.ToString(), out var v) ? v : float.NaN;
        }

    }
}