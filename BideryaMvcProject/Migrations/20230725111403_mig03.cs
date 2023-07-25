using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "AnkaraIlanTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CiftKisilikYatakSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IkiliKoltukSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LKoltukSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinderSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SandalyeSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TekliKoltukSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TekliYatakSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UcluKoltukSayisi",
                table: "AnkaraIlanTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 14, 14, 3, 409, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 14, 14, 3, 409, DateTimeKind.Local).AddTicks(5372));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "CiftKisilikYatakSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "IkiliKoltukSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "LKoltukSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "MinderSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "SandalyeSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "TekliKoltukSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "TekliYatakSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.DropColumn(
                name: "UcluKoltukSayisi",
                table: "AnkaraIlanTemizliks");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 14, 5, 24, 524, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 14, 5, 24, 524, DateTimeKind.Local).AddTicks(8771));
        }
    }
}
