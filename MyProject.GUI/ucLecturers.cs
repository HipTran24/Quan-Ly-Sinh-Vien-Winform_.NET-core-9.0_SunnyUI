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
    public partial class ucLecturers : UserControl
    {
        private LecturersBLL _lecturerBLL = new LecturersBLL();
        public ucLecturers()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        }

        private void ucLecturers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                LecturerDisplay.DataSource = null;
                var list = _lecturerBLL.GetAllLecturers();

                LecturerDisplay.AutoGenerateColumns = false;
                LecturerDisplay.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách giảng viên: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formInfoLecturer f = new formInfoLecturer("add");
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (LecturerDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = LecturerDisplay.CurrentRow;
            string maGV = row.Cells["ColMaGV"].Value.ToString();
            string hoTen = row.Cells["ColHoTen"].Value.ToString();
            string email = row.Cells["ColEmail"].Value.ToString();
            string sdt = row.Cells["ColSDT"].Value.ToString();
            string maKhoa = row.Cells["ColMaKhoa"].Value.ToString();

            formInfoLecturer f = new formInfoLecturer("edit", maGV, hoTen, email, sdt, maKhoa);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LecturerDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = LecturerDisplay.CurrentRow;
            string maGV = row.Cells["ColMaGV"].Value.ToString();
            string hoTen = row.Cells["ColHoTen"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa giảng viên '{hoTen}' (Mã: {maGV}) không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _lecturerBLL.Delete(maGV);
                    MessageBox.Show("Xóa giảng viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa giảng viên: " + ex.Message,
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
