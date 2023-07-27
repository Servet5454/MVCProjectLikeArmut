using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TelNo",
                table: "Kullanicis",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "TelNo" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 48, 52, 917, DateTimeKind.Local).AddTicks(7369), 5555555555L });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KayitTarihi", "TelNo" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 48, 52, 917, DateTimeKind.Local).AddTicks(7373), 5555555555L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "Kullanicis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "TelNo" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 50, 59, 54, DateTimeKind.Local).AddTicks(3256), "5551112233" });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KayitTarihi", "TelNo" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 50, 59, 54, DateTimeKind.Local).AddTicks(3258), "5554445566" });
        }
    }
}
