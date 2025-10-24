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
    public partial class ucUpdateAccount : UserControl
    {
        private readonly UserBLL _userBLL;
        public ucUpdateAccount()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }
        private void ucUpdateAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = _userBLL.GetAllUser();
                UserAccountDisplay.DataSource = null;
                UserAccountDisplay.AutoGenerateColumns = false;
                UserAccountDisplay.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new formInfoUser("add");
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (UserAccountDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = UserAccountDisplay.CurrentRow;
            string username = row.Cells[0].Value.ToString();
            string password = row.Cells[1].Value.ToString();
            string role = row.Cells[2].Value.ToString();
            string idUser = row.Cells[3].Value?.ToString()
                            ?? row.Cells[4].Value?.ToString()
                            ?? row.Cells[5].Value?.ToString();

            var f = new formInfoUser("edit", username, password, role, idUser);
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserAccountDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var username = UserAccountDisplay.CurrentRow.Cells[0].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa tài khoản '{username}' không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _userBLL.Delete(username);
                    MessageBox.Show("Xóa tài khoản thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string keyword = tbSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
                return;
            }

            var list = _userBLL.GetAllUser()
                               .Where(u =>
                                    (u.MaSV != null && u.MaSV.Contains(keyword)) ||
                                    (u.MaGV != null && u.MaGV.Contains(keyword)) ||
                                    (u.Username.Contains(keyword)))
                               .ToList();

            if (list.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tài khoản nào khớp!",
                    "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UserAccountDisplay.DataSource = null;
            UserAccountDisplay.DataSource = list;
        }
    }
}
