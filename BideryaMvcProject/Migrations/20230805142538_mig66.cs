using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig66 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LKoltukSayisi",
                table: "KoltukTemizliks");

            migrationBuilder.AddColumn<string>(
                name: "Ceket",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gelinlik",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gomlek",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mont",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pantalon",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yorgan",
                table: "KuruTemizlemes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "InsaatSonrasiTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 17, 25, 38, 244, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 17, 25, 38, 244, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 17, 25, 38, 244, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 17, 25, 38, 244, DateTimeKind.Local).AddTicks(2288));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ceket",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Gelinlik",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Gomlek",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Mont",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Pantalon",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Yorgan",
                table: "KuruTemizlemes");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "InsaatSonrasiTemizliks");

            migrationBuilder.AddColumn<int>(
                name: "LKoltukSayisi",
                table: "KoltukTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 15, 49, 56, 503, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 49, 56, 503, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 49, 56, 503, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 49, 56, 503, DateTimeKind.Local).AddTicks(3519));
        }
    }
}
