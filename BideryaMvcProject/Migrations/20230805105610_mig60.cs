using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig60 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HaliYikama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false),
                    TeklifSayisi = table.Column<int>(type: "int", nullable: false),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaliYikama", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HaliYikama_Ilans_IlanId",
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
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.CreateIndex(
                name: "IX_HaliYikama_IlanId",
                table: "HaliYikama",
                column: "IlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HaliYikama");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 40, 0, 176, DateTimeKind.Local).AddTicks(3603));
        }
    }
}
