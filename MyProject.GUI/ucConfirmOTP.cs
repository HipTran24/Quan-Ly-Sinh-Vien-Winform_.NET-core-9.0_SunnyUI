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
    public partial class ucConfirmOTP : UserControl
    {
        private readonly ForgotPasswordBLL _forgot = new ForgotPasswordBLL();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RequestId { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Email { get; set; } = "";

        public event EventHandler? OtpVerified;
        public ucConfirmOTP()
        {
            InitializeComponent();
            // <--- XÓA nếu đã có ở Designer: btnConfirmOTP.Click += btnConfirmOTP_Click;
        }

        private void btnConfirmOTP_Click(object sender, EventArgs e)
        {
            var otp = tbOPT.Text.Trim();
            var (ok, message) = _forgot.VerifyOtp(RequestId, otp);
            if (!ok)
            {
                MessageBox.Show(message, "OTP không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("OTP hợp lệ! Vui lòng đặt lại mật khẩu.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OtpVerified?.Invoke(this, EventArgs.Empty);
        }
    }
}
