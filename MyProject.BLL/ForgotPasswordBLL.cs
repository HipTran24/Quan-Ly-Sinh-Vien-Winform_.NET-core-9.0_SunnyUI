using MyProject.BLL.Auth;
using MyProject.BLL.Service;
using MyProject.DAL;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class ForgotPasswordBLL
    {
        private readonly IUserRepository _userRepo;
        private readonly EmailService _email;
        public ForgotPasswordBLL()
        {
            _userRepo = new UserRepository();
            _email = new EmailService();
        }

        /// <summary>
        /// B1: Nhập email. Tìm user thuộc Sinh viên/Giảng viên có email này.
        /// Nếu có -> tạo OTP session và gửi OTP qua email. Trả về requestId + username.
        /// </summary>
        public (bool ok, string? message, string? requestId, string? username, string? email) StartByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return (false, "Vui lòng nhập email.", null, null, null);

            using var db = new AppDbContext();

            // Ưu tiên SV trước, sau đó GV
            var sv = db.SinhVien
                   .FirstOrDefault(s => s.Email != null && s.Email.ToLower() == email.ToLower());
            string? username = null;

            if (sv != null)
            {
                username = db.Users.FirstOrDefault(u => u.MaSV == sv.MaSV)?.Username;
            }
            else
            {
                var gv = db.GiangVien
                     .FirstOrDefault(g => g.Email != null && g.Email.ToLower() == email.ToLower());
                if (gv != null)
                {
                    username = db.Users.FirstOrDefault(u => u.MaGV == gv.MaGV)?.Username;
                }
            }

            if (string.IsNullOrWhiteSpace(username))
                return (false, "Không tìm thấy tài khoản gắn với email này.", null, null, null);

            // Tạo OTP
            string otp;
            string requestId = OtpService.Create(username!, email, out otp, digits: 6, ttlMinutes: 5);

            // Gửi mail – không chặn UI
            _ = _email.SendOtpEmailAsync(email, otp);

            return (true, "Đã gửi OTP đến email của bạn (hiệu lực 5 phút).", requestId, username, email);
        }

        /// <summary>
        /// B2: Xác thực OTP. Nếu đúng -> cho phép bước reset.
        /// </summary>
        public (bool ok, string message) VerifyOtp(string requestId, string otp)
        {
            if (string.IsNullOrWhiteSpace(requestId) || string.IsNullOrWhiteSpace(otp))
                return (false, "Thiếu requestId hoặc OTP.");

            return OtpService.Verify(requestId, otp);
        }

        /// <summary>
        /// B3: Đặt lại mật khẩu (sau khi OTP đã verify).
        /// </summary>
        public (bool ok, string message) ResetPassword(string requestId, string newPassword)
        {
            if (!OtpService.TryGet(requestId, out var username, out _, out var verified) || string.IsNullOrWhiteSpace(username))
                return (false, "Phiên không hợp lệ hoặc đã hết hạn.");

            if (!verified)
                return (false, "Bạn chưa xác thực OTP.");

            if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
                return (false, "Mật khẩu mới phải có ít nhất 6 ký tự.");

            var user = _userRepo.GetById(username!);
            if (user == null) return (false, "Không tìm thấy tài khoản.");

            // Hash & lưu
            user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            _userRepo.Update(user);

            // Kết thúc phiên
            OtpService.Invalidate(requestId);

            return (true, "Đổi mật khẩu thành công. Bạn có thể đăng nhập với mật khẩu mới.");
        }
    }
}
