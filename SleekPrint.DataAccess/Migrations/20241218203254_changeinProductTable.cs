using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SleekPrint.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeinProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 12, 18, 21, 32, 53, 427, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 12, 18, 21, 32, 53, 429, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 12, 18, 21, 32, 53, 429, DateTimeKind.Local).AddTicks(9844));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 12, 15, 23, 29, 22, 573, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 12, 15, 23, 29, 22, 575, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 12, 15, 23, 29, 22, 575, DateTimeKind.Local).AddTicks(1208));
        }
    }
}
