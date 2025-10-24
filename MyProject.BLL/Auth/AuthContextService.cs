using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL.Auth
{
    public static class AuthContextService
    {
        public static AppUsers? CurrentUser { get; private set; }
        public static bool IsLoggedIn => CurrentUser != null;

        public static string? Role => CurrentUser?.Role;
        public static string? AccountName => CurrentUser?.Username;

        private static string? NormalizedRole
        {
            get
            {
                var r = Role?.Trim();
                if (string.IsNullOrEmpty(r)) return null;

                var lower = r.ToLowerInvariant();
                if (lower is "lecturer" or "giangvien" or "giảng viên" or "gv")
                    return "Lecturer";
                if (lower is "student" or "sinhvien" or "sinh viên" or "sv")
                    return "Student";
                if (lower is "admin" or "quản trị" or "quantri")
                    return "Admin";

                return char.ToUpper(lower[0]) + lower.Substring(1);
            }
        }

        public static string EffectiveRole
        {
            get
            {
                var norm = NormalizedRole;
                if (string.Equals(norm, "Admin", StringComparison.OrdinalIgnoreCase)) return "Admin";
                if (string.Equals(norm, "Lecturer", StringComparison.OrdinalIgnoreCase)) return "Lecturer";
                if (string.Equals(norm, "Student", StringComparison.OrdinalIgnoreCase)) return "Student";

                if (CurrentUser?.lecturers != null) return "Lecturer";
                if (CurrentUser?.students != null) return "Student";
                return "Khác";
            }
        }

        public static bool IsAdmin => string.Equals(EffectiveRole, "Admin", StringComparison.OrdinalIgnoreCase);
        public static bool IsLecturer => string.Equals(EffectiveRole, "Lecturer", StringComparison.OrdinalIgnoreCase)
                                        || CurrentUser?.lecturers != null; 
        public static bool IsStudent => string.Equals(EffectiveRole, "Student", StringComparison.OrdinalIgnoreCase)
                                        || CurrentUser?.students != null;  

        public static void SignIn(AppUsers user)
        {
            CurrentUser = user;
        }

        public static void SignOut()
        {
            CurrentUser = null;
        }

        public static void RefreshUser(AppUsers user)
        {
            if (user == null) return;
            CurrentUser = user;
        }
        public static string? AdminID =>           
           (CurrentUser?.AdminID?.ToString())    
          ?? null;

        public static string DisplayName =>
             CurrentUser?.lecturers?.HoTen
            ?? CurrentUser?.students?.HoTen
            ?? CurrentUser?.Username
            ?? "N/A";
    }
}
