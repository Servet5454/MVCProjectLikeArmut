using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AracYikamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltKategoriId = table.Column<int>(type: "int", nullable: false),
                    KoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    DigerYerler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetVerenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracYikamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AracYikamas_HizmetVerens_HizmetVerenId",
                        column: x => x.HizmetVerenId,
                        principalTable: "HizmetVerens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CamBalkons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CamBalkonTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalkonCevresi = table.Column<int>(type: "int", nullable: false),
                    BalkonYukseklik = table.Column<int>(type: "int", nullable: false),
                    BalkonCephe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CamRengi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamBalkons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvTadilats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TadilatTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoyaBadana = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mutfak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Banyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KapıPencere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FayansDoseme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkeLaminant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CamBalkon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetreKare = table.Column<int>(type: "int", nullable: false),
                    TadilatIsTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TadilatOdaları = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvinDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MalzemeKalitesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diger = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvTadilats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    OdaSayisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanyoSayisi = table.Column<int>(type: "int", nullable: false),
                    BalkonSayisi = table.Column<int>(type: "int", nullable: false),
                    CalismaSuresi = table.Column<float>(type: "real", nullable: false),
                    HayvanVarmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvTemizliks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilaclamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltKategoriId = table.Column<int>(type: "int", nullable: false),
                    HasereTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metrekare = table.Column<int>(type: "int", nullable: false),
                    MekanTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilaclamas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KoltukTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    TekliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    IkiliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    UcluKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    LKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    SandalyeSayisi = table.Column<int>(type: "int", nullable: false),
                    MinderSayisi = table.Column<int>(type: "int", nullable: false),
                    TekliYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    CiftKisilikYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    TeklifSayisi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoltukTemizliks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mantolamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinaKatSayisi = table.Column<int>(type: "int", nullable: false),
                    BinaCepheUzunluk = table.Column<int>(type: "int", nullable: false),
                    KisaCepheUzunluk = table.Column<int>(type: "int", nullable: false),
                    CepheSayisi = table.Column<int>(type: "int", nullable: false),
                    Ozellikler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkaTercih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalkonTipi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantolamas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MutfakDolabiYapimis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MalzemeTercihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplamDolapUzunluk = table.Column<short>(type: "smallint", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MutfakDolabiYapimis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltKategoriId = table.Column<int>(type: "int", nullable: false),
                    HizmetServis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanyoSayisi = table.Column<short>(type: "smallint", nullable: true),
                    CalismaSuresi = table.Column<float>(type: "real", nullable: true),
                    HayvanVarmi = table.Column<bool>(type: "bit", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvBosmu = table.Column<bool>(type: "bit", nullable: false),
                    AracYikamaId = table.Column<int>(type: "int", nullable: true),
                    EvTemizlikId = table.Column<int>(type: "int", nullable: true),
                    IlaclamaId = table.Column<int>(type: "int", nullable: true),
                    KoltukTemizlikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temizliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Temizliks_AracYikamas_AracYikamaId",
                        column: x => x.AracYikamaId,
                        principalTable: "AracYikamas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Temizliks_EvTemizliks_EvTemizlikId",
                        column: x => x.EvTemizlikId,
                        principalTable: "EvTemizliks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Temizliks_Ilaclamas_IlaclamaId",
                        column: x => x.IlaclamaId,
                        principalTable: "Ilaclamas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Temizliks_KoltukTemizliks_KoltukTemizlikId",
                        column: x => x.KoltukTemizlikId,
                        principalTable: "KoltukTemizliks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TadilatDekorasyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetTuruId = table.Column<int>(type: "int", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CamBalkonId = table.Column<int>(type: "int", nullable: true),
                    EvTadilatId = table.Column<int>(type: "int", nullable: true),
                    MantolamaId = table.Column<int>(type: "int", nullable: true),
                    MutfakDolabiYapimiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TadilatDekorasyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TadilatDekorasyons_CamBalkons_CamBalkonId",
                        column: x => x.CamBalkonId,
                        principalTable: "CamBalkons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TadilatDekorasyons_EvTadilats_EvTadilatId",
                        column: x => x.EvTadilatId,
                        principalTable: "EvTadilats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TadilatDekorasyons_Mantolamas_MantolamaId",
                        column: x => x.MantolamaId,
                        principalTable: "Mantolamas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TadilatDekorasyons_MutfakDolabiYapimis_MutfakDolabiYapimiId",
                        column: x => x.MutfakDolabiYapimiId,
                        principalTable: "MutfakDolabiYapimis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "hizmetKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetKategorisi = table.Column<int>(type: "int", nullable: false),
                    TemizlikAnaId = table.Column<int>(type: "int", nullable: true),
                    TadilatDekorasyonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hizmetKategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hizmetKategoris_TadilatDekorasyons_TadilatDekorasyonId",
                        column: x => x.TadilatDekorasyonId,
                        principalTable: "TadilatDekorasyons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hizmetKategoris_Temizliks_TemizlikAnaId",
                        column: x => x.TemizlikAnaId,
                        principalTable: "Temizliks",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 22, 42, 34, 704, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 22, 42, 34, 704, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_HizmetVerenId",
                table: "AracYikamas",
                column: "HizmetVerenId");

            migrationBuilder.CreateIndex(
                name: "IX_hizmetKategoris_TadilatDekorasyonId",
                table: "hizmetKategoris",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_hizmetKategoris_TemizlikAnaId",
                table: "hizmetKategoris",
                column: "TemizlikAnaId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_CamBalkonId",
                table: "TadilatDekorasyons",
                column: "CamBalkonId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_EvTadilatId",
                table: "TadilatDekorasyons",
                column: "EvTadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_MantolamaId",
                table: "TadilatDekorasyons",
                column: "MantolamaId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_MutfakDolabiYapimiId",
                table: "TadilatDekorasyons",
                column: "MutfakDolabiYapimiId");

            migrationBuilder.CreateIndex(
                name: "IX_Temizliks_AracYikamaId",
                table: "Temizliks",
                column: "AracYikamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Temizliks_EvTemizlikId",
                table: "Temizliks",
                column: "EvTemizlikId");

            migrationBuilder.CreateIndex(
                name: "IX_Temizliks_IlaclamaId",
                table: "Temizliks",
                column: "IlaclamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Temizliks_KoltukTemizlikId",
                table: "Temizliks",
                column: "KoltukTemizlikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hizmetKategoris");

            migrationBuilder.DropTable(
                name: "TadilatDekorasyons");

            migrationBuilder.DropTable(
                name: "Temizliks");

            migrationBuilder.DropTable(
                name: "CamBalkons");

            migrationBuilder.DropTable(
                name: "EvTadilats");

            migrationBuilder.DropTable(
                name: "Mantolamas");

            migrationBuilder.DropTable(
                name: "MutfakDolabiYapimis");

            migrationBuilder.DropTable(
                name: "AracYikamas");

            migrationBuilder.DropTable(
                name: "EvTemizliks");

            migrationBuilder.DropTable(
                name: "Ilaclamas");

            migrationBuilder.DropTable(
                name: "KoltukTemizliks");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 22, 29, 47, 388, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 22, 29, 47, 388, DateTimeKind.Local).AddTicks(4037));
        }
    }
}
