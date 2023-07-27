using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HizmetKategoris");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "HizmetVerens",
                newName: "HizmetKategoriId");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 21, 2, 28, 571, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 27, 21, 2, 28, 571, DateTimeKind.Local).AddTicks(7113));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HizmetKategoriId",
                table: "HizmetVerens",
                newName: "KategoriId");

            migrationBuilder.CreateTable(
                name: "HizmetKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetVerenId = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetKategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HizmetKategoris_HizmetVerens_HizmetVerenId",
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
                name: "IX_HizmetKategoris_HizmetVerenId",
                table: "HizmetKategoris",
                column: "HizmetVerenId");
        }
    }
}
