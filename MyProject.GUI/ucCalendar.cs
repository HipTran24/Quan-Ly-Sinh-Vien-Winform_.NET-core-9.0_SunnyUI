using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MyProject.BLL;
using MyProject.BLL.Auth;
using MyProject.DAL;
using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using MyProject.GUI.ViewModels;

namespace MyProject.GUI
{
    public partial class ucCalendar : UserControl
    {
        private readonly CalendarBLL _calendarBLL;
        private readonly ScoreBLL _scoreBLL = new ScoreBLL(); // dùng BLL có sẵn để lấy môn SV
        private readonly SubjectsBLL _subjectsBLL = new SubjectsBLL();   // <-- thêm dòng này


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ReadOnlyMode { get; set; } = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? ForceMaGV { get; set; }  // nếu có giá trị sẽ dùng để lọc

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? ForceMaSV { get; set; }  // nếu set -> lọc theo sinh viên

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateOnly? WeekStart { get; set; }  // nếu set -> lọc theo tuần (Thứ 2..CN)

        public ucCalendar()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _calendarBLL = new CalendarBLL();
        }


        private void ucCalendar_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new formInfoCalendar("add");
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            {
                if (CalendarDisplay.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn lịch cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = CalendarDisplay.CurrentRow;
                string maMH = row.Cells["ColMaMH"].Value.ToString();
                string maGV = row.Cells["ColMaGV"].Value.ToString();
                DateOnly ngay = (DateOnly)row.Cells["ColNgay"].Value;
                string tiet = row.Cells["ColTietHoc"].Value.ToString();
                string phong = row.Cells["ColPhongHoc"].Value.ToString();

                var f = new formInfoCalendar("edit", maMH, maGV, ngay, tiet, phong);
                if (f.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                var list = _calendarBLL.GetAllCalendar() ?? new List<Calendars>();

                if (!string.IsNullOrWhiteSpace(ForceMaGV))
                {
                    list = list.Where(c => string.Equals(c.MaGV, ForceMaGV, StringComparison.OrdinalIgnoreCase))
                               .OrderBy(c => c.Ngay)
                               .ToList();
                }
                else
                {
                    var isAdmin = AuthContextService.IsAdmin;
                    var maGVctx = AuthContextService.CurrentUser?.lecturers?.MaGV
                                  ?? AuthContextService.CurrentUser?.MaGV;

                    if (!isAdmin && !string.IsNullOrWhiteSpace(maGVctx))
                        list = list.Where(c => string.Equals(c.MaGV, maGVctx, StringComparison.OrdinalIgnoreCase))
                                   .OrderBy(c => c.Ngay).ToList();
                    else
                        list = list.OrderBy(c => c.Ngay).ToList();
                }

                // Lấy danh sách môn -> từ điển tên
                var subjects = _subjectsBLL.GetAllSubject() ?? new List<Subjects>();
                var dictTenMH = subjects
                    .Where(s => !string.IsNullOrWhiteSpace(s.MaMH))
                    .ToDictionary(s => s.MaMH.Trim(),
                                  s => (s.TenMH ?? s.MaMH).Trim(),
                                  StringComparer.OrdinalIgnoreCase);

                // Project có TenMH
                var data = list.Select(c => new
                {
                    MaMH = c.MaMH,
                    TenMH = (c.MaMH != null && dictTenMH.TryGetValue(c.MaMH.Trim(), out var ten)) ? ten : (c.MaMH ?? ""),
                    MaGV = c.MaGV,     // giữ lại để sửa/xóa
                    Ngay = c.Ngay,
                    NgayStr = $"{c.Ngay:dd/MM/yyyy}",
                    TietHoc = c.TietHoc,
                    PhongHoc = c.PhongHoc
                })
                .OrderBy(x => x.Ngay)
                .ThenBy(x => PeriodStart(x.TietHoc))
                .ToList();

                CalendarDisplay.DataSource = null;

                // Áp mapping theo vai trò
                if (AuthContextService.IsAdmin)
                    EnsureAdminColumns();
                else
                    EnsureTeacherColumns();

                CalendarDisplay.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyReadOnly();
            LoadData();
        }

        private void ApplyReadOnly()
        {
            var hide = ReadOnlyMode || (AuthContextService.IsLecturer && !AuthContextService.IsAdmin);
            btnAdd.Visible = !hide;
            btnChange.Visible = !hide;
            btnDelete.Visible = !hide;
            btnUpdate.Visible = !hide;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CalendarDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = CalendarDisplay.CurrentRow;
            string maMH = row.Cells["ColMaMH"].Value.ToString();
            string maGV = row.Cells["ColMaGV"].Value.ToString();
            DateOnly ngay = (DateOnly)row.Cells["ColNgay"].Value;
            string tietHoc = row.Cells["ColTietHoc"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa lịch giảng của {maGV} - {maMH} ngày {ngay:dd/MM/yyyy} không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _calendarBLL.Delete(maMH, maGV, ngay, tietHoc);
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa lịch giảng: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private static DateOnly ToMonday(DateOnly d)
        {
            int dow = (int)d.DayOfWeek; // Sunday=0
            int delta = (dow == 0) ? -6 : (1 - dow);
            return d.AddDays(delta);
        }
        private static int PeriodStart(string? tiet)
        {
            if (string.IsNullOrWhiteSpace(tiet)) return 99;
            var s = tiet.ToLower().Replace("tiết", "").Trim();
            var seg = s.Split('-', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (seg.Length > 0 && int.TryParse(seg[0], out var p1)) return p1;
            if (int.TryParse(s, out var p)) return p;
            return 99;
        }
        public void SetStudentData(IEnumerable<CalendarStudentVM> items)
        {
            ReadOnlyMode = true;
            ApplyReadOnly();

            var data = (items ?? Enumerable.Empty<CalendarStudentVM>())
                       .OrderBy(x => x.Ngay)
                       .ThenBy(x => x.TietHoc)
                       .ToList();
            CalendarDisplay.DataSource = null;
            EnsureStudentColumns();

            // bind
            CalendarDisplay.DataSource = data;
        }

        private void EnsureAdminColumns()
        {
            var g = CalendarDisplay;
            g.AutoGenerateColumns = false;

            // Ẩn hoặc xóa cột "Môn học" nếu có
            if (g.Columns.Contains("ColTenMH"))
                g.Columns.Remove("ColTenMH");

            // Hiển thị đúng các cột cần thiết cho admin
            if (g.Columns.Contains("ColMaGV"))
            {
                g.Columns["ColMaGV"].Visible = true;
                g.Columns["ColMaGV"].DataPropertyName = "MaGV";
                g.Columns["ColMaGV"].HeaderText = "Mã giảng viên";
                g.Columns["ColMaGV"].MinimumWidth = 140;
            }

            if (g.Columns.Contains("ColMaMH"))
            {
                g.Columns["ColMaMH"].DataPropertyName = "MaMH";
                g.Columns["ColMaMH"].HeaderText = "Mã môn";
            }

            if (g.Columns.Contains("ColNgay"))
            {
                g.Columns["ColNgay"].DataPropertyName = "NgayStr";
                g.Columns["ColNgay"].HeaderText = "Ngày học";
            }

            if (g.Columns.Contains("ColTietHoc"))
            {
                g.Columns["ColTietHoc"].DataPropertyName = "TietHoc";
                g.Columns["ColTietHoc"].HeaderText = "Tiết học";
            }

            if (g.Columns.Contains("ColPhongHoc"))
            {
                g.Columns["ColPhongHoc"].DataPropertyName = "PhongHoc";
                g.Columns["ColPhongHoc"].HeaderText = "Phòng học";
            }
        }

        private void EnsureTeacherColumns()
        {
            var g = CalendarDisplay;
            g.AutoGenerateColumns = false;

            // Đảm bảo có cột "Môn học"
            if (!g.Columns.Contains("ColTenMH"))
            {
                var colTenMH = new DataGridViewTextBoxColumn
                {
                    Name = "ColTenMH",
                    HeaderText = "Môn học",
                    DataPropertyName = "TenMH",
                    MinimumWidth = 160,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    ReadOnly = true
                };
                int idxInsert = g.Columns.Contains("ColMaMH") ? g.Columns["ColMaMH"].Index + 1 : 0;
                g.Columns.Insert(idxInsert, colTenMH);
            }
            else
            {
                g.Columns["ColTenMH"].DataPropertyName = "TenMH";
                g.Columns["ColTenMH"].HeaderText = "Môn học";
            }

            // Ẩn mã GV khi là giảng viên
            if (g.Columns.Contains("ColMaGV"))
            {
                g.Columns["ColMaGV"].DataPropertyName = "MaGV";
                g.Columns["ColMaGV"].Visible = false;
            }

            if (g.Columns.Contains("ColMaMH")) { g.Columns["ColMaMH"].DataPropertyName = "MaMH"; g.Columns["ColMaMH"].HeaderText = "Mã môn"; }
            if (g.Columns.Contains("ColNgay")) { g.Columns["ColNgay"].DataPropertyName = "NgayStr"; g.Columns["ColNgay"].HeaderText = "Ngày học"; }
            if (g.Columns.Contains("ColTietHoc")) { g.Columns["ColTietHoc"].DataPropertyName = "TietHoc"; g.Columns["ColTietHoc"].HeaderText = "Tiết học"; }
            if (g.Columns.Contains("ColPhongHoc")) { g.Columns["ColPhongHoc"].DataPropertyName = "PhongHoc"; g.Columns["ColPhongHoc"].HeaderText = "Phòng học"; }
        }

        private void EnsureStudentColumns()
        {
            var g = CalendarDisplay;
            g.AutoGenerateColumns = false;

            // Thêm cột "Thứ" nếu Designer chưa có
            if (!g.Columns.Contains("ColThu"))
            {
                var colThu = new DataGridViewTextBoxColumn
                {
                    Name = "ColThu",
                    HeaderText = "Thứ",
                    DataPropertyName = "Thu",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                int idx = g.Columns.Contains("ColNgay") ? g.Columns["ColNgay"].Index + 1 : g.Columns.Count;
                g.Columns.Insert(idx, colThu);
            }

            if (g.Columns.Contains("ColNgay")) g.Columns["ColNgay"].DataPropertyName = "NgayStr";  // dd/MM/yyyy
            if (g.Columns.Contains("ColTietHoc")) g.Columns["ColTietHoc"].DataPropertyName = "TietHoc";
            if (g.Columns.Contains("ColPhongHoc")) g.Columns["ColPhongHoc"].DataPropertyName = "PhongHoc";

            if (g.Columns.Contains("ColMaMH"))
            {
                g.Columns["ColMaMH"].DataPropertyName = "MaMH";   
                g.Columns["ColMaMH"].HeaderText = "Môn học";
                g.Columns["ColMaMH"].MinimumWidth = 180;
            }
            if (g.Columns.Contains("ColMaGV"))
            {
                g.Columns["ColMaGV"].DataPropertyName = "TenGV";   
                g.Columns["ColMaGV"].HeaderText = "Giảng viên";
                g.Columns["ColMaGV"].MinimumWidth = 180;
            }

            if (g.Columns.Contains("ColNgay")) g.Columns["ColNgay"].HeaderText = "Ngày";
            if (g.Columns.Contains("ColThu")) g.Columns["ColThu"].HeaderText = "Thứ";
            if (g.Columns.Contains("ColTietHoc")) g.Columns["ColTietHoc"].HeaderText = "Tiết";
            if (g.Columns.Contains("ColPhongHoc")) g.Columns["ColPhongHoc"].HeaderText = "Phòng";
        }

        private static int ParsePeriodStart(string? tietHoc)
        {
            if (string.IsNullOrWhiteSpace(tietHoc)) return 99;
            var s = tietHoc.ToLower().Replace("tiết", "").Trim(); // "1-3" | "5"
            var seg = s.Split('-', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (seg.Length > 0 && int.TryParse(seg[0], out var p1)) return p1;
            if (int.TryParse(s, out var p)) return p;
            return 99;
        }
    }
}
