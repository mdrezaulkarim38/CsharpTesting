using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "584687b9-58c6-4365-bc8a-9cd18d48aa0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c89ed4-97a8-45b0-ad04-814585dad7fd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ad06ee9-078f-4867-ab18-4f7f2ac70fa4", null, "Admin", "ADMIN" },
                    { "e6746fde-9430-431e-9378-2b66754ff02e", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[,]
                {
                    { 1, "Apple Inc.", "Technology", 0.22m, 2300000000000L, 145.32m, "AAPL" },
                    { 2, "Tesla Inc.", "Automotive", 0.00m, 900000000000L, 255.78m, "TSLA" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "StockId", "Title" },
                values: new object[,]
                {
                    { 1, "Apple reported excellent Q3 earnings with a growth in services revenue.", new DateTime(2024, 12, 23, 13, 17, 20, 19, DateTimeKind.Local).AddTicks(712), 1, "Strong Q3 Performance" },
                    { 2, "Tesla unveiled exciting updates to the Model S lineup, boosting investor confidence.", new DateTime(2024, 12, 28, 13, 17, 20, 19, DateTimeKind.Local).AddTicks(1039), 2, "Exciting Model S Updates" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ad06ee9-078f-4867-ab18-4f7f2ac70fa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6746fde-9430-431e-9378-2b66754ff02e");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "584687b9-58c6-4365-bc8a-9cd18d48aa0a", null, "User", "USER" },
                    { "93c89ed4-97a8-45b0-ad04-814585dad7fd", null, "Admin", "ADMIN" }
                });
        }
    }
}
