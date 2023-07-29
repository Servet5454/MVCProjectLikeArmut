using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig41 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IlanAltKategoriId",
                table: "Ilans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "EvTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BalkonSayisi",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanyoSayisi",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "CalismaSuresi",
                table: "EvTemizliks",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "HayvanVarmi",
                table: "EvTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OdaSayisi",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 19, 38, 613, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 19, 38, 613, DateTimeKind.Local).AddTicks(2942));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanAltKategoriId",
                table: "Ilans");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "BalkonSayisi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "BanyoSayisi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "CalismaSuresi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "HayvanVarmi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "OdaSayisi",
                table: "EvTemizliks");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 10, 33, 27, 319, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 10, 33, 27, 319, DateTimeKind.Local).AddTicks(4276));
        }
    }
}
