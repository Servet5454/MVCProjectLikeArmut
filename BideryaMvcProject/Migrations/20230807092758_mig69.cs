using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig69 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adet",
                table: "YorganYikamas",
                newName: "TekKisilikSayisi");

            migrationBuilder.RenameColumn(
                name: "Buyukluk",
                table: "YatakYikamas",
                newName: "TekKisilikSayisi");

            migrationBuilder.RenameColumn(
                name: "Adet",
                table: "YatakYikamas",
                newName: "CiftKisilikSayisi");

            migrationBuilder.AddColumn<string>(
                name: "CiftKisilikSayisi",
                table: "YorganYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LekeVarmi",
                table: "YorganYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HaliMetrekare",
                table: "HaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LekeCikarma",
                table: "HaliYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HaliMetrekare",
                table: "EvdeHaliYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LekeCikarma",
                table: "EvdeHaliYikamas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IlanAltKategoriId", "YayinlanmaTarihi" },
                values: new object[] { 104, new DateTime(2023, 8, 7, 12, 27, 57, 568, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 12, 27, 57, 568, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 12, 27, 57, 568, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 7, 12, 27, 57, 568, DateTimeKind.Local).AddTicks(7717));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CiftKisilikSayisi",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "LekeVarmi",
                table: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "HaliMetrekare",
                table: "HaliYikamas");

            migrationBuilder.DropColumn(
                name: "LekeCikarma",
                table: "HaliYikamas");

            migrationBuilder.DropColumn(
                name: "HaliMetrekare",
                table: "EvdeHaliYikamas");

            migrationBuilder.DropColumn(
                name: "LekeCikarma",
                table: "EvdeHaliYikamas");

            migrationBuilder.RenameColumn(
                name: "TekKisilikSayisi",
                table: "YorganYikamas",
                newName: "Adet");

            migrationBuilder.RenameColumn(
                name: "TekKisilikSayisi",
                table: "YatakYikamas",
                newName: "Buyukluk");

            migrationBuilder.RenameColumn(
                name: "CiftKisilikSayisi",
                table: "YatakYikamas",
                newName: "Adet");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IlanAltKategoriId", "YayinlanmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 8, 7, 11, 23, 0, 379, DateTimeKind.Local).AddTicks(862) });

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
    }
}
