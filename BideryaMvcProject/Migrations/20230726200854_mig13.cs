using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_TemizlikAnas_EvTemizlikId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_TemizlikAnas_IlaclamaId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_TemizlikAnas_KoltukTemizlikId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas");

            migrationBuilder.DropColumn(
                name: "EvTemizlikId",
                table: "TemizlikAnas");

            migrationBuilder.DropColumn(
                name: "IlaclamaId",
                table: "TemizlikAnas");

            migrationBuilder.DropColumn(
                name: "KoltukTemizlikId",
                table: "TemizlikAnas");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "KoltukTemizliks",
                newName: "TemizlikAnaId");

            migrationBuilder.RenameColumn(
                name: "AltKategoriId",
                table: "Ilaclamas",
                newName: "TemizlikAnaId");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "EvTemizliks",
                newName: "TemizlikAnaId");

            migrationBuilder.AddColumn<int>(
                name: "HizmetKategoriId",
                table: "TemizlikAnas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 8, 54, 706, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 8, 54, 706, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.CreateIndex(
                name: "IX_TemizlikAnas_HizmetKategoriId",
                table: "TemizlikAnas",
                column: "HizmetKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_KoltukTemizliks_TemizlikAnaId",
                table: "KoltukTemizliks",
                column: "TemizlikAnaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilaclamas_TemizlikAnaId",
                table: "Ilaclamas",
                column: "TemizlikAnaId");

            migrationBuilder.CreateIndex(
                name: "IX_EvTemizliks_TemizlikAnaId",
                table: "EvTemizliks",
                column: "TemizlikAnaId");

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas",
                column: "TemizlikAnaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "EvTemizliks",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ilaclamas_TemizlikAnas_TemizlikAnaId",
                table: "Ilaclamas",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KoltukTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "KoltukTemizliks",
                column: "TemizlikAnaId",
                principalTable: "TemizlikAnas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemizlikAnas_HizmetKategoris_HizmetKategoriId",
                table: "TemizlikAnas",
                column: "HizmetKategoriId",
                principalTable: "HizmetKategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "EvTemizliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilaclamas_TemizlikAnas_TemizlikAnaId",
                table: "Ilaclamas");

            migrationBuilder.DropForeignKey(
                name: "FK_KoltukTemizliks_TemizlikAnas_TemizlikAnaId",
                table: "KoltukTemizliks");

            migrationBuilder.DropForeignKey(
                name: "FK_TemizlikAnas_HizmetKategoris_HizmetKategoriId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_TemizlikAnas_HizmetKategoriId",
                table: "TemizlikAnas");

            migrationBuilder.DropIndex(
                name: "IX_KoltukTemizliks_TemizlikAnaId",
                table: "KoltukTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_Ilaclamas_TemizlikAnaId",
                table: "Ilaclamas");

            migrationBuilder.DropIndex(
                name: "IX_EvTemizliks_TemizlikAnaId",
                table: "EvTemizliks");

            migrationBuilder.DropIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas");

            migrationBuilder.DropColumn(
                name: "HizmetKategoriId",
                table: "TemizlikAnas");

            migrationBuilder.RenameColumn(
                name: "TemizlikAnaId",
                table: "KoltukTemizliks",
                newName: "KategoriId");

            migrationBuilder.RenameColumn(
                name: "TemizlikAnaId",
                table: "Ilaclamas",
                newName: "AltKategoriId");

            migrationBuilder.RenameColumn(
                name: "TemizlikAnaId",
                table: "EvTemizliks",
                newName: "KategoriId");

            migrationBuilder.AddColumn<int>(
                name: "EvTemizlikId",
                table: "TemizlikAnas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlaclamaId",
                table: "TemizlikAnas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KoltukTemizlikId",
                table: "TemizlikAnas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 3, 40, 794, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 26, 23, 3, 40, 794, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.CreateIndex(
                name: "IX_TemizlikAnas_EvTemizlikId",
                table: "TemizlikAnas",
                column: "EvTemizlikId");

            migrationBuilder.CreateIndex(
                name: "IX_TemizlikAnas_IlaclamaId",
                table: "TemizlikAnas",
                column: "IlaclamaId");

            migrationBuilder.CreateIndex(
                name: "IX_TemizlikAnas_KoltukTemizlikId",
                table: "TemizlikAnas",
                column: "KoltukTemizlikId");

            migrationBuilder.CreateIndex(
                name: "IX_AracYikamas_TemizlikAnaId",
                table: "AracYikamas",
                column: "TemizlikAnaId",
                unique: true);

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
    }
}
