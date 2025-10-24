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
    public partial class formInfoStudent : Form
    {
        private readonly StudentsBLL _studentBLL;
        private string mode;
        public formInfoStudent(string mode, string maSV = "",
                    string hoTen = "",
                    string maLop ="",
                    DateOnly? ngaySinh = null,
                    string gioiTinh = "",
                    string diaChi = "",
                    string email = "",
                    string sdt = "")
        {
            InitializeComponent();
            _studentBLL = new StudentsBLL();
            dtpBDay.Format = DateTimePickerFormat.Custom;
            this.mode = mode;

            if (mode == "add")
            {
                btnConfirm.Text = "Thêm";
            }
            else if (mode == "edit")
            {
                tbID.Text = maSV;
                tbName.Text = hoTen;
                tbIdClass.Text = maLop;
                dtpBDay.Value = ngaySinh.HasValue
                   ? ngaySinh.Value.ToDateTime(TimeOnly.MinValue)
                   : DateTime.Now;
                if (gioiTinh == "Nam")
                    rbtMen.Checked = true;
                else
                    rbtWomen.Checked = true;
                tbAddress.Text = diaChi;
                tbEmail.Text = email;
                tbNumPhone.Text = sdt;
                btnConfirm.Text = "Thay đổi";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(tbID.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbID.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbAddress.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbAddress.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập email!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbNumPhone.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNumPhone.Focus();
                    return;
                }

                if (!rbtMen.Checked && !rbtWomen.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbIdClass.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã lớp!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Students sv = new Students
                {
                    MaSV = tbID.Text.Trim(),
                    HoTen = tbName.Text.Trim(),
                    NgaySinh = DateOnly.FromDateTime(dtpBDay.Value),
                    GioiTinh = rbtMen.Checked ? "Nam" : "Nữ",
                    DiaChi = tbAddress.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    SDT = tbNumPhone.Text.Trim(),
                    MaLop = tbIdClass.Text.Trim(),
                };

                if (mode == "add")
                {
                    _studentBLL.Add(sv);
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (mode == "edit")
                {
                    _studentBLL.Update(sv);
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                string message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

