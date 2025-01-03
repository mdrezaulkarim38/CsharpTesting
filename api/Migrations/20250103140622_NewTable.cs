using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class NewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ad06ee9-078f-4867-ab18-4f7f2ac70fa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6746fde-9430-431e-9378-2b66754ff02e");

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => new { x.AppUserId, x.StockId });
                    table.ForeignKey(
                        name: "FK_Portfolios_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Portfolios_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40f9b2d7-9a18-4411-bad6-dc8005ac0faa", null, "Admin", "ADMIN" },
                    { "d69993f8-8c0f-427c-836a-2db8a1a85f46", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 12, 24, 20, 6, 21, 595, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 20, 6, 21, 595, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_StockId",
                table: "Portfolios",
                column: "StockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f9b2d7-9a18-4411-bad6-dc8005ac0faa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d69993f8-8c0f-427c-836a-2db8a1a85f46");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ad06ee9-078f-4867-ab18-4f7f2ac70fa4", null, "Admin", "ADMIN" },
                    { "e6746fde-9430-431e-9378-2b66754ff02e", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 12, 23, 13, 17, 20, 19, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 12, 28, 13, 17, 20, 19, DateTimeKind.Local).AddTicks(1039));
        }
    }
}
