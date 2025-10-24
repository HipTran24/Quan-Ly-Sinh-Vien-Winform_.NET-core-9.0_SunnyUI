using MyProject.BLL;
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
    public partial class ucResetPassword : UserControl
    {
        
        private readonly ForgotPasswordBLL _forgot = new ForgotPasswordBLL();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RequestId { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username { get; set; } = "";

        public event EventHandler<bool>? ResetDone;
        public ucResetPassword()
        {
            InitializeComponent();
            btnConfirm.Click += btnConfirm_Click;
            tbNewPass.UseSystemPasswordChar = true;
            tbNewPassAg.UseSystemPasswordChar = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var p1 = tbNewPass.Text;
            var p2 = tbNewPassAg.Text;
            if (string.IsNullOrWhiteSpace(p1) || p1.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (p1 != p2)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (ok, message) = _forgot.ResetPassword(RequestId, p1);
            if (!ok)
            {
                MessageBox.Show(message, "Không thể đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDone?.Invoke(this, false);
                return;
            }

            MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetDone?.Invoke(this, true);
        }
    }
}
