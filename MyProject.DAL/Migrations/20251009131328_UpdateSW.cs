using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ThongtinPM",
                keyColumn: "MaPM",
                keyValue: 1,
                column: "TenPM",
                value: "Phần mềm Quản Lý Sinh Viên");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ThongtinPM",
                keyColumn: "MaPM",
                keyValue: 1,
                column: "TenPM",
                value: "Phần mềm Quản lý Sinh viên");
        }
    }
}
