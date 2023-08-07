using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig68 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adet",
                table: "YorganYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adet",
                table: "YatakYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Buyukluk",
                table: "YatakYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LekeVarmi",
                table: "YatakYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 7, 11, 23, 0, 379, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 11, 23, 0, 379, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 11, 23, 0, 379, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 11, 23, 0, 379, DateTimeKind.Local).AddTicks(330));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adet",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "Adet",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "Buyukluk",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "LekeVarmi",
                table: "YatakYikamas");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 7, 10, 48, 34, 741, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 10, 48, 34, 741, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 10, 48, 34, 741, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 10, 48, 34, 741, DateTimeKind.Local).AddTicks(4241));
        }
    }
}
