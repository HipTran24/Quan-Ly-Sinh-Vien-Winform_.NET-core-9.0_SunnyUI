using Microsoft.EntityFrameworkCore;
using MyProject.BLL;
using MyProject.BLL.Auth;
using MyProject.DAL;
using MyProject.GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyProject.GUI
{
    public partial class ucStudentScore : UserControl
    {
        private readonly ScoreBLL _scoreBLL = new ScoreBLL();
        private readonly SubjectsBLL _subjectsBLL = new SubjectsBLL();
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ForceMaSV { get; set; } = null;
        public ucStudentScore()
        {
            InitializeComponent();
            this.Load += ucStudentScore_Load; // đảm bảo có dòng này
        }

        private void ucStudentScore_Load(object sender, EventArgs e)
        {
            try { LoadData(); }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetMaSVFromContext()
        {
            // Ưu tiên ForceMaSV -> MaSV -> students.MaSV -> Username (fallback)
            var m =
                ForceMaSV ??
                AuthContextService.CurrentUser?.MaSV ??
                AuthContextService.CurrentUser?.students?.MaSV ??
                AuthContextService.CurrentUser?.Username;

            return (m ?? "").Trim();
        }

        private void LoadData()
        {
            var maSV = GetMaSVFromContext();

            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Không xác định được mã sinh viên. " +
                                "Hãy truyền ForceMaSV hoặc đăng nhập bằng tài khoản sinh viên.",
                                "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindEmpty();
                return;
            }

            // 1) Lấy toàn bộ điểm & môn
            var allScores = _scoreBLL.GetAllScore() ?? new List<MyProject.DAL.Models.Score>();
            var subjects = _subjectsBLL.GetAllSubject() ?? new List<MyProject.DAL.Models.Subjects>();

            // 2) CHUẨN HOÁ & LỌC THEO MaSV (không phân biệt hoa/thường, bỏ khoảng trắng)
            string key = maSV.Trim();
            var scoresOfStudent = allScores
                .Where(d => string.Equals((d.MaSV ?? "").Trim(), key, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // 3) Join sang ViewModel
            var data =
                (from d in scoresOfStudent
                 join s in subjects on d.MaMH equals s.MaMH into gj
                 from s in gj.DefaultIfEmpty()
                 select new MyScoreRow
                 {
                     MaMH = d.MaMH,
                     TenMH = s?.TenMH ?? "",
                     DiemGiuaKy = d.DiemGK,
                     DiemCuoiKy = d.DiemCK,
                     DiemTrungBinh = d.DiemTrungBinh,
                     SoTinChi = s?.SoTinChi ?? 0,
                     HocKy = d.HocKy ?? ""
                 })
                .OrderBy(r => r.HocKy).ThenBy(r => r.MaMH)
                .ToList();

            // 4) Bind lưới
            RebuildGridColumns();
            dgvScores.AutoGenerateColumns = false;
            dgvScores.DataSource = data;

            // 5) GPA
            int tongTC = data.Sum(r => r.SoTinChi);
            double gpa = tongTC > 0
                ? data.Sum(r => r.DiemTrungBinh * r.SoTinChi) / tongTC
                : 0.0;

            lblGPA.Text = $"GPA: {gpa:0.00}";
            lblTotalCredits.Text = $"Tổng TC: {tongTC}";

            // 6) Chẩn đoán khi rỗng
            if (data.Count == 0)
            {
                // Cho bạn thấy rõ mình đang lọc theo MaSV nào và trong allScores có gì
                var sampleIds = string.Join(", ",
                    allScores.Select(s => (s.MaSV ?? "").Trim())
                             .Where(s => !string.IsNullOrEmpty(s))
                             .Distinct(StringComparer.OrdinalIgnoreCase)
                             .Take(5));

                MessageBox.Show(
                    $"Không tìm thấy điểm cho MaSV='{maSV}'.\n" +
                    $"- Tổng bản ghi Score: {allScores.Count}\n" +
                    $"- Tổng MaSV khác nhau (top5): {sampleIds}\n" +
                    $"- Số bản ghi của SV này (sau chuẩn hoá): {scoresOfStudent.Count}\n" +
                    $"- Tổng môn học: {subjects.Count}\n" +
                    $"→ Kiểm tra lại bảng Diem: cột MaSV có khớp '{maSV}' (bỏ khoảng trắng/hoa thường) không.",
                    "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BindEmpty()
        {
            RebuildGridColumns();
            dgvScores.AutoGenerateColumns = false;
            dgvScores.DataSource = new List<MyScoreRow>();
            lblGPA.Text = "GPA: 0.00";
            lblTotalCredits.Text = "Tổng TC: 0";
        }

        private void RebuildGridColumns()
        {
            dgvScores.AutoGenerateColumns = false;
            dgvScores.Columns.Clear();

            dgvScores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã môn", DataPropertyName = "MaMH", FillWeight = 110 });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên môn", DataPropertyName = "TenMH", FillWeight = 220 });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điểm GK", DataPropertyName = "DiemGiuaKy", FillWeight = 110 });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điểm CK", DataPropertyName = "DiemCuoiKy", FillWeight = 110 });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điểm TB", DataPropertyName = "DiemTrungBinh", FillWeight = 110 });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số tín chỉ", DataPropertyName = "SoTinChi", FillWeight = 110 });
            dgvScores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học kỳ", DataPropertyName = "HocKy", FillWeight = 110 });
        }
        public void RefreshFor(string maSV)
        {
            this.ForceMaSV = maSV?.Trim();
            ucStudentScore_Load(this, EventArgs.Empty); // gọi lại logic nạp
        }


    }

}

