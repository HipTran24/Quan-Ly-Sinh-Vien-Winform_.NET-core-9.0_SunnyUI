using Microsoft.EntityFrameworkCore;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Faculty> Khoa { get; set; }
        public DbSet<Lecturers> GiangVien { get; set; }
        public DbSet<ClassRoom> LopHoc { get; set; }
        public DbSet<Students> SinhVien { get; set; }
        public DbSet<Subjects> MonHoc { get; set; }
        public DbSet<AppUsers> Users { get; set; }
        public DbSet<Score> Diem { get; set; }
        public DbSet<Calendars> LichGiangDay { get; set; }

        public DbSet<Notify> ThongBao { get; set; }

        public DbSet<SoftwareInfo> ThongtinPM { get; set; }
 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=LAPTOP-I92LRI56;Database=QUANLYSINHVIEN;User ID=sa;Password=Th@123456a;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-N6NQASQN;Database=QUANLYSINHVIEN;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ==========================
            // 🔹 KHOA - LỚP / GIẢNG VIÊN / MÔN HỌC
            // ==========================
            modelBuilder.Entity<ClassRoom>()
                .HasOne(c => c.faculty)
                .WithMany(f => f.classrooms)
                .HasForeignKey(c => c.MaKhoa)
                .OnDelete(DeleteBehavior.Restrict); // ❌ Không cascade để tránh vòng

            modelBuilder.Entity<Lecturers>()
                .HasOne(l => l.faculty)
                .WithMany(f => f.lecturers)
                .HasForeignKey(l => l.MaKhoa)
                .OnDelete(DeleteBehavior.Restrict); // ❌ Không cascade

            modelBuilder.Entity<Subjects>()
                .HasOne(s => s.faculty)
                .WithMany(f => f.subjects)
                .HasForeignKey(s => s.MaKhoa)
                .OnDelete(DeleteBehavior.Restrict); // ❌ Không cascade


            // ==========================
            // 🔹 LỚP - SINH VIÊN
            // ==========================
            modelBuilder.Entity<Students>()
                .HasOne(s => s.classrooms)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.MaLop)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa lớp thì xóa sinh viên


            // ==========================
            // 🔹 SINH VIÊN - ĐIỂM
            // ==========================
            modelBuilder.Entity<Score>()
                .HasOne(sc => sc.students)
                .WithMany(s => s.Scores)
                .HasForeignKey(sc => sc.MaSV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa sinh viên thì xóa điểm


            // 🔹 MÔN HỌC - ĐIỂM
            modelBuilder.Entity<Score>()
                .HasOne(sc => sc.subjects)
                .WithMany(sb => sb.Scores)
                .HasForeignKey(sc => sc.MaMH)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa môn học thì xóa điểm


            // ==========================
            // 🔹 USERS (Sinh viên / Giảng viên)
            // ==========================
            modelBuilder.Entity<AppUsers>()
                .HasOne(u => u.students)
                .WithOne(s => s.users)
                .HasForeignKey<AppUsers>(u => u.MaSV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa sinh viên thì xóa user

            modelBuilder.Entity<AppUsers>()
                .HasOne(u => u.lecturers)
                .WithMany(l => l.users)
                .HasForeignKey(u => u.MaGV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa giảng viên thì xóa user


            // ==========================
            // 🔹 SCORE & CALENDARS (Composite Keys)
            // ==========================
            modelBuilder.Entity<Score>()
                .HasKey(s => new { s.MaSV, s.MaMH });

            modelBuilder.Entity<Calendars>()
                .HasKey(l => new { l.MaMH, l.MaGV });


            // ==========================
            // 🔹 CALENDARS - SUBJECTS / LECTURERS
            // ==========================
            modelBuilder.Entity<Calendars>()
                .HasOne(l => l.MonHoc)
                .WithMany(m => m.LichGiangDay)
                .HasForeignKey(l => l.MaMH)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa môn thì xóa lịch

            modelBuilder.Entity<Calendars>()
                .HasOne(l => l.GiangVien)
                .WithMany(gv => gv.LichGiangDay)
                .HasForeignKey(l => l.MaGV)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Xóa GV thì xóa lịch

            modelBuilder.Entity<Calendars>()
                .Property(l => l.Ngay)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));


            // ==========================
            // 🔹 STUDENTS - DateOnly conversion
            // ==========================
            modelBuilder.Entity<Students>()
                .Property(s => s.NgaySinh)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));


            // ==========================
            // 🔹 SUBJECTS - DateOnly conversion
            // ==========================
            modelBuilder.Entity<Subjects>()
                .Property(s => s.NgayBatDau)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));

            modelBuilder.Entity<Subjects>()
                .Property(s => s.NgayKetThuc)
                .HasConversion(
                    v => v.ToDateTime(TimeOnly.MinValue),
                    v => DateOnly.FromDateTime(v));


            // ==========================
            // 🔹 NOTIFY - ADMIN (USER)
            // ==========================
            modelBuilder.Entity<Notify>()
                .HasOne(n => n.Admin)
                .WithMany(u => u.Notifies)
                .HasForeignKey(n => n.Username)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notify>()
                .ToTable("ThongBao")
                .HasKey(n => n.MaTB);


            base.OnModelCreating(modelBuilder);
            // 1. Faculty
           
        }
    }
}
