using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Ilaclamas");

            migrationBuilder.DropTable(
                name: "KoltukTemizliks");

            migrationBuilder.DropTable(
                name: "Mantolamas");

            migrationBuilder.DropTable(
                name: "MutfakDolabiYapimis");

            migrationBuilder.DropTable(
                name: "TadilatDekorasyons");

            migrationBuilder.DropTable(
                name: "Temizliks");

            migrationBuilder.DropColumn(
                name: "HizmetTuru",
                table: "HizmetVerens");

            migrationBuilder.RenameColumn(
                name: "HizmetTuruId",
                table: "HizmetVerens",
                newName: "KategoriId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "HizmetVerens",
                newName: "HizmetTuruId");

            migrationBuilder.AddColumn<string>(
                name: "HizmetTuru",
                table: "HizmetVerens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AracYikamas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigerYerler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoltukSayisi = table.Column<int>(type: "int", nullable: false)
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
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalkonCephe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalkonCevresi = table.Column<int>(type: "int", nullable: false),
                    BalkonYukseklik = table.Column<int>(type: "int", nullable: false),
                    CamBalkonTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CamRengi = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Banyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoyaBadana = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CamBalkon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvinDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FayansDoseme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KapıPencere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MalzemeKalitesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetreKare = table.Column<int>(type: "int", nullable: false),
                    Mutfak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkeLaminant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TadilatIsTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TadilatOdaları = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TadilatTipi = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalkonSayisi = table.Column<int>(type: "int", nullable: false),
                    BanyoSayisi = table.Column<int>(type: "int", nullable: false),
                    CalismaSuresi = table.Column<float>(type: "real", nullable: false),
                    HayvanVarmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdaSayisi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvTemizliks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilaclamas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasereTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MekanTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metrekare = table.Column<int>(type: "int", nullable: false)
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
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiftKisilikYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    IkiliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    LKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    MinderSayisi = table.Column<int>(type: "int", nullable: false),
                    SandalyeSayisi = table.Column<int>(type: "int", nullable: false),
                    TekliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    TekliYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    TeklifSayisi = table.Column<int>(type: "int", nullable: false),
                    UcluKoltukSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoltukTemizliks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mantolamas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalkonTipi = table.Column<int>(type: "int", nullable: false),
                    BinaCepheUzunluk = table.Column<int>(type: "int", nullable: false),
                    BinaKatSayisi = table.Column<int>(type: "int", nullable: false),
                    CepheSayisi = table.Column<int>(type: "int", nullable: false),
                    KisaCepheUzunluk = table.Column<int>(type: "int", nullable: false),
                    MarkaTercih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ozellikler = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MalzemeTercihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplamDolapUzunluk = table.Column<short>(type: "smallint", nullable: false)
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
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanyoSayisi = table.Column<short>(type: "smallint", nullable: true),
                    CalismaSuresi = table.Column<float>(type: "real", nullable: true),
                    EvBosmu = table.Column<bool>(type: "bit", nullable: false),
                    HayvanVarmi = table.Column<bool>(type: "bit", nullable: false),
                    HizmetServis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetVerenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temizliks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 15, 28, 37, 319, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 25, 15, 28, 37, 319, DateTimeKind.Local).AddTicks(3079));
        }
    }
}
