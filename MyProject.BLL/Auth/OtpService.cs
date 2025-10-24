using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL.Auth
{
    public class OtpService
    {
        private class OtpSession
        {
            public string Username { get; set; } = "";
            public string Email { get; set; } = "";
            public string OtpHash { get; set; } = "";
            public DateTime ExpiresAt { get; set; }
            public int Attempts { get; set; } = 0;
            public bool Verified { get; set; } = false;
        }

        private static readonly ConcurrentDictionary<string, OtpSession> _store = new();

        public static string Create(string username, string email, out string plainOtp, int digits = 6, int ttlMinutes = 5)
        {
            plainOtp = GenerateNumericCode(digits);
            var otpHash = BCrypt.Net.BCrypt.HashPassword(plainOtp);

            var id = Guid.NewGuid().ToString("N");
            _store[id] = new OtpSession
            {
                Username = username,
                Email = email,
                OtpHash = otpHash,
                ExpiresAt = DateTime.Now.AddMinutes(ttlMinutes),
                Attempts = 0,
                Verified = false
            };
            return id;
        }

        public static bool TryGet(string requestId, out string? username, out string? email, out bool verified)
        {
            username = null; email = null; verified = false;
            if (_store.TryGetValue(requestId, out var sess))
            {
                username = sess.Username;
                email = sess.Email;
                verified = sess.Verified;
                return true;
            }
            return false;
        }

        public static (bool ok, string message) Verify(string requestId, string inputOtp)
        {
            if (!_store.TryGetValue(requestId, out var sess))
                return (false, "Phiên yêu cầu không tồn tại hoặc đã hết hạn.");

            if (DateTime.Now > sess.ExpiresAt)
            {
                _store.TryRemove(requestId, out _);
                return (false, "OTP đã hết hạn. Vui lòng yêu cầu lại.");
            }

            if (sess.Attempts >= 5)
                return (false, "Bạn đã nhập sai quá số lần cho phép. Vui lòng yêu cầu lại OTP.");

            sess.Attempts++;

            if (!BCrypt.Net.BCrypt.Verify(inputOtp, sess.OtpHash))
                return (false, $"OTP không đúng. Còn {Math.Max(0, 5 - sess.Attempts)} lần thử.");

            sess.Verified = true;
            return (true, "Xác thực OTP thành công.");
        }

        public static void Invalidate(string requestId)
        {
            _store.TryRemove(requestId, out _);
        }

        private static string GenerateNumericCode(int length)
        {
            // Tạo mã số ngẫu nhiên an toàn
            using var rng = RandomNumberGenerator.Create();
            var bytes = new byte[length];
            rng.GetBytes(bytes);
            var sb = new StringBuilder(length);
            foreach (var b in bytes)
            {
                sb.Append((b % 10).ToString());
            }
            return sb.ToString();
        }
    }
}
