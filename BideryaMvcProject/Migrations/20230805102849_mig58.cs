using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig58 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "YorganYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "YorganYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "YorganYikamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "YatakYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "YatakYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "YatakYikamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "StorPerdeYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "StorPerdeYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "StorPerdeYikamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "KuruTemizlemes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "KuruTemizlemes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "KoltukTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "IsyeriTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "IsyeriTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "IsyeriTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "Ilaclamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "Ilaclamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "EvTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "EvdeUtus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "EvdeUtus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "EvdeUtus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "EvdeHaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "EvdeHaliYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "EvdeHaliYikamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "CamTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "CamTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "CamTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "ApartmanTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "ApartmanTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeklifSayisi",
                table: "ApartmanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aktifmi", "TeklifSayisi", "YayinlanmaTarihi" },
                values: new object[] { false, 0, new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(4535));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "CamTemizliks");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "CamTemizliks");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "CamTemizliks");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "ApartmanTemizliks");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "ApartmanTemizliks");

            migrationBuilder.DropColumn(
                name: "TeklifSayisi",
                table: "ApartmanTemizliks");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 12, 5, 2, 224, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 12, 5, 2, 224, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 12, 5, 2, 224, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 12, 5, 2, 224, DateTimeKind.Local).AddTicks(7250));
        }
    }
}
