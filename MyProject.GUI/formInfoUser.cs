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
    public partial class formInfoUser : Form
    {
        private readonly UserBLL _userBLL;
        string mode;

        public formInfoUser(string mode, string username = "", string password = "", string role = "", string idUser = "")
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            this.mode = mode;


            if (mode == "edit")
            {
                tbUserName.Text = username;
                tbPWord.Text = password;
                cbRole.SelectedItem = role;
                tbIDUser.Text = idUser;

                tbUserName.Enabled = false; // không cho sửa username
                btnConfirm.Text = "Cập nhật";
            }
            else
            {
                btnConfirm.Text = "Thêm";
            }

        }

        private void formInfoUser_Load(object sender, EventArgs e)
        {
            cbRole.Items.Clear();
            cbRole.Items.AddRange(new string[] { "Sinh viên", "Giảng viên", "Admin" });
            cbRole.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUserName.Text.Trim();
                string password = tbPWord.Text.Trim();
                string role = cbRole.SelectedItem?.ToString();
                string idUser = tbIDUser.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = new AppUsers
                {
                    Username = username,
                    Password = password,
                    Role = role
                };

                // 🎯 Phân nhánh theo Role
                switch (role)
                {
                    case "Sinh viên":
                        user.MaSV = idUser;
                        user.MaGV = null;
                        user.AdminID = null;
                        break;

                    case "Giảng viên":
                        user.MaGV = idUser;
                        user.MaSV = null;
                        user.AdminID = null;
                        break;

                    case "Admin":
                        user.AdminID = idUser;
                        user.MaSV = null;
                        user.MaGV = null;
                        break;

                    default:
                        MessageBox.Show("Vai trò không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // ✅ Gọi BLL để lưu dữ liệu
                if (mode == "add")
                    _userBLL.Add(user);
                else
                    _userBLL.Update(user);

                MessageBox.Show("Lưu tài khoản thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tài khoản: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
