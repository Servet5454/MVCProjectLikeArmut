using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig71 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TadilatId",
                table: "MutfakDolabiYapimis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TadilatId",
                table: "Mantolamas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TadilatId",
                table: "EvTadilats",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TadilatId",
                table: "CamBalkons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tadilats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    AltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tadilats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tadilats_Ilans_IlanId",
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
                value: new DateTime(2023, 8, 10, 11, 37, 5, 453, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 11, 37, 5, 453, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 11, 37, 5, 453, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 11, 37, 5, 453, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.CreateIndex(
                name: "IX_MutfakDolabiYapimis_TadilatId",
                table: "MutfakDolabiYapimis",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantolamas_TadilatId",
                table: "Mantolamas",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_EvTadilats_TadilatId",
                table: "EvTadilats",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_CamBalkons_TadilatId",
                table: "CamBalkons",
                column: "TadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_Tadilats_IlanId",
                table: "Tadilats",
                column: "IlanId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CamBalkons_Tadilats_TadilatId",
                table: "CamBalkons",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EvTadilats_Tadilats_TadilatId",
                table: "EvTadilats",
                column: "TadilatId",
                principalTable: "Tadilats",
                principalColumn: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CamBalkons_Tadilats_TadilatId",
                table: "CamBalkons");

            migrationBuilder.DropForeignKey(
                name: "FK_EvTadilats_Tadilats_TadilatId",
                table: "EvTadilats");

            migrationBuilder.DropForeignKey(
                name: "FK_Mantolamas_Tadilats_TadilatId",
                table: "Mantolamas");

            migrationBuilder.DropForeignKey(
                name: "FK_MutfakDolabiYapimis_Tadilats_TadilatId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropTable(
                name: "Tadilats");

            migrationBuilder.DropIndex(
                name: "IX_MutfakDolabiYapimis_TadilatId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropIndex(
                name: "IX_Mantolamas_TadilatId",
                table: "Mantolamas");

            migrationBuilder.DropIndex(
                name: "IX_EvTadilats_TadilatId",
                table: "EvTadilats");

            migrationBuilder.DropIndex(
                name: "IX_CamBalkons_TadilatId",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "TadilatId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropColumn(
                name: "TadilatId",
                table: "Mantolamas");

            migrationBuilder.DropColumn(
                name: "TadilatId",
                table: "EvTadilats");

            migrationBuilder.DropColumn(
                name: "TadilatId",
                table: "CamBalkons");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 8, 10, 25, 41, 729, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 8, 10, 25, 41, 729, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 8, 10, 25, 41, 729, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 8, 10, 25, 41, 729, DateTimeKind.Local).AddTicks(9106));
        }
    }
}
