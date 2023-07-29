using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "Sifre1", "Sifre2" },
                values: new object[] { new DateTime(2023, 7, 29, 11, 33, 51, 885, DateTimeKind.Local).AddTicks(6313), "3A987843C71CDC036B1477D929084804", "3A987843C71CDC036B1477D929084804" });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "KayitTarihi", "Sifre1", "Sifre2" },
                values: new object[] { "ayse@gmail.com", new DateTime(2023, 7, 29, 11, 33, 51, 885, DateTimeKind.Local).AddTicks(6318), "3A987843C71CDC036B1477D929084804", "3A987843C71CDC036B1477D929084804" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "Sifre1", "Sifre2" },
                values: new object[] { new DateTime(2023, 7, 29, 11, 28, 16, 336, DateTimeKind.Local).AddTicks(3543), "123456", "123456" });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "KayitTarihi", "Sifre1", "Sifre2" },
                values: new object[] { "ayse.kaya@gmail.com", new DateTime(2023, 7, 29, 11, 28, 16, 336, DateTimeKind.Local).AddTicks(3547), "678900", "678900" });
        }
    }
}
