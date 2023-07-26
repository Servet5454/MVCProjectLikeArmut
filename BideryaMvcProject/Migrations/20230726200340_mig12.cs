using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracYikamas_HizmetVerens_HizmetVerenId",
                table: "AracYikamas");

            migrationBuilder.DropForeignKey(
                name: "FK_TemizlikAnas_AracYikamas_AracYikamaId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_TemizlikAnas_AracYikamaId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_AracYikamas_HizmetVerenId",
                table: "AracYikamas");

            migrationBuilder.DropColumn(
                name: "AracYikamaId",
                table: "TemizlikAnas");

            migrationBuilder.DropColumn(
                name: "HizmetVerenId",
                table: "AracYikamas");

            migrationBuilder.AddColumn<int>(
                name: "TemizlikAnaId",
                table: "AracYikamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 3, 40, 794, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 3, 40, 794, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas",
                column: "TemizlikAnaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AracYikamas_TemizlikAnas_TemizlikAnaId",
                table: "AracYikamas",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracYikamas_TemizlikAnas_TemizlikAnaId",
                table: "AracYikamas");

            migrationBuilder.DropIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas");

            migrationBuilder.DropColumn(
                name: "TemizlikAnaId",
                table: "AracYikamas");

            migrationBuilder.AddColumn<int>(
                name: "AracYikamaId",
                table: "TemizlikAnas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HizmetVerenId",
                table: "AracYikamas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 0, 16, 139, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 0, 16, 139, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.CreateIndex(
                name: "IX_TemizlikAnas_AracYikamaId",
                table: "TemizlikAnas",
                column: "AracYikamaId");

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_HizmetVerenId",
                table: "AracYikamas",
                column: "HizmetVerenId");

            migrationBuilder.AddForeignKey(
                name: "FK_AracYikamas_HizmetVerens_HizmetVerenId",
                table: "AracYikamas",
                column: "HizmetVerenId",
                principalTable: "HizmetVerens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TemizlikAnas_AracYikamas_AracYikamaId",
                table: "TemizlikAnas",
                column: "AracYikamaId",
                principalTable: "AracYikamas",
                principalColumn: "Id");
        }
    }
}
