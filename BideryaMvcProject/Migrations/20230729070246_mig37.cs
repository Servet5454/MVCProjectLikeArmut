using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig37 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnkaraIlanTemizliks");

            migrationBuilder.DropTable(
                name: "IlanAltKategoris");

            migrationBuilder.DropTable(
                name: "AnkaraHizmetIlanis");

            migrationBuilder.RenameColumn(
                name: "IlanKategori",
                table: "Ilans",
                newName: "IlanKategoriId");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 10, 2, 45, 910, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 10, 2, 45, 910, DateTimeKind.Local).AddTicks(3465));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IlanKategoriId",
                table: "Ilans",
                newName: "IlanKategori");

            migrationBuilder.CreateTable(
                name: "AnkaraHizmetIlanis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetAltKategori = table.Column<int>(type: "int", nullable: false),
                    HizmetBolge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetTuru = table.Column<int>(type: "int", nullable: false),
                    IlanTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeklifSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnkaraHizmetIlanis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IlanAltKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_IlanAltKategoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IlanAltKategoris_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IlanAltKategoris_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnkaraIlanTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnkaraHizmetIlaniId = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiftKisilikYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    HizmetAltKategori = table.Column<int>(type: "int", nullable: false),
                    HizmetBolge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetTuruId = table.Column<int>(type: "int", nullable: false),
                    IkiliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    LKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    MinderSayisi = table.Column<int>(type: "int", nullable: false),
                    SandalyeSayisi = table.Column<int>(type: "int", nullable: false),
                    TekliKoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    TekliYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    UcluKoltukSayisi = table.Column<int>(type: "int", nullable: false)
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
                value: new DateTime(2023, 7, 28, 22, 54, 11, 732, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 28, 22, 54, 11, 732, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.CreateIndex(
                name: "IX_AnkaraIlanTemizliks_AnkaraHizmetIlaniId",
                table: "AnkaraIlanTemizliks",
                column: "AnkaraHizmetIlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_IlanAltKategoris_IlanId",
                table: "IlanAltKategoris",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IlanAltKategoris_KullaniciId",
                table: "IlanAltKategoris",
                column: "KullaniciId");
        }
    }
}
