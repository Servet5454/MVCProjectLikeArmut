using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdresDetay",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ilans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    IlanKategori = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilans_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IlanAltKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanAltKategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IlanAltKategoris_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IlanAltKategoris_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 28, 22, 31, 55, 1, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 28, 22, 31, 55, 1, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.CreateIndex(
                name: "IX_IlanAltKategoris_IlanId",
                table: "IlanAltKategoris",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IlanAltKategoris_KullaniciId",
                table: "IlanAltKategoris",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilans_KullaniciId",
                table: "Ilans",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IlanAltKategoris");

            migrationBuilder.DropTable(
                name: "Ilans");

            migrationBuilder.DropColumn(
                name: "AdresDetay",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "CamBalkons");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 21, 30, 12, 344, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 21, 30, 12, 344, DateTimeKind.Local).AddTicks(3299));
        }
    }
}
