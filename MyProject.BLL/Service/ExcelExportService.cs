using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using MyProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL.Service
{
    public class ExcelExportService
    {
        private readonly AppDbContext _db;
        public ExcelExportService() => _db = new AppDbContext();

        // ======================
        // 1️⃣ Xuất sinh viên
        // ======================
        public void ExportStudentsOnly(string filePath)
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("SinhVien");

            string[] headers = { "Mã SV", "Họ tên", "Mã lớp", "Tên lớp", "Ngày sinh", "Giới tính", "Địa chỉ", "Email", "SĐT" };
            for (int i = 0; i < headers.Length; i++)
                ws.Cell(1, i + 1).Value = headers[i];
            ws.Range(1, 1, 1, headers.Length).Style.Font.Bold = true;

            var list = _db.SinhVien
                .Include(s => s.classrooms)
                .Select(s => new
                {
                    s.MaSV,
                    s.HoTen,
                    s.MaLop,
                    TenLop = s.classrooms != null ? s.classrooms.TenLop : "",
                    NgaySinh = s.NgaySinh.ToDateTime(TimeOnly.MinValue),
                    s.GioiTinh,
                    s.DiaChi,
                    s.Email,
                    s.SDT
                }).ToList();

            int r = 2;
            foreach (var sv in list)
            {
                ws.Cell(r, 1).Value = sv.MaSV;
                ws.Cell(r, 2).Value = sv.HoTen;
                ws.Cell(r, 3).Value = sv.MaLop;
                ws.Cell(r, 4).Value = sv.TenLop;
                ws.Cell(r, 5).Value = sv.NgaySinh;
                ws.Cell(r, 6).Value = sv.GioiTinh;
                ws.Cell(r, 7).Value = sv.DiaChi;
                ws.Cell(r, 8).Value = sv.Email;
                ws.Cell(r, 9).Value = sv.SDT;
                r++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(filePath);
        }

        // ======================
        // 2️⃣ Xuất giảng viên
        // ======================
        public void ExportLecturersOnly(string filePath)
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("GiangVien");

            string[] headers = { "Mã GV", "Họ tên", "Mã khoa", "Tên khoa", "Email", "SĐT" };
            for (int i = 0; i < headers.Length; i++)
                ws.Cell(1, i + 1).Value = headers[i];
            ws.Range(1, 1, 1, headers.Length).Style.Font.Bold = true;

            var list = _db.GiangVien
                .Include(g => g.faculty)
                .Select(g => new
                {
                    g.MaGV,
                    g.HoTen,
                    g.MaKhoa,
                    TenKhoa = g.faculty != null ? g.faculty.TenKhoa : "",
                    g.Email,
                    g.SDT
                }).ToList();

            int r = 2;
            foreach (var gv in list)
            {
                ws.Cell(r, 1).Value = gv.MaGV;
                ws.Cell(r, 2).Value = gv.HoTen;
                ws.Cell(r, 3).Value = gv.MaKhoa;
                ws.Cell(r, 4).Value = gv.TenKhoa;
                ws.Cell(r, 5).Value = gv.Email;
                ws.Cell(r, 6).Value = gv.SDT;
                r++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(filePath);
        }

        // ======================
        // 3️⃣ Xuất bảng điểm
        // ======================
        public void ExportScoresOnly(string filePath)
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("BangDiem");

            string[] headers = { "Mã SV", "Họ tên SV", "Mã MH", "Tên môn học", "Điểm GK", "Điểm CK", "Điểm TB", "Học kỳ" };
            for (int i = 0; i < headers.Length; i++)
                ws.Cell(1, i + 1).Value = headers[i];
            ws.Range(1, 1, 1, headers.Length).Style.Font.Bold = true;

            var list = _db.Diem
                .Include(d => d.students)
                .Include(d => d.subjects)
                .Select(d => new
                {
                    d.MaSV,
                    HoTenSV = d.students != null ? d.students.HoTen : "",
                    d.MaMH,
                    TenMH = d.subjects != null ? d.subjects.TenMH : "",
                    d.DiemGK,
                    d.DiemCK,
                    d.DiemTrungBinh,
                    d.HocKy
                }).ToList();

            int r = 2;
            foreach (var d in list)
            {
                ws.Cell(r, 1).Value = d.MaSV;
                ws.Cell(r, 2).Value = d.HoTenSV;
                ws.Cell(r, 3).Value = d.MaMH;
                ws.Cell(r, 4).Value = d.TenMH;
                ws.Cell(r, 5).Value = d.DiemGK;
                ws.Cell(r, 6).Value = d.DiemCK;
                ws.Cell(r, 7).Value = d.DiemTrungBinh;
                ws.Cell(r, 8).Value = d.HocKy;
                r++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(filePath);
        }
    }
}
