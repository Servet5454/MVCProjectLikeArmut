using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    /// <inheritdoc />
    public partial class mig43 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EvTemizliks",
                columns: new[] { "Id", "Aciklama", "BalkonSayisi", "BanyoSayisi", "CalismaSuresi", "HayvanVarmi", "IlanId", "OdaSayisi" },
                values: new object[] { 1, "Temizlenecek", 1, 1, 3f, false, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ilans",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdresDetay",
                value: "Ayaş Merkez");

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 28, 16, 336, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 28, 16, 336, DateTimeKind.Local).AddTicks(3547));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvTemizliks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Ilans",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdresDetay",
                value: null);

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 25, 4, 568, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 2,
                column: "KayitTarihi",
                value: new DateTime(2023, 7, 29, 11, 25, 4, 568, DateTimeKind.Local).AddTicks(6802));
        }
    }
}
