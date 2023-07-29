using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig45 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HizmetVerens",
                columns: new[] { "Id", "Ad", "Email", "FirmaIsmi", "HizmetKategoriId", "IsTelNo", "KayitTarihi", "Sehir", "Sifre1", "Sifre2", "SilinmeTarihi", "Soyad", "TelNo", "VergiNo" },
                values: new object[] { 1, "servet", "servet@gmail.com", "BeautyElla", 1, "05455503341", new DateTime(2023, 7, 29, 14, 17, 26, 199, DateTimeKind.Local).AddTicks(933), "ankara", "3A987843C71CDC036B1477D929084804", "3A987843C71CDC036B1477D929084804", null, "zabun", "05455503341", "11111111111" });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 17, 26, 199, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 17, 26, 199, DateTimeKind.Local).AddTicks(551));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 33, 51, 885, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 33, 51, 885, DateTimeKind.Local).AddTicks(6318));
        }
    }
}
