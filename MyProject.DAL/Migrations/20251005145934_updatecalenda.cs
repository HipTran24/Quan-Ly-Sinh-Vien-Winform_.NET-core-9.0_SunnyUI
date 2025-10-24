using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class updatecalenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngay",
                table: "LichGiangDay",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV001", "MH001" },
                column: "Ngay",
                value: new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV001", "MH002" },
                column: "Ngay",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV002", "MH003" },
                column: "Ngay",
                value: new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV002", "MH004" },
                column: "Ngay",
                value: new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV004", "MH005" },
                column: "Ngay",
                value: new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV004", "MH006" },
                column: "Ngay",
                value: new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV005", "MH007" },
                column: "Ngay",
                value: new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "Ngay",
                table: "LichGiangDay",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV001", "MH001" },
                column: "Ngay",
                value: new DateOnly(2025, 10, 1));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV001", "MH002" },
                column: "Ngay",
                value: new DateOnly(2025, 10, 2));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV002", "MH003" },
                column: "Ngay",
                value: new DateOnly(2025, 10, 3));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV002", "MH004" },
                column: "Ngay",
                value: new DateOnly(2025, 10, 4));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV004", "MH005" },
                column: "Ngay",
                value: new DateOnly(2025, 10, 5));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV004", "MH006" },
                column: "Ngay",
                value: new DateOnly(2025, 10, 6));

            migrationBuilder.UpdateData(
                table: "LichGiangDay",
                keyColumns: new[] { "MaGV", "MaMH" },
                keyValues: new object[] { "GV005", "MH007" },
                column: "Ngay",
                value: new DateOnly(2025, 10, 7));
        }
    }
}
