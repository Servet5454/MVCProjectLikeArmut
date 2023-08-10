using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig72 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CamBalkons_Ilans_IlanId",
                table: "CamBalkons");

            migrationBuilder.DropForeignKey(
                name: "FK_EvTadilats_Ilans_IlanId",
                table: "EvTadilats");

            migrationBuilder.DropForeignKey(
                name: "FK_Mantolamas_Ilans_IlanId",
                table: "Mantolamas");

            migrationBuilder.DropForeignKey(
                name: "FK_MutfakDolabiYapimis_Ilans_IlanId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropIndex(
                name: "IX_MutfakDolabiYapimis_IlanId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropIndex(
                name: "IX_Mantolamas_IlanId",
                table: "Mantolamas");

            migrationBuilder.DropIndex(
                name: "IX_EvTadilats_IlanId",
                table: "EvTadilats");

            migrationBuilder.DropIndex(
                name: "IX_CamBalkons_IlanId",
                table: "CamBalkons");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 10, 11, 39, 1, 697, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 11, 39, 1, 697, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 11, 39, 1, 697, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 10, 11, 39, 1, 697, DateTimeKind.Local).AddTicks(2421));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_MutfakDolabiYapimis_IlanId",
                table: "MutfakDolabiYapimis",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantolamas_IlanId",
                table: "Mantolamas",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EvTadilats_IlanId",
                table: "EvTadilats",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_CamBalkons_IlanId",
                table: "CamBalkons",
                column: "IlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_CamBalkons_Ilans_IlanId",
                table: "CamBalkons",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvTadilats_Ilans_IlanId",
                table: "EvTadilats",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mantolamas_Ilans_IlanId",
                table: "Mantolamas",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MutfakDolabiYapimis_Ilans_IlanId",
                table: "MutfakDolabiYapimis",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
