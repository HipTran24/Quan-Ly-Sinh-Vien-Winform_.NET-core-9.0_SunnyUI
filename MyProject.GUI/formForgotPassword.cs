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
    public partial class formForgotPassword : Form
    {
        private readonly ForgotPasswordBLL _forgot = new ForgotPasswordBLL();

        public formForgotPassword()
        {
            InitializeComponent();
            // <--- XÓA: btnConfirm.Click += btnConfirm_Click; (Designer đã gán)
        }

        private void LoadControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var email = tbEmail.Text.Trim();
            var (ok, message, requestId, username, _) = _forgot.StartByEmail(email);
            if (!ok)
            {
                MessageBox.Show(message ?? "Không thể khởi tạo phiên đặt lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(message!, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Load UC nhập OTP
            var uc = new ucConfirmOTP
            {
                RequestId = requestId!,
                Username = username!,
                Email = email
            };

            // Gắn duy nhất 1 handler cho event OtpVerified
            uc.OtpVerified += Uc_OtpVerified;

            // Chỉ gọi 1 lần LoadControl
            LoadControl(uc);
        }

        private void Uc_OtpVerified(object? sender, EventArgs e)
        {
            var ucOtp = sender as ucConfirmOTP;
            var reset = new ucResetPassword
            {
                RequestId = ucOtp!.RequestId,
                Username = ucOtp!.Username
            };
            reset.ResetDone += (s2, ok2) =>
            {
                if (ok2)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            };
            LoadControl(reset);
        }
    }
}
