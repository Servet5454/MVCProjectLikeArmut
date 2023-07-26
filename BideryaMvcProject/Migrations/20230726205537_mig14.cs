using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracYikamas_TemizlikAnas_TemizlikAnaId",
                table: "AracYikamas");

            migrationBuilder.DropForeignKey(
                name: "FK_CamBalkons_TadilatDekorasyons_TadilatDekorasyonId",
                table: "CamBalkons");

            migrationBuilder.DropForeignKey(
                name: "FK_EvTadilats_TadilatDekorasyons_TadilatDekorasyonId",
                table: "EvTadilats");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilaclamas_TemizlikAnas_TemizlikAnaId",
                table: "Ilaclamas");

            migrationBuilder.DropForeignKey(
                name: "FK_KoltukTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "KoltukTemizliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Mantolamas_TadilatDekorasyons_TadilatDekorasyonId",
                table: "Mantolamas");

            migrationBuilder.DropForeignKey(
                name: "FK_MutfakDolabiYapimis_TadilatDekorasyons_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropForeignKey(
                name: "FK_TadilatDekorasyons_HizmetKategoris_HizmetKategoriId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_TemizlikAnas_HizmetKategoris_HizmetKategoriId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_TemizlikAnas_HizmetKategoriId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_TadilatDekorasyons_HizmetKategoriId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropIndex(
                name: "IX_MutfakDolabiYapimis_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropIndex(
                name: "IX_Mantolamas_TadilatDekorasyonId",
                table: "Mantolamas");

            migrationBuilder.DropIndex(
                name: "IX_KoltukTemizliks_TemizlikAnaId",
                table: "KoltukTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_Ilaclamas_TemizlikAnaId",
                table: "Ilaclamas");

            migrationBuilder.DropIndex(
                name: "IX_EvTadilats_TadilatDekorasyonId",
                table: "EvTadilats");

            migrationBuilder.DropIndex(
                name: "IX_CamBalkons_TadilatDekorasyonId",
                table: "CamBalkons");

            migrationBuilder.DropIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas");

            migrationBuilder.DropColumn(
                name: "TemizlikAnaId",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "BalkonSayisi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "BanyoSayisi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "CalismaSuresi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "HayvanVarmi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "OdaSayisi",
                table: "EvTemizliks");

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "HizmetKategoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "EvTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "HizmetAltKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetKategoriId = table.Column<int>(type: "int", nullable: false),
                    AracYikama = table.Column<bool>(type: "bit", nullable: false),
                    EvTemizlik = table.Column<bool>(type: "bit", nullable: false),
                    Ilaclama = table.Column<bool>(type: "bit", nullable: false),
                    KoltukTemizlik = table.Column<bool>(type: "bit", nullable: false),
                    CamBalkon = table.Column<bool>(type: "bit", nullable: false),
                    EvTadilat = table.Column<bool>(type: "bit", nullable: false),
                    Mantolama = table.Column<bool>(type: "bit", nullable: false),
                    MutfakDolabiYapimi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetAltKategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HizmetAltKategori_HizmetKategoris_HizmetKategoriId",
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
                value: new DateTime(2023, 7, 26, 23, 55, 37, 581, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 55, 37, 581, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltKategori_HizmetKategoriId",
                table: "HizmetAltKategori",
                column: "HizmetKategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HizmetAltKategori");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "HizmetKategoris");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "EvTemizliks");

            migrationBuilder.AddColumn<int>(
                name: "TemizlikAnaId",
                table: "KoltukTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "EvTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BalkonSayisi",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BanyoSayisi",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "CalismaSuresi",
                table: "EvTemizliks",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "HayvanVarmi",
                table: "EvTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdaSayisi",
                table: "EvTemizliks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 8, 54, 706, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 8, 54, 706, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.CreateIndex(
                name: "IX_TemizlikAnas_HizmetKategoriId",
                table: "TemizlikAnas",
                column: "HizmetKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_HizmetKategoriId",
                table: "TadilatDekorasyons",
                column: "HizmetKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_MutfakDolabiYapimis_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantolamas_TadilatDekorasyonId",
                table: "Mantolamas",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_KoltukTemizliks_TemizlikAnaId",
                table: "KoltukTemizliks",
                column: "TemizlikAnaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilaclamas_TemizlikAnaId",
                table: "Ilaclamas",
                column: "TemizlikAnaId");

            migrationBuilder.CreateIndex(
                name: "IX_EvTadilats_TadilatDekorasyonId",
                table: "EvTadilats",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_CamBalkons_TadilatDekorasyonId",
                table: "CamBalkons",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas",
                column: "TemizlikAnaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AracYikamas_TemizlikAnas_TemizlikAnaId",
                table: "AracYikamas",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CamBalkons_TadilatDekorasyons_TadilatDekorasyonId",
                table: "CamBalkons",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvTadilats_TadilatDekorasyons_TadilatDekorasyonId",
                table: "EvTadilats",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilaclamas_TemizlikAnas_TemizlikAnaId",
                table: "Ilaclamas",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KoltukTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "KoltukTemizliks",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mantolamas_TadilatDekorasyons_TadilatDekorasyonId",
                table: "Mantolamas",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MutfakDolabiYapimis_TadilatDekorasyons_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TadilatDekorasyons_HizmetKategoris_HizmetKategoriId",
                table: "TadilatDekorasyons",
                column: "HizmetKategoriId",
                principalTable: "HizmetKategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemizlikAnas_HizmetKategoris_HizmetKategoriId",
                table: "TemizlikAnas",
                column: "HizmetKategoriId",
                principalTable: "HizmetKategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
