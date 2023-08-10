using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig80 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CamBalkons_Tadilats_TadilatId",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "BalkonCephe",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "BalkonCevresi",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "BalkonYukseklik",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "CamBalkonTuru",
                table: "CamBalkons");

            migrationBuilder.RenameColumn(
                name: "TadilatDekorasyonId",
                table: "CamBalkons",
                newName: "IlanKategoriId");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "CamBalkons",
                newName: "IlanAltKategoriId");

            migrationBuilder.RenameColumn(
                name: "CamRengi",
                table: "CamBalkons",
                newName: "IlanBaslik");

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "CamBalkons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 10, 18, 6, 42, 380, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 18, 6, 42, 380, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 18, 6, 42, 380, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 18, 6, 42, 380, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.AddForeignKey(
                name: "FK_CamBalkons_Tadilats_TadilatId",
                table: "CamBalkons",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CamBalkons_Tadilats_TadilatId",
                table: "CamBalkons");

            migrationBuilder.RenameColumn(
                name: "IlanKategoriId",
                table: "CamBalkons",
                newName: "TadilatDekorasyonId");

            migrationBuilder.RenameColumn(
                name: "IlanBaslik",
                table: "CamBalkons",
                newName: "CamRengi");

            migrationBuilder.RenameColumn(
                name: "IlanAltKategoriId",
                table: "CamBalkons",
                newName: "IlanId");

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "CamBalkons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BalkonCephe",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BalkonCevresi",
                table: "CamBalkons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BalkonYukseklik",
                table: "CamBalkons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CamBalkonTuru",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 10, 17, 30, 14, 135, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 17, 30, 14, 135, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 17, 30, 14, 135, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 17, 30, 14, 135, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.AddForeignKey(
                name: "FK_CamBalkons_Tadilats_TadilatId",
                table: "CamBalkons",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id");
        }
    }
}
