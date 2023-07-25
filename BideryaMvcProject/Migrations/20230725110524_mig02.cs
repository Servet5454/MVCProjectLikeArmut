using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnkaraHizmetIlanis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetTuru = table.Column<int>(type: "int", nullable: false),
                    HizmetBolge = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnkaraHizmetIlanis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnkaraIlanTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetTuruId = table.Column<int>(type: "int", nullable: false),
                    AnkaraHizmetIlaniId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnkaraIlanTemizliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnkaraIlanTemizliks_AnkaraHizmetIlanis_AnkaraHizmetIlaniId",
                        column: x => x.AnkaraHizmetIlaniId,
                        principalTable: "AnkaraHizmetIlanis",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 14, 5, 24, 524, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 14, 5, 24, 524, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.CreateIndex(
                name: "IX_AnkaraIlanTemizliks_AnkaraHizmetIlaniId",
                table: "AnkaraIlanTemizliks",
                column: "AnkaraHizmetIlaniId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnkaraIlanTemizliks");

            migrationBuilder.DropTable(
                name: "AnkaraHizmetIlanis");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 24, 14, 5, 39, 45, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 24, 14, 5, 39, 45, DateTimeKind.Local).AddTicks(6030));
        }
    }
}
