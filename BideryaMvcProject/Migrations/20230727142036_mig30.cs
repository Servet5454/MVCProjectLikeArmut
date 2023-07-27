using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HizmetAltKategoris_HizmetKategoris_HizmetKategoriId",
                table: "HizmetAltKategoris");

            migrationBuilder.DropIndex(
                name: "IX_HizmetAltKategoris_HizmetKategoriId",
                table: "HizmetAltKategoris");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 17, 20, 36, 598, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 17, 20, 36, 598, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltKategoris_HizmetVerenId",
                table: "HizmetAltKategoris",
                column: "HizmetVerenId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HizmetAltKategoris_HizmetVerens_HizmetVerenId",
                table: "HizmetAltKategoris",
                column: "HizmetVerenId",
                principalTable: "HizmetVerens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HizmetAltKategoris_HizmetVerens_HizmetVerenId",
                table: "HizmetAltKategoris");

            migrationBuilder.DropIndex(
                name: "IX_HizmetAltKategoris_HizmetVerenId",
                table: "HizmetAltKategoris");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 16, 56, 19, 151, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 16, 56, 19, 151, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltKategoris_HizmetKategoriId",
                table: "HizmetAltKategoris",
                column: "HizmetKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_HizmetAltKategoris_HizmetKategoris_HizmetKategoriId",
                table: "HizmetAltKategoris",
                column: "HizmetKategoriId",
                principalTable: "HizmetKategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
