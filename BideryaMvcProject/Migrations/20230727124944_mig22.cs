using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 15, 49, 43, 833, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 15, 49, 43, 833, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltKategoris_HizmetVerenId",
                table: "HizmetAltKategoris",
                column: "HizmetVerenId");

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
                value: new DateTime(2023, 7, 27, 15, 37, 7, 372, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 15, 37, 7, 372, DateTimeKind.Local).AddTicks(161));
        }
    }
}
