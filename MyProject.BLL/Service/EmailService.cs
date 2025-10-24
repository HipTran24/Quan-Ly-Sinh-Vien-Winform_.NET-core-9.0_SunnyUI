using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL.Service
{
    public class EmailService
    {

        private readonly string _fromEmail = "thanhhiepegn2412@gmail.com"; // Gmail của bạn
        private readonly string _password = "zhlk mwul augf cxqw";    // App Password 16 ký tự
        private readonly string _displayName = "Quản lý sinh viên HUTECH";

        public async Task SendAccountActivationEmailAsync(string toEmail, string username, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_displayName, _fromEmail));
            message.To.Add(MailboxAddress.Parse(toEmail));
            message.Subject = "Tài khoản sinh viên đã được kích hoạt";

            message.Body = new TextPart("html")
            {
                Text = $@"
                    <h3>Xin chào!</h3>
                    <p>Tài khoản sinh viên của bạn đã được kích hoạt thành công.</p>
                    <p><b>Username:</b> {username}<br/>
                    <b>Password:</b> {password}</p>
                    <p>Vui lòng đăng nhập và đổi mật khẩu khi sử dụng lần đầu.</p>
                    <hr/>
                    <p><i>Quản lý sinh viên HUTECH</i></p>
                "
            };

            using var client = new SmtpClient();
            try
            {
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_fromEmail, _password);
                await client.SendAsync(message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gửi email: " + ex.Message);
            }
            finally
            {
                await client.DisconnectAsync(true);
            }
        }
        public async Task SendOtpEmailAsync(string toEmail, string otp)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_displayName, _fromEmail));
            message.To.Add(MailboxAddress.Parse(toEmail));
            message.Subject = "Mã OTP xác thực đặt lại mật khẩu";

            message.Body = new TextPart("html")
            {
                Text = $@"
            <h3>Xin chào!</h3>
            <p>Bạn vừa yêu cầu đặt lại mật khẩu. Đây là mã OTP của bạn (hiệu lực 5 phút):</p>
            <p style='font-size:20px'><b>{otp}</b></p>
            <p>Nếu không phải bạn, hãy bỏ qua email này.</p>
            <hr/>
            <p><i>Quản lý sinh viên HUTECH</i></p>
        "
            };

            using var client = new SmtpClient();
            try
            {
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_fromEmail, _password);
                await client.SendAsync(message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gửi email OTP: " + ex.Message);
            }
            finally
            {
                await client.DisconnectAsync(true);
            }
        }
    }
}

