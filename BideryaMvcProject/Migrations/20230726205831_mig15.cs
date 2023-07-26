using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HizmetAltKategori_HizmetKategoris_HizmetKategoriId",
                table: "HizmetAltKategori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HizmetAltKategori",
                table: "HizmetAltKategori");

            migrationBuilder.RenameTable(
                name: "HizmetAltKategori",
                newName: "HizmetAltKategoris");

            migrationBuilder.RenameIndex(
                name: "IX_HizmetAltKategori_HizmetKategoriId",
                table: "HizmetAltKategoris",
                newName: "IX_HizmetAltKategoris_HizmetKategoriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HizmetAltKategoris",
                table: "HizmetAltKategoris",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_HizmetAltKategoris_HizmetKategoris_HizmetKategoriId",
                table: "HizmetAltKategoris",
                column: "HizmetKategoriId",
                principalTable: "HizmetKategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HizmetAltKategoris_HizmetKategoris_HizmetKategoriId",
                table: "HizmetAltKategoris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HizmetAltKategoris",
                table: "HizmetAltKategoris");

            migrationBuilder.RenameTable(
                name: "HizmetAltKategoris",
                newName: "HizmetAltKategori");

            migrationBuilder.RenameIndex(
                name: "IX_HizmetAltKategoris_HizmetKategoriId",
                table: "HizmetAltKategori",
                newName: "IX_HizmetAltKategori_HizmetKategoriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HizmetAltKategori",
                table: "HizmetAltKategori",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 55, 37, 581, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 55, 37, 581, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AddForeignKey(
                name: "FK_HizmetAltKategori_HizmetKategoris_HizmetKategoriId",
                table: "HizmetAltKategori",
                column: "HizmetKategoriId",
                principalTable: "HizmetKategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
