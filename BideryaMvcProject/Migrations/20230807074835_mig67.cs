using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig67 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adet",
                table: "StorPerdeYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kornis",
                table: "StorPerdeYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metrekare",
                table: "StorPerdeYikamas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MermerCilalamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    TeklifSayisi = table.Column<int>(type: "int", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MekanTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metrekare = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MermerCilalamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MermerCilalamas_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MermerCilalamas_IlanId",
                table: "MermerCilalamas",
                column: "IlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MermerCilalamas");

            migrationBuilder.DropColumn(
                name: "Adet",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "Kornis",
                table: "StorPerdeYikamas");

            migrationBuilder.DropColumn(
                name: "Metrekare",
                table: "StorPerdeYikamas");

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
    }
}
