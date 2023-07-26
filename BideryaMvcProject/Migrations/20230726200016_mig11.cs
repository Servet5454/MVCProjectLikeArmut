using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hizmetKategoris_TadilatDekorasyons_TadilatDekorasyonId",
                table: "hizmetKategoris");

            migrationBuilder.DropForeignKey(
                name: "FK_hizmetKategoris_Temizliks_TemizlikAnaId",
                table: "hizmetKategoris");

            migrationBuilder.DropForeignKey(
                name: "FK_TadilatDekorasyons_CamBalkons_CamBalkonId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_TadilatDekorasyons_EvTadilats_EvTadilatId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_TadilatDekorasyons_Mantolamas_MantolamaId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_TadilatDekorasyons_MutfakDolabiYapimis_MutfakDolabiYapimiId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_Temizliks_AracYikamas_AracYikamaId",
                table: "Temizliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Temizliks_EvTemizliks_EvTemizlikId",
                table: "Temizliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Temizliks_Ilaclamas_IlaclamaId",
                table: "Temizliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Temizliks_KoltukTemizliks_KoltukTemizlikId",
                table: "Temizliks");

            migrationBuilder.DropIndex(
                name: "IX_TadilatDekorasyons_CamBalkonId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropIndex(
                name: "IX_TadilatDekorasyons_EvTadilatId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropIndex(
                name: "IX_TadilatDekorasyons_MantolamaId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropIndex(
                name: "IX_TadilatDekorasyons_MutfakDolabiYapimiId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hizmetKategoris",
                table: "hizmetKategoris");

            migrationBuilder.DropIndex(
                name: "IX_hizmetKategoris_TadilatDekorasyonId",
                table: "hizmetKategoris");

            migrationBuilder.DropIndex(
                name: "IX_hizmetKategoris_TemizlikAnaId",
                table: "hizmetKategoris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Temizliks",
                table: "Temizliks");

            migrationBuilder.DropColumn(
                name: "CamBalkonId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropColumn(
                name: "EvTadilatId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "TadilatDekorasyons");

            migrationBuilder.DropColumn(
                name: "MantolamaId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropColumn(
                name: "MutfakDolabiYapimiId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropColumn(
                name: "TadilatDekorasyonId",
                table: "hizmetKategoris");

            migrationBuilder.DropColumn(
                name: "TemizlikAnaId",
                table: "hizmetKategoris");

            migrationBuilder.RenameTable(
                name: "hizmetKategoris",
                newName: "HizmetKategoris");

            migrationBuilder.RenameTable(
                name: "Temizliks",
                newName: "TemizlikAnas");

            migrationBuilder.RenameColumn(
                name: "HizmetTuruId",
                table: "TadilatDekorasyons",
                newName: "HizmetKategoriId");

            migrationBuilder.RenameColumn(
                name: "HizmetKategorisi",
                table: "HizmetKategoris",
                newName: "HizmetVerenId");

            migrationBuilder.RenameIndex(
                name: "IX_Temizliks_KoltukTemizlikId",
                table: "TemizlikAnas",
                newName: "IX_TemizlikAnas_KoltukTemizlikId");

            migrationBuilder.RenameIndex(
                name: "IX_Temizliks_IlaclamaId",
                table: "TemizlikAnas",
                newName: "IX_TemizlikAnas_IlaclamaId");

            migrationBuilder.RenameIndex(
                name: "IX_Temizliks_EvTemizlikId",
                table: "TemizlikAnas",
                newName: "IX_TemizlikAnas_EvTemizlikId");

            migrationBuilder.RenameIndex(
                name: "IX_Temizliks_AracYikamaId",
                table: "TemizlikAnas",
                newName: "IX_TemizlikAnas_AracYikamaId");

            migrationBuilder.AddColumn<int>(
                name: "TadilatDekorasyonId",
                table: "MutfakDolabiYapimis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TadilatDekorasyonId",
                table: "Mantolamas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TadilatDekorasyonId",
                table: "EvTadilats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TadilatDekorasyonId",
                table: "CamBalkons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HizmetKategoris",
                table: "HizmetKategoris",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemizlikAnas",
                table: "TemizlikAnas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 0, 16, 139, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 0, 16, 139, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_HizmetKategoriId",
                table: "TadilatDekorasyons",
                column: "HizmetKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_MutfakDolabiYapimis_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantolamas_TadilatDekorasyonId",
                table: "Mantolamas",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_HizmetKategoris_HizmetVerenId",
                table: "HizmetKategoris",
                column: "HizmetVerenId");

            migrationBuilder.CreateIndex(
                name: "IX_EvTadilats_TadilatDekorasyonId",
                table: "EvTadilats",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_CamBalkons_TadilatDekorasyonId",
                table: "CamBalkons",
                column: "TadilatDekorasyonId");

            migrationBuilder.AddForeignKey(
                name: "FK_CamBalkons_TadilatDekorasyons_TadilatDekorasyonId",
                table: "CamBalkons",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvTadilats_TadilatDekorasyons_TadilatDekorasyonId",
                table: "EvTadilats",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HizmetKategoris_HizmetVerens_HizmetVerenId",
                table: "HizmetKategoris",
                column: "HizmetVerenId",
                principalTable: "HizmetVerens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mantolamas_TadilatDekorasyons_TadilatDekorasyonId",
                table: "Mantolamas",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MutfakDolabiYapimis_TadilatDekorasyons_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TadilatDekorasyons_HizmetKategoris_HizmetKategoriId",
                table: "TadilatDekorasyons",
                column: "HizmetKategoriId",
                principalTable: "HizmetKategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemizlikAnas_AracYikamas_AracYikamaId",
                table: "TemizlikAnas",
                column: "AracYikamaId",
                principalTable: "AracYikamas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TemizlikAnas_EvTemizliks_EvTemizlikId",
                table: "TemizlikAnas",
                column: "EvTemizlikId",
                principalTable: "EvTemizliks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TemizlikAnas_Ilaclamas_IlaclamaId",
                table: "TemizlikAnas",
                column: "IlaclamaId",
                principalTable: "Ilaclamas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TemizlikAnas_KoltukTemizliks_KoltukTemizlikId",
                table: "TemizlikAnas",
                column: "KoltukTemizlikId",
                principalTable: "KoltukTemizliks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CamBalkons_TadilatDekorasyons_TadilatDekorasyonId",
                table: "CamBalkons");

            migrationBuilder.DropForeignKey(
                name: "FK_EvTadilats_TadilatDekorasyons_TadilatDekorasyonId",
                table: "EvTadilats");

            migrationBuilder.DropForeignKey(
                name: "FK_HizmetKategoris_HizmetVerens_HizmetVerenId",
                table: "HizmetKategoris");

            migrationBuilder.DropForeignKey(
                name: "FK_Mantolamas_TadilatDekorasyons_TadilatDekorasyonId",
                table: "Mantolamas");

            migrationBuilder.DropForeignKey(
                name: "FK_MutfakDolabiYapimis_TadilatDekorasyons_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropForeignKey(
                name: "FK_TadilatDekorasyons_HizmetKategoris_HizmetKategoriId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_TemizlikAnas_AracYikamas_AracYikamaId",
                table: "TemizlikAnas");

            migrationBuilder.DropForeignKey(
                name: "FK_TemizlikAnas_EvTemizliks_EvTemizlikId",
                table: "TemizlikAnas");

            migrationBuilder.DropForeignKey(
                name: "FK_TemizlikAnas_Ilaclamas_IlaclamaId",
                table: "TemizlikAnas");

            migrationBuilder.DropForeignKey(
                name: "FK_TemizlikAnas_KoltukTemizliks_KoltukTemizlikId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_TadilatDekorasyons_HizmetKategoriId",
                table: "TadilatDekorasyons");

            migrationBuilder.DropIndex(
                name: "IX_MutfakDolabiYapimis_TadilatDekorasyonId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropIndex(
                name: "IX_Mantolamas_TadilatDekorasyonId",
                table: "Mantolamas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HizmetKategoris",
                table: "HizmetKategoris");

            migrationBuilder.DropIndex(
                name: "IX_HizmetKategoris_HizmetVerenId",
                table: "HizmetKategoris");

            migrationBuilder.DropIndex(
                name: "IX_EvTadilats_TadilatDekorasyonId",
                table: "EvTadilats");

            migrationBuilder.DropIndex(
                name: "IX_CamBalkons_TadilatDekorasyonId",
                table: "CamBalkons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemizlikAnas",
                table: "TemizlikAnas");

            migrationBuilder.DropColumn(
                name: "TadilatDekorasyonId",
                table: "MutfakDolabiYapimis");

            migrationBuilder.DropColumn(
                name: "TadilatDekorasyonId",
                table: "Mantolamas");

            migrationBuilder.DropColumn(
                name: "TadilatDekorasyonId",
                table: "EvTadilats");

            migrationBuilder.DropColumn(
                name: "TadilatDekorasyonId",
                table: "CamBalkons");

            migrationBuilder.RenameTable(
                name: "HizmetKategoris",
                newName: "hizmetKategoris");

            migrationBuilder.RenameTable(
                name: "TemizlikAnas",
                newName: "Temizliks");

            migrationBuilder.RenameColumn(
                name: "HizmetKategoriId",
                table: "TadilatDekorasyons",
                newName: "HizmetTuruId");

            migrationBuilder.RenameColumn(
                name: "HizmetVerenId",
                table: "hizmetKategoris",
                newName: "HizmetKategorisi");

            migrationBuilder.RenameIndex(
                name: "IX_TemizlikAnas_KoltukTemizlikId",
                table: "Temizliks",
                newName: "IX_Temizliks_KoltukTemizlikId");

            migrationBuilder.RenameIndex(
                name: "IX_TemizlikAnas_IlaclamaId",
                table: "Temizliks",
                newName: "IX_Temizliks_IlaclamaId");

            migrationBuilder.RenameIndex(
                name: "IX_TemizlikAnas_EvTemizlikId",
                table: "Temizliks",
                newName: "IX_Temizliks_EvTemizlikId");

            migrationBuilder.RenameIndex(
                name: "IX_TemizlikAnas_AracYikamaId",
                table: "Temizliks",
                newName: "IX_Temizliks_AracYikamaId");

            migrationBuilder.AddColumn<int>(
                name: "CamBalkonId",
                table: "TadilatDekorasyons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EvTadilatId",
                table: "TadilatDekorasyons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "TadilatDekorasyons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MantolamaId",
                table: "TadilatDekorasyons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MutfakDolabiYapimiId",
                table: "TadilatDekorasyons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TadilatDekorasyonId",
                table: "hizmetKategoris",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TemizlikAnaId",
                table: "hizmetKategoris",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_hizmetKategoris",
                table: "hizmetKategoris",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Temizliks",
                table: "Temizliks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 22, 42, 34, 704, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 22, 42, 34, 704, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_CamBalkonId",
                table: "TadilatDekorasyons",
                column: "CamBalkonId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_EvTadilatId",
                table: "TadilatDekorasyons",
                column: "EvTadilatId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_MantolamaId",
                table: "TadilatDekorasyons",
                column: "MantolamaId");

            migrationBuilder.CreateIndex(
                name: "IX_TadilatDekorasyons_MutfakDolabiYapimiId",
                table: "TadilatDekorasyons",
                column: "MutfakDolabiYapimiId");

            migrationBuilder.CreateIndex(
                name: "IX_hizmetKategoris_TadilatDekorasyonId",
                table: "hizmetKategoris",
                column: "TadilatDekorasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_hizmetKategoris_TemizlikAnaId",
                table: "hizmetKategoris",
                column: "TemizlikAnaId");

            migrationBuilder.AddForeignKey(
                name: "FK_hizmetKategoris_TadilatDekorasyons_TadilatDekorasyonId",
                table: "hizmetKategoris",
                column: "TadilatDekorasyonId",
                principalTable: "TadilatDekorasyons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_hizmetKategoris_Temizliks_TemizlikAnaId",
                table: "hizmetKategoris",
                column: "TemizlikAnaId",
                principalTable: "Temizliks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TadilatDekorasyons_CamBalkons_CamBalkonId",
                table: "TadilatDekorasyons",
                column: "CamBalkonId",
                principalTable: "CamBalkons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TadilatDekorasyons_EvTadilats_EvTadilatId",
                table: "TadilatDekorasyons",
                column: "EvTadilatId",
                principalTable: "EvTadilats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TadilatDekorasyons_Mantolamas_MantolamaId",
                table: "TadilatDekorasyons",
                column: "MantolamaId",
                principalTable: "Mantolamas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TadilatDekorasyons_MutfakDolabiYapimis_MutfakDolabiYapimiId",
                table: "TadilatDekorasyons",
                column: "MutfakDolabiYapimiId",
                principalTable: "MutfakDolabiYapimis",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Temizliks_AracYikamas_AracYikamaId",
                table: "Temizliks",
                column: "AracYikamaId",
                principalTable: "AracYikamas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Temizliks_EvTemizliks_EvTemizlikId",
                table: "Temizliks",
                column: "EvTemizlikId",
                principalTable: "EvTemizliks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Temizliks_Ilaclamas_IlaclamaId",
                table: "Temizliks",
                column: "IlaclamaId",
                principalTable: "Ilaclamas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Temizliks_KoltukTemizliks_KoltukTemizlikId",
                table: "Temizliks",
                column: "KoltukTemizlikId",
                principalTable: "KoltukTemizliks",
                principalColumn: "Id");
        }
    }
}
