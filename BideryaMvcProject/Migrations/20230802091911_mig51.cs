using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig51 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TadilatDekorasyons");

            migrationBuilder.DropTable(
                name: "TemizlikAnas");

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 12, 19, 11, 246, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 12, 19, 11, 246, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 12, 19, 11, 246, DateTimeKind.Local).AddTicks(3825));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TadilatDekorasyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TadilatDekorasyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemizlikAnas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltKategoriId = table.Column<int>(type: "int", nullable: false),
                    BanyoSayisi = table.Column<short>(type: "smallint", nullable: true),
                    CalismaSuresi = table.Column<float>(type: "real", nullable: true),
                    EvBosmu = table.Column<bool>(type: "bit", nullable: false),
                    HayvanVarmi = table.Column<bool>(type: "bit", nullable: false),
                    HizmetKategoriId = table.Column<int>(type: "int", nullable: false),
                    HizmetServis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemizlikAnas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 12, 16, 23, 208, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 12, 16, 23, 208, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 12, 16, 23, 208, DateTimeKind.Local).AddTicks(4792));
        }
    }
}
