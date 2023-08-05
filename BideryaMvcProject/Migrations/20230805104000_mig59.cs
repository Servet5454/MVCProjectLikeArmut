using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig59 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "YorganYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "YatakYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "StorPerdeYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "KoltukTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "IsyeriTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "Ilaclamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "EvTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "EvdeUtus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nevresim",
                table: "EvdeUtus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParcaSayisi",
                table: "EvdeUtus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "EvdeHaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "CamTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "ApartmanTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IlanBaslik", "YayinlanmaTarihi" },
                values: new object[] { "Ev Temizlik", new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(3603));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "YatakYikamas");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "Nevresim",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "ParcaSayisi",
                table: "EvdeUtus");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "CamTemizliks");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "ApartmanTemizliks");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 28, 49, 40, DateTimeKind.Local).AddTicks(4535));
        }
    }
}
