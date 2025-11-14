using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV001" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV001" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV001" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV002" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV002" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV002" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV003" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV003" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV003" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV004" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV004" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV004" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV005" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV005" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV005" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV006" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV006" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV007" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV007" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV008" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV008" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV009" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH002", "SV009" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH001", "SV010" });

            migrationBuilder.DeleteData(
                table: "Diem",
                keyColumns: new[] { "MaMH", "MaSV" },
                keyValues: new object[] { "MH003", "SV010" });

            migrationBuilder.DeleteData(
                table: "GiangVien",
                keyColumn: "MaGV",
                keyValue: "GV003");

            migrationBuilder.DeleteData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV001", "MH001" });

            migrationBuilder.DeleteData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV001", "MH002" });

            migrationBuilder.DeleteData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV002", "MH003" });

            migrationBuilder.DeleteData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV002", "MH004" });

            migrationBuilder.DeleteData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV004", "MH005" });

            migrationBuilder.DeleteData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV004", "MH006" });

            migrationBuilder.DeleteData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV005", "MH007" });

            migrationBuilder.DeleteData(
                table: "ThongBao",
                keyColumn: "MaTB",
                keyValue: "TB001");

            migrationBuilder.DeleteData(
                table: "ThongBao",
                keyColumn: "MaTB",
                keyValue: "TB002");

            migrationBuilder.DeleteData(
                table: "ThongtinPM",
                keyColumn: "MaPM",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "gv001");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "gv002");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "sv001");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "sv002");

            migrationBuilder.DeleteData(
                table: "GiangVien",
                keyColumn: "MaGV",
                keyValue: "GV001");

            migrationBuilder.DeleteData(
                table: "GiangVien",
                keyColumn: "MaGV",
                keyValue: "GV002");

            migrationBuilder.DeleteData(
                table: "GiangVien",
                keyColumn: "MaGV",
                keyValue: "GV004");

            migrationBuilder.DeleteData(
                table: "GiangVien",
                keyColumn: "MaGV",
                keyValue: "GV005");

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MaMH",
                keyValue: "MH001");

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MaMH",
                keyValue: "MH002");

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MaMH",
                keyValue: "MH003");

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MaMH",
                keyValue: "MH004");

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MaMH",
                keyValue: "MH005");

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MaMH",
                keyValue: "MH006");

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MaMH",
                keyValue: "MH007");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV001");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV002");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV003");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV004");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV005");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV006");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV007");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV008");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV009");

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "MaSV",
                keyValue: "SV010");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin01");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin02");

            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "MaKhoa",
                keyValue: "KH003");

            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "MaKhoa",
                keyValue: "KH004");

            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "MaKhoa",
                keyValue: "KH005");

            migrationBuilder.DeleteData(
                table: "LopHoc",
                keyColumn: "MaLop",
                keyValue: "LOP001");

            migrationBuilder.DeleteData(
                table: "LopHoc",
                keyColumn: "MaLop",
                keyValue: "LOP002");

            migrationBuilder.DeleteData(
                table: "LopHoc",
                keyColumn: "MaLop",
                keyValue: "LOP003");

            migrationBuilder.DeleteData(
                table: "LopHoc",
                keyColumn: "MaLop",
                keyValue: "LOP004");

            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "MaKhoa",
                keyValue: "KH001");

            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "MaKhoa",
                keyValue: "KH002");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Khoa",
                columns: new[] { "MaKhoa", "EmailKhoa", "PhongCongTac", "SoLuongLop", "TenKhoa", "TruongKhoa" },
                values: new object[,]
                {
                    { "KH001", "cntt@hutech.edu.vn", "Phòng A101", 25L, "Công nghệ Thông tin", "Nguyễn Văn An" },
                    { "KH002", "kinhte@hutech.edu.vn", "Phòng B201", 30L, "Kinh tế", "Trần Thị Bình" },
                    { "KH003", "cokhi@hutech.edu.vn", "Phòng C301", 20L, "Cơ khí", "Lê Văn Cường" },
                    { "KH004", "dientu@hutech.edu.vn", "Phòng D401", 15L, "Điện - Điện tử", "Phạm Thị Dung" },
                    { "KH005", "qtkd@hutech.edu.vn", "Phòng E501", 18L, "Quản trị Kinh doanh", "Hoàng Văn Minh" }
                });

            migrationBuilder.InsertData(
                table: "ThongtinPM",
                columns: new[] { "MaPM", "MoTa", "TenPM" },
                values: new object[] { 1, "Phần mềm được phát triển nhằm hỗ trợ quản lý toàn diện thông tin sinh viên, giảng viên, lớp học và kết quả học tập. Hệ thống cho phép admin quản lý dữ liệu trung tâm, giảng viên có thể nhập điểm và cập nhật lịch giảng dạy, sinh viên có thể tra cứu thông tin cá nhân, lịch học, điểm số cũng như nhận các thông báo mới nhất từ nhà trường. Phần mềm được xây dựng dựa trên nền tảng Entity Framework Core, hỗ trợ kết nối cơ sở dữ liệu SQL Server, giao diện thân thiện dễ sử dụng, phân quyền rõ ràng giữa admin, giảng viên và sinh viên. Mục tiêu chính là giảm tải công việc quản lý thủ công, tăng tính chính xác của dữ liệu và nâng cao trải nghiệm cho người dùng.", "Phần mềm Quản Lý Sinh Viên" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "AdminID", "MaGV", "MaSV", "Password", "Role" },
                values: new object[,]
                {
                    { "admin01", "AD001", null, null, "admin123", "Admin" },
                    { "admin02", "AD002", null, null, "admin456", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "GiangVien",
                columns: new[] { "MaGV", "Email", "HoTen", "MaKhoa", "SDT" },
                values: new object[,]
                {
                    { "GV001", "an.nguyen@hutech.edu.vn", "Nguyễn Văn An", "KH001", "0912345678" },
                    { "GV002", "binh.tran@hutech.edu.vn", "Trần Thị Bình", "KH002", "0987654321" },
                    { "GV003", "cuong.le@hutech.edu.vn", "Lê Văn Cường", "KH001", "0901234567" },
                    { "GV004", "dung.pham@hutech.edu.vn", "Phạm Thị Dung", "KH003", "0934567890" },
                    { "GV005", "minh.hoang@hutech.edu.vn", "Hoàng Văn Minh", "KH002", "0978889999" }
                });

            migrationBuilder.InsertData(
                table: "LopHoc",
                columns: new[] { "MaLop", "KhoaHoc", "MaGV", "MaKhoa", "SoLuongSV", "TenLop" },
                values: new object[,]
                {
                    { "LOP001", "2021-2025", "GV001", "KH001", 0, "CNTT1" },
                    { "LOP002", "2021-2025", "GV002", "KH001", 0, "CNTT2" },
                    { "LOP003", "2021-2025", "GV003", "KH002", 0, "QTKD1" },
                    { "LOP004", "2021-2025", "GV004", "KH002", 0, "QTKD2" }
                });

            migrationBuilder.InsertData(
                table: "MonHoc",
                columns: new[] { "MaMH", "MaKhoa", "NgayBatDau", "NgayKetThuc", "SoTiet", "SoTinChi", "TenMH" },
                values: new object[,]
                {
                    { "MH001", "KH001", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, "Lập trình C#" },
                    { "MH002", "KH001", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, "Cơ sở dữ liệu" },
                    { "MH003", "KH002", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 2, "Kinh tế vi mô" },
                    { "MH004", "KH002", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 2, "Nguyên lý kế toán" },
                    { "MH005", "KH003", new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, "Vẽ kỹ thuật" },
                    { "MH006", "KH004", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, "Điện tử cơ bản" },
                    { "MH007", "KH005", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 2, "Quản trị học" }
                });

            migrationBuilder.InsertData(
                table: "ThongBao",
                columns: new[] { "MaTB", "AnhURL", "CreatedAt", "NoiDung", "TieuDe", "Username" },
                values: new object[,]
                {
                    { "TB001", null, new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toàn thể giảng viên họp vào thứ Hai, 9h tại hội trường.", "Thông báo họp", "admin01" },
                    { "TB002", "/images/guide.png", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinh viên đăng ký học phần trước ngày 15/10.", "Đăng ký học phần", "admin02" }
                });

            migrationBuilder.InsertData(
                table: "LichGiangDay",
                columns: new[] { "MaGV", "MaMH", "Ngay", "PhongHoc", "TietHoc" },
                values: new object[,]
                {
                    { "GV001", "MH001", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A101", "1-3" },
                    { "GV001", "MH002", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A102", "4-6" },
                    { "GV002", "MH003", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "B201", "7-9" },
                    { "GV002", "MH004", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "B202", "1-3" },
                    { "GV004", "MH005", new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "C301", "4-6" },
                    { "GV004", "MH006", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "D401", "7-9" },
                    { "GV005", "MH007", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "E501", "1-3" }
                });

            migrationBuilder.InsertData(
                table: "SinhVien",
                columns: new[] { "MaSV", "DiaChi", "Email", "GioiTinh", "HoTen", "MaLop", "NgaySinh", "SDT" },
                values: new object[,]
                {
                    { "SV001", "TP.HCM", "a@gmail.com", "Nam", "Nguyễn Văn A", "LOP001", new DateTime(2003, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567" },
                    { "SV002", "Hà Nội", "b@gmail.com", "Nữ", "Trần Thị B", "LOP001", new DateTime(2004, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678" },
                    { "SV003", "Đà Nẵng", "c@gmail.com", "Nam", "Lê Văn C", "LOP002", new DateTime(2002, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0923456789" },
                    { "SV004", "Cần Thơ", "d@gmail.com", "Nữ", "Phạm Thị D", "LOP002", new DateTime(2003, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0934567890" },
                    { "SV005", "Hải Phòng", "e@gmail.com", "Nam", "Hoàng Văn E", "LOP003", new DateTime(2001, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0945678901" },
                    { "SV006", "Huế", "f@gmail.com", "Nữ", "Đỗ Thị F", "LOP003", new DateTime(2004, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0956789012" },
                    { "SV007", "Bình Dương", "g@gmail.com", "Nam", "Ngô Văn G", "LOP004", new DateTime(2002, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0967890123" },
                    { "SV008", "Nha Trang", "h@gmail.com", "Nữ", "Võ Thị H", "LOP004", new DateTime(2003, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0978901234" },
                    { "SV009", "Quảng Ninh", "i@gmail.com", "Nam", "Bùi Văn I", "LOP001", new DateTime(2001, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0989012345" },
                    { "SV010", "Quảng Ninh", "i@gmail.com", "Nam", "Bùi Văn I", "LOP001", new DateTime(2001, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0989012345" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "AdminID", "MaGV", "MaSV", "Password", "Role" },
                values: new object[,]
                {
                    { "gv001", null, "GV001", null, "123456", "Lecturer" },
                    { "gv002", null, "GV002", null, "123456", "Lecturer" }
                });

            migrationBuilder.InsertData(
                table: "Diem",
                columns: new[] { "MaMH", "MaSV", "DiemCK", "DiemGK", "DiemTrungBinh", "HocKy" },
                values: new object[,]
                {
                    { "MH001", "SV001", 8f, 7f, 7.5f, "HK1A-2025-2026" },
                    { "MH002", "SV001", 7f, 6f, 6.5f, "HK2A-2025-2026" },
                    { "MH003", "SV001", 8f, 7f, 7.5f, "HK3-2025-2026" },
                    { "MH001", "SV002", 7f, 6f, 6.5f, "HK3-2025-2026" },
                    { "MH002", "SV002", 7f, 6f, 6.5f, "HK1A-2025-2026" },
                    { "MH003", "SV002", 7.5f, 7f, 7.25f, "HK2A-2025-2026" },
                    { "MH001", "SV003", 8.5f, 8f, 8.25f, "HK2A-2025-2026" },
                    { "MH002", "SV003", 8.5f, 8f, 8.25f, "HK3-2025-2026" },
                    { "MH003", "SV003", 8.5f, 8f, 8.25f, "HK1A-2025-2026" },
                    { "MH001", "SV004", 9.5f, 9f, 9.25f, "HK1A-2025-2026" },
                    { "MH002", "SV004", 6f, 5.5f, 5.75f, "HK2A-2025-2026" },
                    { "MH003", "SV004", 9.5f, 9f, 9.25f, "HK3-2025-2026" },
                    { "MH001", "SV005", 6f, 5.5f, 5.75f, "HK3-2025-2026" },
                    { "MH002", "SV005", 6f, 5.5f, 5.75f, "HK1A-2025-2026" },
                    { "MH003", "SV005", 9.5f, 9f, 9.25f, "HK2A-2025-2026" },
                    { "MH001", "SV006", 7f, 6.5f, 6.75f, "HK1B-2025-2026" },
                    { "MH002", "SV006", 8f, 7.5f, 7.75f, "HK2B-2025-2026" },
                    { "MH001", "SV007", 8.5f, 8f, 8.25f, "HK2B-2025-2026" },
                    { "MH003", "SV007", 8f, 7.5f, 7.75f, "HK1B-2025-2026" },
                    { "MH002", "SV008", 9f, 8.5f, 8.75f, "HK1B-2025-2026" },
                    { "MH003", "SV008", 7f, 6.5f, 6.75f, "HK2B-2025-2026" },
                    { "MH001", "SV009", 9.5f, 9f, 9.25f, "HK1B-2025-2026" },
                    { "MH002", "SV009", 9.5f, 9f, 9.25f, "HK2B-2025-2026" },
                    { "MH001", "SV010", 6f, 5f, 5.5f, "HK2B-2025-2026" },
                    { "MH003", "SV010", 6f, 5f, 5.5f, "HK1B-2025-2026" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "AdminID", "MaGV", "MaSV", "Password", "Role" },
                values: new object[,]
                {
                    { "sv001", null, null, "SV001", "123456", "Student" },
                    { "sv002", null, null, "SV002", "123456", "Student" }
                });
        }
    }
}
