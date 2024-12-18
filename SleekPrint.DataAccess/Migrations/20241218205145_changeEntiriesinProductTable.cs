using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SleekPrint.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeEntiriesinProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 51, 44, 411, DateTimeKind.Local).AddTicks(6510), "Bil" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 51, 44, 413, DateTimeKind.Local).AddTicks(7596), "Sports & Fritid" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 51, 44, 413, DateTimeKind.Local).AddTicks(7623), "Tøj" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 32, 53, 427, DateTimeKind.Local).AddTicks(6904), "Action" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 32, 53, 429, DateTimeKind.Local).AddTicks(9819), "SciFi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 32, 53, 429, DateTimeKind.Local).AddTicks(9844), "History" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "ISBN" },
                values: new object[] { "Billy Spark", "SWD9999001" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "ISBN" },
                values: new object[] { "Nancy Hoover", "CAW777777701" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ISBN" },
                values: new object[] { "Julian Button", "RITO5555501" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "ISBN" },
                values: new object[] { "Abby Muscles", "WS3333333301" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "ISBN" },
                values: new object[] { "Ron Parker", "SOTJ1111111101" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "ISBN" },
                values: new object[] { "Laura Phantom", "FOT000000001" });
        }
    }
}
