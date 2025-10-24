using Microsoft.VisualBasic;
using MyProject.BLL;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class formInfoScore : Form
    {
        private string mode;
        private ScoreBLL _scoreBLL;

        public formInfoScore(string mode, string maSV = "", string maMH = "",
                         double diemGK = 0, double diemCK = 0,
                          double diemTong = 0, string hocKy = "")
        {
            InitializeComponent();
            this.mode = mode;
            _scoreBLL = new ScoreBLL();
            tbMidterm.TextChanged += CalculateAverage;
            tbEndOTerm.TextChanged += CalculateAverage;
            cbSemester.SelectedIndex = 0;

            if (mode == "add")
            {
                btnConfirm.Text = "Thêm";
            }
            else if (mode == "edit")
            {
                tbIdStudent.Text = maSV;
                tbIdSubject.Text = maMH;
                tbMidterm.Text = diemGK.ToString("0.##");
                tbEndOTerm.Text = diemCK.ToString("0.##");
                lbformName.Text = "Thay đổi điểm";
                btnConfirm.Text = "Cập nhật";
                cbSemester.SelectedItem = hocKy ?? "HK1A-2025-2026";
            }
        }
        private void CalculateAverage(object sender, EventArgs e)
        {
            if (double.TryParse(tbMidterm.Text, out double diemGK) &&
                double.TryParse(tbEndOTerm.Text, out double diemCK))
            {
                double diemTong = (diemGK * 0.5) + (diemCK * 0.5);
                tbFinalScore.Text = diemTong.ToString("0.##");
            }
            else
            {
                tbFinalScore.Text = string.Empty;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(tbIdStudent.Text) ||
                    string.IsNullOrWhiteSpace(tbIdSubject.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ mã sinh viên và mã môn học!",
                        "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse điểm
                float diemGK = float.TryParse(tbMidterm.Text, out float gk) ? gk : 0;
                float diemCK = float.TryParse(tbEndOTerm.Text, out float ck) ? ck : 0;
                float diemTong = float.TryParse(tbFinalScore.Text, out float tong) ? tong : 0;
                string hocKy = cbSemester.SelectedItem?.ToString() ?? "HK1A-2025-2026";

                // Tạo đối tượng Score
                var score = new Score
                {
                    MaSV = tbIdStudent.Text.Trim(),
                    MaMH = tbIdSubject.Text.Trim(),
                    DiemGK = diemGK,
                    DiemCK = diemCK,
                    DiemTrungBinh = diemTong,
                    HocKy = hocKy
                };

                // Gọi BLL để lưu
                if (mode == "add")
                    _scoreBLL.Add(score);
                else
                    _scoreBLL.Update(score);

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
