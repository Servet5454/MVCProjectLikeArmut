using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig75 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlciIsleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TadilatId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metrekare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraHizmet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Malzeme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlciIsleris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlciIsleris_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlcipanIsleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TadilatId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metrekare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraHizmet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Malzeme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlcipanIsleris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlcipanIsleris_Tadilats_TadilatId",
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
                value: new DateTime(2023, 8, 10, 14, 47, 59, 17, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 47, 59, 17, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 47, 59, 17, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 47, 59, 17, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.CreateIndex(
                name: "IX_AlciIsleris_TadilatId",
                table: "AlciIsleris",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_AlcipanIsleris_TadilatId",
                table: "AlcipanIsleris",
                column: "TadilatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlciIsleris");

            migrationBuilder.DropTable(
                name: "AlcipanIsleris");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 10, 14, 24, 29, 144, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 24, 29, 144, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 24, 29, 144, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 14, 24, 29, 144, DateTimeKind.Local).AddTicks(4395));
        }
    }
}
