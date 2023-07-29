using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig36 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "IlanAltKategoris",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CiftKisilikYatakSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IkiliKoltukSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LKoltukSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinderSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SandalyeSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TekliKoltukSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TekliYatakSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UcluKoltukSayisi",
                table: "IlanAltKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 28, 22, 54, 11, 732, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 28, 22, 54, 11, 732, DateTimeKind.Local).AddTicks(2614));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "CiftKisilikYatakSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "IkiliKoltukSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "LKoltukSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "MinderSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "SandalyeSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "TekliKoltukSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "TekliYatakSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.DropColumn(
                name: "UcluKoltukSayisi",
                table: "IlanAltKategoris");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 28, 22, 31, 55, 1, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 28, 22, 31, 55, 1, DateTimeKind.Local).AddTicks(1707));
        }
    }
}
