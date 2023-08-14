using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig82 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvTadilats_Tadilats_TadilatId",
                table: "EvTadilats");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "EvTadilats",
                newName: "IlanKategoriId");

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "EvTadilats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlanAltKategoriId",
                table: "EvTadilats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IlanBaslik",
                table: "EvTadilats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MalzemeKalitesi",
                table: "BoyaBadanas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kalite",
                table: "BanyoTadilats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DemirKaynaks",
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
                    table.PrimaryKey("PK_DemirKaynaks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DemirKaynaks_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepremTestis",
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
                    table.PrimaryKey("PK_DepremTestis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepremTestis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DogalgazTesisatiVeProjesis",
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
                    table.PrimaryKey("PK_DogalgazTesisatiVeProjesis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogalgazTesisatiVeProjesis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DolapYapimis",
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
                    table.PrimaryKey("PK_DolapYapimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DolapYapimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dusakabins",
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
                    table.PrimaryKey("PK_Dusakabins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dusakabins_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DuvarKagidiIsleris",
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
                    table.PrimaryKey("PK_DuvarKagidiIsleris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuvarKagidiIsleris_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpoksiZeminKaplamas",
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
                    table.PrimaryKey("PK_EpoksiZeminKaplamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EpoksiZeminKaplamas_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvDekorasyons",
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
                    table.PrimaryKey("PK_EvDekorasyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvDekorasyons_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FayansDosemes",
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
                    table.PrimaryKey("PK_FayansDosemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FayansDosemes_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunesEnerjisis",
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
                    table.PrimaryKey("PK_GunesEnerjisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunesEnerjisis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HavuzYapimis",
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
                    table.PrimaryKey("PK_HavuzYapimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HavuzYapimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazirRuloCims",
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
                    table.PrimaryKey("PK_HazirRuloCims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HazirRuloCims_Tadilats_TadilatId",
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
                value: new DateTime(2023, 8, 14, 10, 30, 59, 219, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 10, 30, 59, 219, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 10, 30, 59, 219, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 10, 30, 59, 219, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.CreateIndex(
                name: "IX_DemirKaynaks_TadilatId",
                table: "DemirKaynaks",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_DepremTestis_TadilatId",
                table: "DepremTestis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_DogalgazTesisatiVeProjesis_TadilatId",
                table: "DogalgazTesisatiVeProjesis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_DolapYapimis_TadilatId",
                table: "DolapYapimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_Dusakabins_TadilatId",
                table: "Dusakabins",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_DuvarKagidiIsleris_TadilatId",
                table: "DuvarKagidiIsleris",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_EpoksiZeminKaplamas_TadilatId",
                table: "EpoksiZeminKaplamas",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_EvDekorasyons_TadilatId",
                table: "EvDekorasyons",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_FayansDosemes_TadilatId",
                table: "FayansDosemes",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_GunesEnerjisis_TadilatId",
                table: "GunesEnerjisis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_HavuzYapimis_TadilatId",
                table: "HavuzYapimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_HazirRuloCims_TadilatId",
                table: "HazirRuloCims",
                column: "TadilatId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvTadilats_Tadilats_TadilatId",
                table: "EvTadilats",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvTadilats_Tadilats_TadilatId",
                table: "EvTadilats");

            migrationBuilder.DropTable(
                name: "DemirKaynaks");

            migrationBuilder.DropTable(
                name: "DepremTestis");

            migrationBuilder.DropTable(
                name: "DogalgazTesisatiVeProjesis");

            migrationBuilder.DropTable(
                name: "DolapYapimis");

            migrationBuilder.DropTable(
                name: "Dusakabins");

            migrationBuilder.DropTable(
                name: "DuvarKagidiIsleris");

            migrationBuilder.DropTable(
                name: "EpoksiZeminKaplamas");

            migrationBuilder.DropTable(
                name: "EvDekorasyons");

            migrationBuilder.DropTable(
                name: "FayansDosemes");

            migrationBuilder.DropTable(
                name: "GunesEnerjisis");

            migrationBuilder.DropTable(
                name: "HavuzYapimis");

            migrationBuilder.DropTable(
                name: "HazirRuloCims");

            migrationBuilder.DropColumn(
                name: "IlanAltKategoriId",
                table: "EvTadilats");

            migrationBuilder.DropColumn(
                name: "IlanBaslik",
                table: "EvTadilats");

            migrationBuilder.DropColumn(
                name: "MalzemeKalitesi",
                table: "BoyaBadanas");

            migrationBuilder.DropColumn(
                name: "Kalite",
                table: "BanyoTadilats");

            migrationBuilder.RenameColumn(
                name: "IlanKategoriId",
                table: "EvTadilats",
                newName: "IlanId");

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "EvTadilats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_EvTadilats_Tadilats_TadilatId",
                table: "EvTadilats",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id");
        }
    }
}
