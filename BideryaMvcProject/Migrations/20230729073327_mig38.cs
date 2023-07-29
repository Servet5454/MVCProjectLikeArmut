using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig38 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "EvTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_EvTemizliks_TemizlikAnaId",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "EvTemizliks");

            migrationBuilder.DropColumn(
                name: "AdresDetay",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "CamBalkons");

            migrationBuilder.DropColumn(
                name: "AltKategoriId",
                table: "AracYikamas");

            migrationBuilder.RenameColumn(
                name: "TadilatDekorasyonId",
                table: "MutfakDolabiYapimis",
                newName: "IlanId");

            migrationBuilder.RenameColumn(
                name: "TadilatDekorasyonId",
                table: "Mantolamas",
                newName: "IlanId");

            migrationBuilder.RenameColumn(
                name: "TemizlikAnaId",
                table: "Ilaclamas",
                newName: "IlanId");

            migrationBuilder.RenameColumn(
                name: "TemizlikAnaId",
                table: "EvTemizliks",
                newName: "IlanId");

            migrationBuilder.RenameColumn(
                name: "TadilatDekorasyonId",
                table: "EvTadilats",
                newName: "IlanId");

            migrationBuilder.RenameColumn(
                name: "TemizlikAnaId",
                table: "AracYikamas",
                newName: "IlanId");

            migrationBuilder.AddColumn<int>(
                name: "IlanId",
                table: "KoltukTemizliks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AdresDetay",
                table: "Ilans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "Ilans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Ilans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlanId",
                table: "CamBalkons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 10, 33, 27, 319, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 10, 33, 27, 319, DateTimeKind.Local).AddTicks(4276));

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

            migrationBuilder.AddForeignKey(
                name: "FK_AracYikamas_Ilans_IlanId",
                table: "AracYikamas",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_EvTemizliks_Ilans_IlanId",
                table: "EvTemizliks",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilaclamas_Ilans_IlanId",
                table: "Ilaclamas",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KoltukTemizliks_Ilans_IlanId",
                table: "KoltukTemizliks",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracYikamas_Ilans_IlanId",
                table: "AracYikamas");

            migrationBuilder.DropForeignKey(
                name: "FK_CamBalkons_Ilans_IlanId",
                table: "CamBalkons");

            migrationBuilder.DropForeignKey(
                name: "FK_EvTadilats_Ilans_IlanId",
                table: "EvTadilats");

            migrationBuilder.DropForeignKey(
                name: "FK_EvTemizliks_Ilans_IlanId",
                table: "EvTemizliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilaclamas_Ilans_IlanId",
                table: "Ilaclamas");

            migrationBuilder.DropForeignKey(
                name: "FK_KoltukTemizliks_Ilans_IlanId",
                table: "KoltukTemizliks");

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

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "KoltukTemizliks");

            migrationBuilder.DropColumn(
                name: "AdresDetay",
                table: "Ilans");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "Ilans");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Ilans");

            migrationBuilder.DropColumn(
                name: "IlanId",
                table: "CamBalkons");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "MutfakDolabiYapimis",
                newName: "TadilatDekorasyonId");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "Mantolamas",
                newName: "TadilatDekorasyonId");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "Ilaclamas",
                newName: "TemizlikAnaId");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "EvTemizliks",
                newName: "TemizlikAnaId");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "EvTadilats",
                newName: "TadilatDekorasyonId");

            migrationBuilder.RenameColumn(
                name: "IlanId",
                table: "AracYikamas",
                newName: "TemizlikAnaId");

            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "EvTemizliks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AdresDetay",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "CamBalkons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AltKategoriId",
                table: "AracYikamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_EvTemizliks_TemizlikAnaId",
                table: "EvTemizliks",
                column: "TemizlikAnaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "EvTemizliks",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
