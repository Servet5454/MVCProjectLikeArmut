using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig63 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "YorganYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "YorganYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "YatakYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "YatakYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "StorPerdeYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "StorPerdeYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "KoltukTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "KoltukTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "IsyeriTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "IsyeriTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "InsaatSonrasiTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "InsaatSonrasiTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "Ilaclamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Ilaclamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "HaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "HaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "EvTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "EvTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "EvdeUtus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "EvdeUtus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "EvdeHaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "EvdeHaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "CamTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "CamTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "ApartmanTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "ApartmanTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Il", "Ilce", "YayinlanmaTarihi" },
                values: new object[] { null, null, new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(5660));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Il",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "InsaatSonrasiTemizliks");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "InsaatSonrasiTemizliks");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "HaliYikamas");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "HaliYikamas");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "CamTemizliks");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "CamTemizliks");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "ApartmanTemizliks");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "ApartmanTemizliks");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2447));
        }
    }
}
