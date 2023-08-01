using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig48 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2023, 8, 1, 10, 19, 38, 263, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Ilans",
                keyColumn: "Id",
                keyValue: 1,
                column: "IlanAltKategoriBaslik",
                value: "Ev Temizlik");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 1, 10, 19, 38, 263, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 1, 10, 19, 38, 263, DateTimeKind.Local).AddTicks(6328));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanAltKategoriBaslik",
                table: "Ilans");

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
    }
}
