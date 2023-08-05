using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig62 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsaatSonrasiTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    OdaSayisi = table.Column<int>(type: "int", nullable: false),
                    BanyoSayisi = table.Column<int>(type: "int", nullable: false),
                    Metrekare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvinDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    TeklifSayisi = table.Column<int>(type: "int", nullable: false),
                    YayinlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsaatSonrasiTemizliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsaatSonrasiTemizliks_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 15, 18, 40, 409, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.CreateIndex(
                name: "IX_InsaatSonrasiTemizliks_IlanId",
                table: "InsaatSonrasiTemizliks",
                column: "IlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsaatSonrasiTemizliks");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4162));
        }
    }
}
