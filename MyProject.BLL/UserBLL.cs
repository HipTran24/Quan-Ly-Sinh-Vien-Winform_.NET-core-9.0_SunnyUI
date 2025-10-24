using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.BLL.Auth;
using MyProject.BLL.Service;
using MyProject.DAL;
using MyProject.DAL.Models;
using MyProject.DAL.Repositories;

namespace MyProject.BLL
{
    public class UserBLL
    {
        private readonly IUserRepository _repo;

        public UserBLL()
        {
            _repo = new UserRepository();
        }

        public List<AppUsers> GetAllUser()
        {
            return _repo.GetAll();
        }

        public AppUsers? Login(string username, string inputPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(inputPassword))
                return null;

            // Lấy user từ repo (chưa có Include)
            var user = _repo
                .GetAll()
                .FirstOrDefault(u => u.Username != null &&
                                     u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user == null) return null;

            // ===== Verify mật khẩu =====
            if (!string.IsNullOrWhiteSpace(user.Password))
            {
                if (!BCrypt.Net.BCrypt.Verify(inputPassword, user.Password))
                {
                    // Nếu DB còn plaintext: nâng cấp mềm
                    if (user.Password != inputPassword) return null;
                    user.Password = BCrypt.Net.BCrypt.HashPassword(inputPassword);
                    _repo.Update(user);
                }
            }
            else
            {
                return null;
            }
            HydrateUserRelations(user, username); 


            // (tuỳ chọn) nếu Role rỗng thì set theo navigation
            if (string.IsNullOrWhiteSpace(user.Role))
            {
                if (user.lecturers != null) user.Role = "Lecturer";
                else if (user.students != null) user.Role = "Student";
            }
            AuthContextService.SignIn(user);

            return user;
        }

        private void HydrateUserRelations(AppUsers user, string username)
        {
            if (user == null) return;

            using (var db = new AppDbContext())
            {
                var key = (username ?? "").Trim();

                if (user.students == null)
                {
                    var sv = db.SinhVien.FirstOrDefault(s =>
                        (s.Email != null && s.Email == key) ||
                        (s.SDT != null && s.SDT == key) ||
                        (!string.IsNullOrWhiteSpace(user.MaSV) && s.MaSV == user.MaSV)
                    );
                    if (sv != null) user.students = sv;
                }

                if (user.lecturers == null)
                {
                    var gv = db.GiangVien.FirstOrDefault(l =>
                        (l.Email != null && l.Email == key) ||
                        (l.SDT != null && l.SDT == key) ||
                        (!string.IsNullOrWhiteSpace(user.MaGV) && l.MaGV == user.MaGV)
                    );
                    if (gv != null) user.lecturers = gv;
                }
            }
        }

        public void Add(AppUsers user)
        {
            var db = new AppDbContext();
            var student = db.SinhVien.FirstOrDefault(s => s.MaSV == user.MaSV);
            if (student != null && !string.IsNullOrEmpty(student.Email))
            {
                var emailService = new EmailService();
                _ = emailService.SendAccountActivationEmailAsync(
                    student.Email,
                    user.Username,
                    user.Password 
                );
            }
            if (!string.IsNullOrWhiteSpace(user?.Password))
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            }
            
            _repo.Add(user);

        }
        public void Update(AppUsers user)
        {
            if (!string.IsNullOrWhiteSpace(user?.Password))
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            }

            _repo.Update(user);
        }

        public void Delete(string username)
        {
            _repo.Delete(username);
        }
    }
}
