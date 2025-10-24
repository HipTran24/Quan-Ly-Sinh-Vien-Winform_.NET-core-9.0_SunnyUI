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
    public partial class formInfoFaculty : Form
    {
        private string mode;
        private readonly FacultyBLL _facultyBLL = new FacultyBLL();
        public formInfoFaculty(string mode, string maKhoa = "", string tenKhoa = "",
                           string truongKhoa = "", string phong = "",
                           long soLop = 0, string email = "")
        {
            InitializeComponent();
            this.mode = mode;

            if (mode == "add")
            {
                this.Text = "Thêm khoa viện";
                lbformName.Text = "Thêm khoa viện";
                btnConfirm.Text = "Thêm";
            }
            else if (mode == "edit")
            {
                this.Text = "Cập nhật khoa viện";
                lbformName.Text = "Cập nhật khoa viện";
                btnConfirm.Text = "Cập nhật";

                tbID.Text = maKhoa;
                tbName.Text = tenKhoa;
                tbDean.Text = truongKhoa;
                tbWRoom.Text = phong;
                numQuantityCl.Value = soLop;
                tbEmail.Text = email;
                tbID.Enabled = false;
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text) || string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã khoa và Tên khoa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Faculty f = new Faculty
                {
                    MaKhoa = tbID.Text.Trim(),
                    TenKhoa = tbName.Text.Trim(),
                    TruongKhoa = tbDean.Text.Trim(),
                    PhongCongTac = tbWRoom.Text.Trim(),
                    SoLuongLop = (long)numQuantityCl.Value,
                    EmailKhoa = tbEmail.Text.Trim()
                };

                if (mode == "add")
                    _facultyBLL.Add(f);
                else
                    _facultyBLL.Update(f);

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

