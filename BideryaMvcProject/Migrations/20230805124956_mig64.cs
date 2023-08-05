using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig64 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsyeriTipi",
                table: "IsyeriTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metrekare",
                table: "IsyeriTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BosEvTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    TeklifSayisi = table.Column<int>(type: "int", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OdaSayisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanyoSayisi = table.Column<int>(type: "int", nullable: false),
                    EvinDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BosEvTemizliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BosEvTemizliks_Ilans_IlanId",
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

            migrationBuilder.CreateIndex(
                name: "IX_BosEvTemizliks_IlanId",
                table: "BosEvTemizliks",
                column: "IlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BosEvTemizliks");

            migrationBuilder.DropColumn(
                name: "IsyeriTipi",
                table: "IsyeriTemizliks");

            migrationBuilder.DropColumn(
                name: "Metrekare",
                table: "IsyeriTemizliks");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 22, 6, 727, DateTimeKind.Local).AddTicks(5660));
        }
    }
}
