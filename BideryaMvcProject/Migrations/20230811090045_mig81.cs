using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig81 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EvinDurumu",
                table: "BoyaBadanas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Malzeme",
                table: "BoyaBadanas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metrekare",
                table: "BoyaBadanas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdaSayisi",
                table: "BoyaBadanas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tavan",
                table: "BoyaBadanas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlokSayisi",
                table: "BinaGuclendirmes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KatSayisi",
                table: "BinaGuclendirmes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TabanAlani",
                table: "BinaGuclendirmes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Malzeme",
                table: "BanyoTadilats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metrekare",
                table: "BanyoTadilats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tur",
                table: "BanyoTadilats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metrekare",
                table: "BalkonFilesis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tur",
                table: "BalkonFilesis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BakimTuru",
                table: "BahceBakimis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HangiSiklik",
                table: "BahceBakimis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metrekare",
                table: "BahceBakimis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sulama",
                table: "BahceBakimis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Malzeme",
                table: "AnahtarTeslimTadilat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metrekare",
                table: "AnahtarTeslimTadilat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tur",
                table: "AnahtarTeslimTadilat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatiTadilatis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TadilatId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatiTadilatis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatiTadilatis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CelikEvYapimis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TadilatId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelikEvYapimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CelikEvYapimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CelikKapis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TadilatId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelikKapis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CelikKapis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 11, 12, 0, 44, 510, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 11, 12, 0, 44, 510, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 11, 12, 0, 44, 510, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 11, 12, 0, 44, 510, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.CreateIndex(
                name: "IX_CatiTadilatis_TadilatId",
                table: "CatiTadilatis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_CelikEvYapimis_TadilatId",
                table: "CelikEvYapimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_CelikKapis_TadilatId",
                table: "CelikKapis",
                column: "TadilatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatiTadilatis");

            migrationBuilder.DropTable(
                name: "CelikEvYapimis");

            migrationBuilder.DropTable(
                name: "CelikKapis");

            migrationBuilder.DropColumn(
                name: "EvinDurumu",
                table: "BoyaBadanas");

            migrationBuilder.DropColumn(
                name: "Malzeme",
                table: "BoyaBadanas");

            migrationBuilder.DropColumn(
                name: "Metrekare",
                table: "BoyaBadanas");

            migrationBuilder.DropColumn(
                name: "OdaSayisi",
                table: "BoyaBadanas");

            migrationBuilder.DropColumn(
                name: "Tavan",
                table: "BoyaBadanas");

            migrationBuilder.DropColumn(
                name: "BlokSayisi",
                table: "BinaGuclendirmes");

            migrationBuilder.DropColumn(
                name: "KatSayisi",
                table: "BinaGuclendirmes");

            migrationBuilder.DropColumn(
                name: "TabanAlani",
                table: "BinaGuclendirmes");

            migrationBuilder.DropColumn(
                name: "Malzeme",
                table: "BanyoTadilats");

            migrationBuilder.DropColumn(
                name: "Metrekare",
                table: "BanyoTadilats");

            migrationBuilder.DropColumn(
                name: "Tur",
                table: "BanyoTadilats");

            migrationBuilder.DropColumn(
                name: "Metrekare",
                table: "BalkonFilesis");

            migrationBuilder.DropColumn(
                name: "Tur",
                table: "BalkonFilesis");

            migrationBuilder.DropColumn(
                name: "BakimTuru",
                table: "BahceBakimis");

            migrationBuilder.DropColumn(
                name: "HangiSiklik",
                table: "BahceBakimis");

            migrationBuilder.DropColumn(
                name: "Metrekare",
                table: "BahceBakimis");

            migrationBuilder.DropColumn(
                name: "Sulama",
                table: "BahceBakimis");

            migrationBuilder.DropColumn(
                name: "Malzeme",
                table: "AnahtarTeslimTadilat");

            migrationBuilder.DropColumn(
                name: "Metrekare",
                table: "AnahtarTeslimTadilat");

            migrationBuilder.DropColumn(
                name: "Tur",
                table: "AnahtarTeslimTadilat");

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
        }
    }
}
