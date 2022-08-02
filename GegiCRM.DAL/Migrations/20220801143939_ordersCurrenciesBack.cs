using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class ordersCurrenciesBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersProductCurrencies");

            migrationBuilder.CreateTable(
                name: "OrdersCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersProductId = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrdersProductId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersCurrencies", x => new { x.Id, x.OrdersProductId, x.CurrencyID });
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_Orders_OrdersProductId",
                        column: x => x.OrdersProductId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_OrdersProducts_OrdersProductId1",
                        column: x => x.OrdersProductId1,
                        principalTable: "OrdersProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "ad936585-2936-46d6-8f81-b3e8a358689a", new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3178), new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "127fd4b5-91cd-4adb-b374-7eecbfb66b48", new DateTime(2022, 8, 1, 17, 39, 36, 804, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 8, 1, 17, 39, 36, 804, DateTimeKind.Local).AddTicks(3056), "AQAAAAEAACcQAAAAEPGkjOjHquQTfLe3VW7MqXaHGnAjRGTMXxRiJhYVbFC5+NIEtTHrM9rYC/h1PZAS2Q==", "92a574ff-0d03-424d-ad0f-259c2cf1628e" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_AddedById",
                table: "OrdersCurrencies",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_CurrencyID",
                table: "OrdersCurrencies",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_ModifiedById",
                table: "OrdersCurrencies",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_OrdersProductId",
                table: "OrdersCurrencies",
                column: "OrdersProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_OrdersProductId1",
                table: "OrdersCurrencies",
                column: "OrdersProductId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersCurrencies");

            migrationBuilder.CreateTable(
                name: "OrdersProductCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersProductId = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersProductCurrencies", x => new { x.Id, x.OrdersProductId, x.CurrencyID });
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId",
                        column: x => x.OrdersProductId,
                        principalTable: "OrdersProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "9ea10187-6ebb-4377-9446-18982f329893", new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5436), new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5448), new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13e9ab1e-166d-4d1d-81c5-e0e6b7f2467b", new DateTime(2022, 8, 1, 16, 22, 21, 175, DateTimeKind.Local).AddTicks(5501), new DateTime(2022, 8, 1, 16, 22, 21, 175, DateTimeKind.Local).AddTicks(5516), "AQAAAAEAACcQAAAAEEDIoagtFCnZRs03RiqTeQhxB21gnyRQQrch7GAtuUOvFgScnjyLlDfQzKeg7bJdLw==", "3e18bde4-91dc-4b58-abca-8105a3967ba4" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 16, 22, 21, 176, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_AddedById",
                table: "OrdersProductCurrencies",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_CurrencyID",
                table: "OrdersProductCurrencies",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_ModifiedById",
                table: "OrdersProductCurrencies",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId",
                table: "OrdersProductCurrencies",
                column: "OrdersProductId");
        }
    }
}
