using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HizmetAltKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetVerenId = table.Column<int>(type: "int", nullable: false),
                    HizmetKategoriId = table.Column<int>(type: "int", nullable: false),
                    HizmetVerenName = table.Column<int>(type: "int", nullable: false),
                    AracYikamaIslemi = table.Column<bool>(type: "bit", nullable: false),
                    EvTemizlikIslemi = table.Column<bool>(type: "bit", nullable: false),
                    IlaclamaIslemi = table.Column<bool>(type: "bit", nullable: false),
                    KoltukTemizlikIslemi = table.Column<bool>(type: "bit", nullable: false),
                    CamBalkon = table.Column<bool>(type: "bit", nullable: false),
                    EvTadilat = table.Column<bool>(type: "bit", nullable: false),
                    Mantolama = table.Column<bool>(type: "bit", nullable: false),
                    MutfakDolabiYapimi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetAltKategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HizmetAltKategoris_HizmetVerens_HizmetVerenId",
                        column: x => x.HizmetVerenId,
                        principalTable: "HizmetVerens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 20, 58, 1, 804, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 20, 58, 1, 804, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltKategoris_HizmetVerenId",
                table: "HizmetAltKategoris",
                column: "HizmetVerenId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
