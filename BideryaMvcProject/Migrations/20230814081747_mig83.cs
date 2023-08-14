using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig83 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mantolamas_Tadilats_TadilatId",
                table: "Mantolamas");

            migrationBuilder.DropForeignKey(
                name: "FK_MutfakDolabiYapimis_Tadilats_TadilatId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropColumn(
                name: "IsTuru",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropColumn(
                name: "ToplamDolapUzunluk",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropColumn(
                name: "BalkonTipi",
                table: "Mantolamas");

            migrationBuilder.DropColumn(
                name: "BinaCepheUzunluk",
                table: "Mantolamas");

            migrationBuilder.DropColumn(
                name: "BinaKatSayisi",
                table: "Mantolamas");

            migrationBuilder.DropColumn(
                name: "CepheSayisi",
                table: "Mantolamas");

            migrationBuilder.DropColumn(
                name: "MarkaTercih",
                table: "Mantolamas");

            migrationBuilder.RenameColumn(
                name: "MalzemeTercihi",
                table: "MutfakDolabiYapimis",
                newName: "IlanBaslik");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "MutfakDolabiYapimis",
                newName: "IlanKategoriId");

            migrationBuilder.RenameColumn(
                name: "Ozellikler",
                table: "Mantolamas",
                newName: "IlanBaslik");

            migrationBuilder.RenameColumn(
                name: "KisaCepheUzunluk",
                table: "Mantolamas",
                newName: "IlanKategoriId");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "Mantolamas",
                newName: "IlanAltKategoriId");

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "MutfakDolabiYapimis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlanAltKategoriId",
                table: "MutfakDolabiYapimis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "Mantolamas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "KabaInsaats",
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
                    table.PrimaryKey("PK_KabaInsaats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KabaInsaats_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KapiPencereSinekligis",
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
                    table.PrimaryKey("PK_KapiPencereSinekligis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KapiPencereSinekligis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KoltukDosemes",
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
                    table.PrimaryKey("PK_KoltukDosemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KoltukDosemes_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaminatParkeDosemes",
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
                    table.PrimaryKey("PK_LaminatParkeDosemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaminatParkeDosemes_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MezarYapimis",
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
                    table.PrimaryKey("PK_MezarYapimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MezarYapimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MimariProjeCizimis",
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
                    table.PrimaryKey("PK_MimariProjeCizimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MimariProjeCizimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MobilyaBoyamas",
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
                    table.PrimaryKey("PK_MobilyaBoyamas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobilyaBoyamas_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MutfakTadilats",
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
                    table.PrimaryKey("PK_MutfakTadilats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MutfakTadilats_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MutfakTezgahis",
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
                    table.PrimaryKey("PK_MutfakTezgahis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MutfakTezgahis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtomatikKepenks",
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
                    table.PrimaryKey("PK_OtomatikKepenks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtomatikKepenks_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OzelMobilyaYapimis",
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
                    table.PrimaryKey("PK_OzelMobilyaYapimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzelMobilyaYapimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Panjurs",
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
                    table.PrimaryKey("PK_Panjurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Panjurs_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkeSistreCilas",
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
                    table.PrimaryKey("PK_ParkeSistreCilas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkeSistreCilas_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkeTasiDosemes",
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
                    table.PrimaryKey("PK_ParkeTasiDosemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkeTasiDosemes_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrefabrikEvYapimis",
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
                    table.PrimaryKey("PK_PrefabrikEvYapimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrefabrikEvYapimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PVCKapiPencereBalkons",
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
                    table.PrimaryKey("PK_PVCKapiPencereBalkons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PVCKapiPencereBalkons_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeramikDosemes",
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
                    table.PrimaryKey("PK_SeramikDosemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeramikDosemes_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SesYalitimis",
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
                    table.PrimaryKey("PK_SesYalitimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SesYalitimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorPerdes",
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
                    table.PrimaryKey("PK_StorPerdes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorPerdes_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupurgelikMontajis",
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
                    table.PrimaryKey("PK_SupurgelikMontajis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupurgelikMontajis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurguluKapis",
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
                    table.PrimaryKey("PK_SurguluKapis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurguluKapis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuYalitimis",
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
                    table.PrimaryKey("PK_SuYalitimis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuYalitimis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelOrguCitis",
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
                    table.PrimaryKey("PK_TelOrguCitis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelOrguCitis_Tadilats_TadilatId",
                        column: x => x.TadilatId,
                        principalTable: "Tadilats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TenteBrandaTadilatVeDekorasyons",
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
                    table.PrimaryKey("PK_TenteBrandaTadilatVeDekorasyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenteBrandaTadilatVeDekorasyons_Tadilats_TadilatId",
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
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 14, 11, 17, 46, 6, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.CreateIndex(
                name: "IX_KabaInsaats_TadilatId",
                table: "KabaInsaats",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_KapiPencereSinekligis_TadilatId",
                table: "KapiPencereSinekligis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_KoltukDosemes_TadilatId",
                table: "KoltukDosemes",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_LaminatParkeDosemes_TadilatId",
                table: "LaminatParkeDosemes",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_MezarYapimis_TadilatId",
                table: "MezarYapimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_MimariProjeCizimis_TadilatId",
                table: "MimariProjeCizimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_MobilyaBoyamas_TadilatId",
                table: "MobilyaBoyamas",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_MutfakTadilats_TadilatId",
                table: "MutfakTadilats",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_MutfakTezgahis_TadilatId",
                table: "MutfakTezgahis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_OtomatikKepenks_TadilatId",
                table: "OtomatikKepenks",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_OzelMobilyaYapimis_TadilatId",
                table: "OzelMobilyaYapimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_Panjurs_TadilatId",
                table: "Panjurs",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkeSistreCilas_TadilatId",
                table: "ParkeSistreCilas",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkeTasiDosemes_TadilatId",
                table: "ParkeTasiDosemes",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_PrefabrikEvYapimis_TadilatId",
                table: "PrefabrikEvYapimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_PVCKapiPencereBalkons_TadilatId",
                table: "PVCKapiPencereBalkons",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_SeramikDosemes_TadilatId",
                table: "SeramikDosemes",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_SesYalitimis_TadilatId",
                table: "SesYalitimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_StorPerdes_TadilatId",
                table: "StorPerdes",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_SupurgelikMontajis_TadilatId",
                table: "SupurgelikMontajis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_SurguluKapis_TadilatId",
                table: "SurguluKapis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_SuYalitimis_TadilatId",
                table: "SuYalitimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_TelOrguCitis_TadilatId",
                table: "TelOrguCitis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_TenteBrandaTadilatVeDekorasyons_TadilatId",
                table: "TenteBrandaTadilatVeDekorasyons",
                column: "TadilatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mantolamas_Tadilats_TadilatId",
                table: "Mantolamas",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MutfakDolabiYapimis_Tadilats_TadilatId",
                table: "MutfakDolabiYapimis",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mantolamas_Tadilats_TadilatId",
                table: "Mantolamas");

            migrationBuilder.DropForeignKey(
                name: "FK_MutfakDolabiYapimis_Tadilats_TadilatId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropTable(
                name: "KabaInsaats");

            migrationBuilder.DropTable(
                name: "KapiPencereSinekligis");

            migrationBuilder.DropTable(
                name: "KoltukDosemes");

            migrationBuilder.DropTable(
                name: "LaminatParkeDosemes");

            migrationBuilder.DropTable(
                name: "MezarYapimis");

            migrationBuilder.DropTable(
                name: "MimariProjeCizimis");

            migrationBuilder.DropTable(
                name: "MobilyaBoyamas");

            migrationBuilder.DropTable(
                name: "MutfakTadilats");

            migrationBuilder.DropTable(
                name: "MutfakTezgahis");

            migrationBuilder.DropTable(
                name: "OtomatikKepenks");

            migrationBuilder.DropTable(
                name: "OzelMobilyaYapimis");

            migrationBuilder.DropTable(
                name: "Panjurs");

            migrationBuilder.DropTable(
                name: "ParkeSistreCilas");

            migrationBuilder.DropTable(
                name: "ParkeTasiDosemes");

            migrationBuilder.DropTable(
                name: "PrefabrikEvYapimis");

            migrationBuilder.DropTable(
                name: "PVCKapiPencereBalkons");

            migrationBuilder.DropTable(
                name: "SeramikDosemes");

            migrationBuilder.DropTable(
                name: "SesYalitimis");

            migrationBuilder.DropTable(
                name: "StorPerdes");

            migrationBuilder.DropTable(
                name: "SupurgelikMontajis");

            migrationBuilder.DropTable(
                name: "SurguluKapis");

            migrationBuilder.DropTable(
                name: "SuYalitimis");

            migrationBuilder.DropTable(
                name: "TelOrguCitis");

            migrationBuilder.DropTable(
                name: "TenteBrandaTadilatVeDekorasyons");

            migrationBuilder.DropColumn(
                name: "IlanAltKategoriId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.RenameColumn(
                name: "IlanKategoriId",
                table: "MutfakDolabiYapimis",
                newName: "IlanId");

            migrationBuilder.RenameColumn(
                name: "IlanBaslik",
                table: "MutfakDolabiYapimis",
                newName: "MalzemeTercihi");

            migrationBuilder.RenameColumn(
                name: "IlanKategoriId",
                table: "Mantolamas",
                newName: "KisaCepheUzunluk");

            migrationBuilder.RenameColumn(
                name: "IlanBaslik",
                table: "Mantolamas",
                newName: "Ozellikler");

            migrationBuilder.RenameColumn(
                name: "IlanAltKategoriId",
                table: "Mantolamas",
                newName: "IlanId");

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "MutfakDolabiYapimis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IsTuru",
                table: "MutfakDolabiYapimis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "ToplamDolapUzunluk",
                table: "MutfakDolabiYapimis",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<int>(
                name: "TadilatId",
                table: "Mantolamas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BalkonTipi",
                table: "Mantolamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BinaCepheUzunluk",
                table: "Mantolamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BinaKatSayisi",
                table: "Mantolamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CepheSayisi",
                table: "Mantolamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MarkaTercih",
                table: "Mantolamas",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Mantolamas_Tadilats_TadilatId",
                table: "Mantolamas",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MutfakDolabiYapimis_Tadilats_TadilatId",
                table: "MutfakDolabiYapimis",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id");
        }
    }
}
