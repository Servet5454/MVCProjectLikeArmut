using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig77 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArsaDurumu",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BinaMalzemesi",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Daire",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImarIzni",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kat",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MalzemeKalitesi",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdemeSekli",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjeCizimi",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TabanAlani",
                table: "AnahtarTeslimInsaats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 10, 15, 11, 6, 935, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 15, 11, 6, 935, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 15, 11, 6, 935, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 15, 11, 6, 935, DateTimeKind.Local).AddTicks(2882));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArsaDurumu",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "BinaMalzemesi",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "Daire",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "ImarIzni",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "Kat",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "MalzemeKalitesi",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "OdemeSekli",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "ProjeCizimi",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.DropColumn(
                name: "TabanAlani",
                table: "AnahtarTeslimInsaats");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 10, 14, 56, 43, 325, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 56, 43, 325, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 56, 43, 325, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 56, 43, 325, DateTimeKind.Local).AddTicks(8657));
        }
    }
}
