using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig55 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AracYikamas");

            migrationBuilder.AddColumn<int>(
                name: "IlanKategoriId",
                table: "KoltukTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlanKategoriId",
                table: "Ilaclamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlanKategoriId",
                table: "EvTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ApartmanTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    DaireSayisi = table.Column<int>(type: "int", nullable: false),
                    CopToplama = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmanTemizliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApartmanTemizliks_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CamTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false),
                    EvBuyukluk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balkon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CamTemizliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CamTemizliks_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvdeHaliYikamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvdeHaliYikamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvdeHaliYikamas_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvdeUtus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvdeUtus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvdeUtus_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsyeriTemizliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsyeriTemizliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsyeriTemizliks_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KuruTemizlemes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KuruTemizlemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KuruTemizlemes_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorPerdeYikamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorPerdeYikamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorPerdeYikamas_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YatakYikamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YatakYikamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YatakYikamas_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YorganYikamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanKategoriId = table.Column<int>(type: "int", nullable: false),
                    IlanAltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YorganYikamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YorganYikamas_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "IlanKategoriId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 11, 39, 10, 642, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 11, 39, 10, 641, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 11, 39, 10, 641, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.CreateIndex(
                name: "IX_ApartmanTemizliks_IlanId",
                table: "ApartmanTemizliks",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_CamTemizliks_IlanId",
                table: "CamTemizliks",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EvdeHaliYikamas_IlanId",
                table: "EvdeHaliYikamas",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EvdeUtus_IlanId",
                table: "EvdeUtus",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsyeriTemizliks_IlanId",
                table: "IsyeriTemizliks",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_KuruTemizlemes_IlanId",
                table: "KuruTemizlemes",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_StorPerdeYikamas_IlanId",
                table: "StorPerdeYikamas",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_YatakYikamas_IlanId",
                table: "YatakYikamas",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_YorganYikamas_IlanId",
                table: "YorganYikamas",
                column: "IlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmanTemizliks");

            migrationBuilder.DropTable(
                name: "CamTemizliks");

            migrationBuilder.DropTable(
                name: "EvdeHaliYikamas");

            migrationBuilder.DropTable(
                name: "EvdeUtus");

            migrationBuilder.DropTable(
                name: "IsyeriTemizliks");

            migrationBuilder.DropTable(
                name: "KuruTemizlemes");

            migrationBuilder.DropTable(
                name: "StorPerdeYikamas");

            migrationBuilder.DropTable(
                name: "YatakYikamas");

            migrationBuilder.DropTable(
                name: "YorganYikamas");

            migrationBuilder.DropColumn(
                name: "IlanKategoriId",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "IlanKategoriId",
                table: "Ilaclamas");

            migrationBuilder.DropColumn(
                name: "IlanKategoriId",
                table: "EvTemizliks");

            migrationBuilder.CreateTable(
                name: "AracYikamas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigerYerler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoltukSayisi = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracYikamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AracYikamas_Ilans_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 3, 10, 9, 6, 660, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 3, 10, 9, 6, 660, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 3, 10, 9, 6, 660, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_IlanId",
                table: "AracYikamas",
                column: "IlanId");
        }
    }
}
