using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AracYikamas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    DigerYerler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracYikamas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CamBalkons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "HizmetVerens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiNo = table.Column<int>(type: "int", nullable: true),
                    FirmaIsmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetTuruId = table.Column<int>(type: "int", nullable: false),
                    HizmetBolge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetVerens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilaclamas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TekliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    IkiliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    UcluKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    LKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    SandalyeSayisi = table.Column<int>(type: "int", nullable: false),
                    MinderSayisi = table.Column<int>(type: "int", nullable: false),
                    TekliYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    CiftKisilikYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoltukTemizliks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sifre2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mantolamas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "TadilatDekorasyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetTuruId = table.Column<int>(type: "int", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TadilatDekorasyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetVerenId = table.Column<int>(type: "int", nullable: false),
                    HizmetServis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanyoSayisi = table.Column<short>(type: "smallint", nullable: true),
                    CalismaSuresi = table.Column<float>(type: "real", nullable: true),
                    HayvanVarmi = table.Column<bool>(type: "bit", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvBosmu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temizliks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HizmetVerenAdres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetVerenId = table.Column<int>(type: "int", nullable: false),
                    Adresbasligi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresGenel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresTel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetVerenAdres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HizmetVerenAdres_HizmetVerens_HizmetVerenId",
                        column: x => x.HizmetVerenId,
                        principalTable: "HizmetVerens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciAdress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Adresbasligi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresGenel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresTel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciAdress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciAdress_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicis",
                columns: new[] { "Id", "Ad", "Email", "KayitTarihi", "Sifre1", "Sifre2", "Soyad", "TelNo" },
                values: new object[,]
                {
                    { 1, "Ahmet", "ahmet.yilmaz@gmail.com", new DateTime(2023, 7, 24, 14, 5, 39, 45, DateTimeKind.Local).AddTicks(6026), "123456", "123456", "Yılmaz", "5551112233" },
                    { 2, "Ayşe", "ayse.kaya@gmail.com", new DateTime(2023, 7, 24, 14, 5, 39, 45, DateTimeKind.Local).AddTicks(6030), "678900", "678900", "Kaya", "5554445566" }
                });

            migrationBuilder.InsertData(
                table: "KullaniciAdress",
                columns: new[] { "Id", "AdresAd", "AdresGenel", "AdresSoyad", "AdresTel", "Adresbasligi", "Il", "Ilce", "KullaniciId", "Mahalle" },
                values: new object[,]
                {
                    { 1, null, "Yenikent Ankara", null, null, "Ev Adresi", "Ankara", "Sincan", 1, "Yeniken" },
                    { 2, null, "Yenikent Ankara", null, null, "İş Adresi", "Ankara", "Sincan", 1, "Yeniken" },
                    { 3, null, "Yenikent Ankara", null, null, "Dükkan Adresi", "Ankara", "Sincan", 1, "Yeniken" },
                    { 4, null, "Yenikent Ankara", null, null, "Ev Adresi", "Ankara", "Sincan", 2, "Yeniken" },
                    { 5, null, "Yenikent Ankara", null, null, "İş Adresi", "Ankara", "Sincan", 2, "Yeniken" },
                    { 6, null, "Yenikent Ankara", null, null, "Dükkan Adresi", "Ankara", "Sincan", 2, "Yeniken" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HizmetVerenAdres_HizmetVerenId",
                table: "HizmetVerenAdres",
                column: "HizmetVerenId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciAdress_KullaniciId",
                table: "KullaniciAdress",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AracYikamas");

            migrationBuilder.DropTable(
                name: "CamBalkons");

            migrationBuilder.DropTable(
                name: "EvTadilats");

            migrationBuilder.DropTable(
                name: "EvTemizliks");

            migrationBuilder.DropTable(
                name: "HizmetVerenAdres");

            migrationBuilder.DropTable(
                name: "Ilaclamas");

            migrationBuilder.DropTable(
                name: "KoltukTemizliks");

            migrationBuilder.DropTable(
                name: "KullaniciAdress");

            migrationBuilder.DropTable(
                name: "Mantolamas");

            migrationBuilder.DropTable(
                name: "MutfakDolabiYapimis");

            migrationBuilder.DropTable(
                name: "TadilatDekorasyons");

            migrationBuilder.DropTable(
                name: "Temizliks");

            migrationBuilder.DropTable(
                name: "HizmetVerens");

            migrationBuilder.DropTable(
                name: "Kullanicis");
        }
    }
}
