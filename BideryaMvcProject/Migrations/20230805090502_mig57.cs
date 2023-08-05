using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig57 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanAltKategoriBaslik",
                table: "Ilans");

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "YorganYikamas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "YatakYikamas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "StorPerdeYikamas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "KuruTemizlemes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "KoltukTemizliks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "IsyeriTemizliks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "Ilaclamas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "EvTemizliks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "EvdeUtus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "EvdeHaliYikamas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "CamTemizliks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YayinlanmaTarihi",
                table: "ApartmanTemizliks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                table: "Ilans",
                keyColumn: "Id",
                keyValue: 1,
                column: "IlanBaslik",
                value: "Ev Temizlik");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "CamTemizliks");

            migrationBuilder.DropColumn(
                name: "YayinlanmaTarihi",
                table: "ApartmanTemizliks");

            migrationBuilder.AddColumn<string>(
                name: "IlanAltKategoriBaslik",
                table: "Ilans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 11, 55, 39, 10, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Ilans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IlanAltKategoriBaslik", "IlanBaslik" },
                values: new object[] { "Ev Temizlik", null });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 11, 55, 39, 10, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 11, 55, 39, 10, DateTimeKind.Local).AddTicks(2839));
        }
    }
}
