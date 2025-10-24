using MyProject.BLL;
using MyProject.DAL.Models;
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
    public partial class formInfoLecturer : Form
    {
        private string mode;
        private LecturersBLL _lecturerBLL;
        private FacultyBLL _facultyBLL;
        public formInfoLecturer(string mode,
            string maGV = "",
            string hoTen = "",
            string email = "",
            string sdt = "",
            string maKhoa = "")
        {
            InitializeComponent();
            this.mode = mode;
            _lecturerBLL = new LecturersBLL();
            _facultyBLL = new FacultyBLL();

            if (mode == "add")
            {
                btnConfirm.Text = "Thêm";
            }
            else if (mode == "edit")
            {
                btnConfirm.Text = "Cập nhật";
                tbID.Text = maGV;
                tbName.Text = hoTen;
                tbEmail.Text = email;
                tbNumP.Text = sdt;
                tbIdFa.Text = maKhoa;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // 🧩 Kiểm tra thông tin bắt buộc
                if (string.IsNullOrWhiteSpace(tbID.Text) ||
                    string.IsNullOrWhiteSpace(tbName.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbNumP.Text) ||
                    string.IsNullOrWhiteSpace(tbIdFa.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin giảng viên!",
                        "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🧠 Kiểm tra mã khoa có tồn tại không
                var khoaTonTai = _facultyBLL
                    .GetAllFaculty()
                    .Any(k => k.MaKhoa.Equals(tbIdFa.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (!khoaTonTai)
                {
                    MessageBox.Show("Mã khoa không tồn tại trong hệ thống!",
                        "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 🧱 Tạo đối tượng giảng viên
                var gv = new Lecturers
                {
                    MaGV = tbID.Text.Trim(),
                    HoTen = tbName.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    SDT = tbNumP.Text.Trim(),
                    MaKhoa = tbIdFa.Text.Trim()
                };

                // 💾 Gọi BLL xử lý
                if (mode == "add")
                {
                    _lecturerBLL.Add(gv);
                    MessageBox.Show("Thêm giảng viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lecturerBLL.Update(gv);
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    
