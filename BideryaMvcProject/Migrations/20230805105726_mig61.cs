using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig61 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HaliYikama_Ilans_IlanId",
                table: "HaliYikama");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HaliYikama",
                table: "HaliYikama");

            migrationBuilder.RenameTable(
                name: "HaliYikama",
                newName: "HaliYikamas");

            migrationBuilder.RenameIndex(
                name: "IX_HaliYikama_IlanId",
                table: "HaliYikamas",
                newName: "IX_HaliYikamas_IlanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HaliYikamas",
                table: "HaliYikamas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 57, 26, 519, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.AddForeignKey(
                name: "FK_HaliYikamas_Ilans_IlanId",
                table: "HaliYikamas",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HaliYikamas_Ilans_IlanId",
                table: "HaliYikamas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HaliYikamas",
                table: "HaliYikamas");

            migrationBuilder.RenameTable(
                name: "HaliYikamas",
                newName: "HaliYikama");

            migrationBuilder.RenameIndex(
                name: "IX_HaliYikamas_IlanId",
                table: "HaliYikama",
                newName: "IX_HaliYikama_IlanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HaliYikama",
                table: "HaliYikama",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YayinlanmaTarihi",
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "HizmetVerens",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 8, 5, 13, 56, 10, 426, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.AddForeignKey(
                name: "FK_HaliYikama_Ilans_IlanId",
                table: "HaliYikama",
                column: "IlanId",
                principalTable: "Ilans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
