using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KoltukTemizlik",
                table: "HizmetAltKategoris",
                newName: "KoltukTemizlikIslemi");

            migrationBuilder.RenameColumn(
                name: "Ilaclama",
                table: "HizmetAltKategoris",
                newName: "IlaclamaIslemi");

            migrationBuilder.RenameColumn(
                name: "EvTemizlik",
                table: "HizmetAltKategoris",
                newName: "EvTemizlikIslemi");

            migrationBuilder.RenameColumn(
                name: "AracYikama",
                table: "HizmetAltKategoris",
                newName: "AracYikamaIslemi");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 0, 50, 59, 54, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 0, 50, 59, 54, DateTimeKind.Local).AddTicks(3258));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KoltukTemizlikIslemi",
                table: "HizmetAltKategoris",
                newName: "KoltukTemizlik");

            migrationBuilder.RenameColumn(
                name: "IlaclamaIslemi",
                table: "HizmetAltKategoris",
                newName: "Ilaclama");

            migrationBuilder.RenameColumn(
                name: "EvTemizlikIslemi",
                table: "HizmetAltKategoris",
                newName: "EvTemizlik");

            migrationBuilder.RenameColumn(
                name: "AracYikamaIslemi",
                table: "HizmetAltKategoris",
                newName: "AracYikama");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 58, 31, 712, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 58, 31, 712, DateTimeKind.Local).AddTicks(211));
        }
    }
}
