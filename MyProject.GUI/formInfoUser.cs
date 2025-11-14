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

            tbIDUser.Leave += AutoFillFromId;
            tbIDUser.TextChanged += AutoFillFromIdLive;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;

            if (mode == "edit")
            {
                tbUserName.Text = username;
                tbPWord.Text = password;
                cbRole.SelectedItem = role;
                tbIDUser.Text = idUser;

                tbUserName.Enabled = false;
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

            ApplyRoleMode();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUserName.Text.Trim();
                string password = tbPWord.Text.Trim();
                string role = cbRole.SelectedItem?.ToString();
                string idUser = tbIDUser.Text.Trim();

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Vui lòng chọn vai trò!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Với SV/GV: nếu để trống, tự lấy theo mã
                if (!IsAdminRole())
                {
                    if (string.IsNullOrWhiteSpace(idUser))
                    {
                        MessageBox.Show("Vui lòng nhập Mã user (MaSV/MaGV)!", "Thiếu thông tin",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(username)) username = idUser;
                    if (string.IsNullOrWhiteSpace(password)) password = idUser;
                }
                else
                {
                    // Admin: bắt buộc tự nhập user/pass
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Admin phải tự nhập Username và Password!", "Thiếu thông tin",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var user = new AppUsers
                {
                    Username = username,
                    Password = password, // Nếu hệ thống dùng BCrypt thì hash trước khi lưu
                    Role = role
                };

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
                        user.AdminID = idUser; // có thể để trống nếu bạn không dùng AdminID
                        user.MaSV = null;
                        user.MaGV = null;
                        break;
                    default:
                        MessageBox.Show("Vai trò không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }


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
        private bool IsAdminRole()
        {
            var role = cbRole.SelectedItem?.ToString() ?? "";
            return role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyRoleMode();
        }
        private void ApplyRoleMode()
        {
            if (mode == "edit") return; // edit giữ nguyên

            if (IsAdminRole())
            {
                tbUserName.Enabled = true;
                tbPWord.Enabled = true;

                tbUserName.Clear();
                tbPWord.Clear();
            }
            else
            {
                tbUserName.Enabled = true; 
                tbPWord.Enabled = true;

                AutoFillFromId(null, EventArgs.Empty);
            }
        }
        private void AutoFillFromId(object? sender, EventArgs e)
        {
            if (mode != "add") return;
            if (IsAdminRole()) return; 

            var id = NormalizeId(tbIDUser.Text);
            if (!string.IsNullOrWhiteSpace(id))
            {
                tbUserName.Text = id;
                tbPWord.Text = id;
            }
        }
        private void AutoFillFromIdLive(object? sender, EventArgs e)
        {
            if (mode != "add") return;
            if (IsAdminRole()) return; // Admin: không auto-fill

            var id = NormalizeId(tbIDUser.Text);
            if (string.IsNullOrWhiteSpace(id)) return;

            if (string.IsNullOrWhiteSpace(tbUserName.Text) || tbUserName.Text == tbPWord.Text)
                tbUserName.Text = id;

            if (string.IsNullOrWhiteSpace(tbPWord.Text) || tbUserName.Text == tbPWord.Text)
                tbPWord.Text = id;
        }

        private static string NormalizeId(string? raw)
        {
            return (raw ?? "").Trim();
        }

    }
}
