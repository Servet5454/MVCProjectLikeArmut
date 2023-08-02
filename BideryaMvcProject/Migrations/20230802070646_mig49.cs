using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig49 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MutfakDolabiYapimis_IlanId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropIndex(
                name: "IX_Mantolamas_IlanId",
                table: "Mantolamas");

            migrationBuilder.DropIndex(
                name: "IX_KoltukTemizliks_IlanId",
                table: "KoltukTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_Ilaclamas_IlanId",
                table: "Ilaclamas");

            migrationBuilder.DropIndex(
                name: "IX_EvTemizliks_IlanId",
                table: "EvTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_EvTadilats_IlanId",
                table: "EvTadilats");

            migrationBuilder.DropIndex(
                name: "IX_CamBalkons_IlanId",
                table: "CamBalkons");

            migrationBuilder.DropIndex(
                name: "IX_AracYikamas_IlanId",
                table: "AracYikamas");

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 10, 6, 46, 110, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 10, 6, 46, 110, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 2, 10, 6, 46, 110, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.CreateIndex(
                name: "IX_MutfakDolabiYapimis_IlanId",
                table: "MutfakDolabiYapimis",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantolamas_IlanId",
                table: "Mantolamas",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_KoltukTemizliks_IlanId",
                table: "KoltukTemizliks",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilaclamas_IlanId",
                table: "Ilaclamas",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EvTemizliks_IlanId",
                table: "EvTemizliks",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EvTadilats_IlanId",
                table: "EvTadilats",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_CamBalkons_IlanId",
                table: "CamBalkons",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_IlanId",
                table: "AracYikamas",
                column: "IlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MutfakDolabiYapimis_IlanId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropIndex(
                name: "IX_Mantolamas_IlanId",
                table: "Mantolamas");

            migrationBuilder.DropIndex(
                name: "IX_KoltukTemizliks_IlanId",
                table: "KoltukTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_Ilaclamas_IlanId",
                table: "Ilaclamas");

            migrationBuilder.DropIndex(
                name: "IX_EvTemizliks_IlanId",
                table: "EvTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_EvTadilats_IlanId",
                table: "EvTadilats");

            migrationBuilder.DropIndex(
                name: "IX_CamBalkons_IlanId",
                table: "CamBalkons");

            migrationBuilder.DropIndex(
                name: "IX_AracYikamas_IlanId",
                table: "AracYikamas");

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 1, 10, 19, 38, 263, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 1, 10, 19, 38, 263, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 1, 10, 19, 38, 263, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.CreateIndex(
                name: "IX_MutfakDolabiYapimis_IlanId",
                table: "MutfakDolabiYapimis",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mantolamas_IlanId",
                table: "Mantolamas",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KoltukTemizliks_IlanId",
                table: "KoltukTemizliks",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ilaclamas_IlanId",
                table: "Ilaclamas",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EvTemizliks_IlanId",
                table: "EvTemizliks",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EvTadilats_IlanId",
                table: "EvTadilats",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CamBalkons_IlanId",
                table: "CamBalkons",
                column: "IlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_IlanId",
                table: "AracYikamas",
                column: "IlanId",
                unique: true);
        }
    }
}
