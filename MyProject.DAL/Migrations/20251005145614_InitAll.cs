using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class InitAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    MaKhoa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruongKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongCongTac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongLop = table.Column<long>(type: "bigint", nullable: false),
                    EmailKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.MaKhoa);
                });

            migrationBuilder.CreateTable(
                name: "ThongtinPM",
                columns: table => new
                {
                    MaPM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongtinPM", x => x.MaPM);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    MaGV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhoa = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.MaGV);
                    table.ForeignKey(
                        name: "FK_GiangVien_Khoa_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhoa = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    SoLuongSV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_LopHoc_Khoa_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    MaMH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenMH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false),
                    SoTiet = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaKhoa = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.MaMH);
                    table.ForeignKey(
                        name: "FK_MonHoc_Khoa_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_SinhVien_LopHoc_MaLop",
                        column: x => x.MaLop,
                        principalTable: "LopHoc",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichGiangDay",
                columns: table => new
                {
                    MaMH = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MaGV = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ngay = table.Column<DateOnly>(type: "date", nullable: false),
                    TietHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhongHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichGiangDay", x => new { x.MaMH, x.MaGV });
                    table.ForeignKey(
                        name: "FK_LichGiangDay_GiangVien_MaGV",
                        column: x => x.MaGV,
                        principalTable: "GiangVien",
                        principalColumn: "MaGV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichGiangDay_MonHoc_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MonHoc",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diem",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MaMH = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DiemGK = table.Column<float>(type: "real", nullable: false),
                    DiemCK = table.Column<float>(type: "real", nullable: false),
                    DiemTrungBinh = table.Column<float>(type: "real", nullable: false),
                    HocKy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diem", x => new { x.MaSV, x.MaMH });
                    table.ForeignKey(
                        name: "FK_Diem_MonHoc_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MonHoc",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diem_SinhVien_MaSV",
                        column: x => x.MaSV,
                        principalTable: "SinhVien",
                        principalColumn: "MaSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSV = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    MaGV = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    AdminID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                    table.ForeignKey(
                        name: "FK_Users_GiangVien_MaGV",
                        column: x => x.MaGV,
                        principalTable: "GiangVien",
                        principalColumn: "MaGV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_SinhVien_MaSV",
                        column: x => x.MaSV,
                        principalTable: "SinhVien",
                        principalColumn: "MaSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    MaTB = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TieuDe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.MaTB);
                    table.ForeignKey(
                        name: "FK_ThongBao_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

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
                values: new object[] { 1, "Phần mềm được phát triển nhằm hỗ trợ quản lý toàn diện thông tin sinh viên, giảng viên, lớp học và kết quả học tập. Hệ thống cho phép admin quản lý dữ liệu trung tâm, giảng viên có thể nhập điểm và cập nhật lịch giảng dạy, sinh viên có thể tra cứu thông tin cá nhân, lịch học, điểm số cũng như nhận các thông báo mới nhất từ nhà trường. Phần mềm được xây dựng dựa trên nền tảng Entity Framework Core, hỗ trợ kết nối cơ sở dữ liệu SQL Server, giao diện thân thiện dễ sử dụng, phân quyền rõ ràng giữa admin, giảng viên và sinh viên. Mục tiêu chính là giảm tải công việc quản lý thủ công, tăng tính chính xác của dữ liệu và nâng cao trải nghiệm cho người dùng.", "Phần mềm Quản lý Sinh viên" });

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
                columns: new[] { "MaTB", "AnhURL", "NgayDang", "NoiDung", "TieuDe", "Username" },
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
                    { "GV001", "MH001", new DateOnly(2025, 10, 1), "A101", "1-3" },
                    { "GV001", "MH002", new DateOnly(2025, 10, 2), "A102", "4-6" },
                    { "GV002", "MH003", new DateOnly(2025, 10, 3), "B201", "7-9" },
                    { "GV002", "MH004", new DateOnly(2025, 10, 4), "B202", "1-3" },
                    { "GV004", "MH005", new DateOnly(2025, 10, 5), "C301", "4-6" },
                    { "GV004", "MH006", new DateOnly(2025, 10, 6), "D401", "7-9" },
                    { "GV005", "MH007", new DateOnly(2025, 10, 7), "E501", "1-3" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Diem_MaMH",
                table: "Diem",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_MaKhoa",
                table: "GiangVien",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_LichGiangDay_MaGV",
                table: "LichGiangDay",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MaKhoa",
                table: "LopHoc",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_MaKhoa",
                table: "MonHoc",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_MaLop",
                table: "SinhVien",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_ThongBao_Username",
                table: "ThongBao",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MaGV",
                table: "Users",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MaSV",
                table: "Users",
                column: "MaSV",
                unique: true,
                filter: "[MaSV] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diem");

            migrationBuilder.DropTable(
                name: "LichGiangDay");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "ThongtinPM");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
