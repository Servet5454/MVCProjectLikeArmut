using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HizmetAltKategoris");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 20, 51, 57, 769, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 20, 51, 57, 769, DateTimeKind.Local).AddTicks(1966));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HizmetAltKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetKategoriId = table.Column<int>(type: "int", nullable: false),
                    AracYikamaIslemi = table.Column<bool>(type: "bit", nullable: false),
                    CamBalkon = table.Column<bool>(type: "bit", nullable: false),
                    EvTadilat = table.Column<bool>(type: "bit", nullable: false),
                    EvTemizlikIslemi = table.Column<bool>(type: "bit", nullable: false),
                    IlaclamaIslemi = table.Column<bool>(type: "bit", nullable: false),
                    KoltukTemizlikIslemi = table.Column<bool>(type: "bit", nullable: false),
                    Mantolama = table.Column<bool>(type: "bit", nullable: false),
                    MutfakDolabiYapimi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetAltKategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HizmetAltKategoris_HizmetKategoris_HizmetKategoriId",
                        column: x => x.HizmetKategoriId,
                        principalTable: "HizmetKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 15, 31, 31, 246, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 15, 31, 31, 246, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltKategoris_HizmetKategoriId",
                table: "HizmetAltKategoris",
                column: "HizmetKategoriId");
        }
    }
}
