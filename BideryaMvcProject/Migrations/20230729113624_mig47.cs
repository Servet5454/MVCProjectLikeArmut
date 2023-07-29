using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig47 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IlanAltKategoriId",
                table: "KoltukTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlanAltKategoriId",
                table: "Ilaclamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlanAltKategoriId",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "IlanAltKategoriId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 36, 23, 805, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 36, 23, 805, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 36, 23, 805, DateTimeKind.Local).AddTicks(4230));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanAltKategoriId",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "IlanAltKategoriId",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "IlanAltKategoriId",
                table: "EvTemizliks");

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 35, 15, 341, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 35, 15, 340, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 14, 35, 15, 340, DateTimeKind.Local).AddTicks(9572));
        }
    }
}
