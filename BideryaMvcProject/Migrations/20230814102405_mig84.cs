using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig84 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 14, 13, 24, 4, 918, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 13, 24, 4, 918, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 13, 24, 4, 918, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 13, 24, 4, 918, DateTimeKind.Local).AddTicks(967));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(154));
        }
    }
}
