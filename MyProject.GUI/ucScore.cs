using MyProject.BLL;
using MyProject.DAL;
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
    public partial class ucScore : UserControl
    {
        private ScoreBLL _scoreBLL = new ScoreBLL();

        public ucScore()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        }

        private void ucScore_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var list = db.Diem.ToList();
                ScoreDisplay.DataSource = null;
                ScoreDisplay.AutoGenerateColumns = false;
                ScoreDisplay.DataSource = list;
            }
        }
        private void LoadData()
        {
            ScoreDisplay.DataSource = null;
            var list = _scoreBLL.GetAllScore();

            ScoreDisplay.DataSource = list;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            formInfoScore f = new formInfoScore("add");
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (ScoreDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = ScoreDisplay.CurrentRow;
            string maSV = row.Cells["ColMaSV"].Value.ToString();
            string maMH = row.Cells["ColMaMH"].Value.ToString();
            double diemGK = Convert.ToDouble(row.Cells["ColDiemGK"].Value);
            double diemCK = Convert.ToDouble(row.Cells["ColDiemCK"].Value);
            double diemTB = Convert.ToDouble(row.Cells["ColDiemTrungBinh"].Value);
            string hocKy = row.Cells["ColHocKy"].Value.ToString();

            formInfoScore f = new formInfoScore("edit", maSV, maMH, diemGK, diemCK, diemTB, hocKy);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData(); // Cập nhật lại danh sách sau khi sửa
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ScoreDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = ScoreDisplay.CurrentRow;
            string maSV = row.Cells["ColMaSV"].Value.ToString();
            string maMH = row.Cells["ColMaMH"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa điểm của SV {maSV} - Môn {maMH} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _scoreBLL.Delete(maSV, maMH);
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
