using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class OrderProduct_OrderId_Key_Removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId1_OrdersProductOrderId_OrdersProductProductId",
                table: "OrdersProductCurrencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId1_OrdersProductOrderId_OrdersProductProductId",
                table: "OrdersProductCurrencies");

            migrationBuilder.DropColumn(
                name: "OrdersProductOrderId",
                table: "OrdersProductCurrencies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts",
                columns: new[] { "Id", "ProductID" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "fe64882e-6b2f-4dba-b14b-8d5e548d36a9", new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5213), new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5224), new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ba2676e-57af-4503-8171-59b5cd83b974", new DateTime(2022, 7, 25, 14, 44, 14, 198, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 7, 25, 14, 44, 14, 198, DateTimeKind.Local).AddTicks(5359), "AQAAAAEAACcQAAAAEDZD76Pgnn2UL7Dnb9cjkagTgaU7JI8+GkkgMldOvEH/FdZ+Xwb9N0s6OO1jDxfP2g==", "b8126da4-5de3-409a-b186-2bae6e4e3a04" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 14, 44, 14, 199, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId1_OrdersProductProductId",
                table: "OrdersProductCurrencies",
                columns: new[] { "OrdersProductId1", "OrdersProductProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId1_OrdersProductProductId",
                table: "OrdersProductCurrencies",
                columns: new[] { "OrdersProductId1", "OrdersProductProductId" },
                principalTable: "OrdersProducts",
                principalColumns: new[] { "Id", "ProductID" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId1_OrdersProductProductId",
                table: "OrdersProductCurrencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId1_OrdersProductProductId",
                table: "OrdersProductCurrencies");

            migrationBuilder.AddColumn<int>(
                name: "OrdersProductOrderId",
                table: "OrdersProductCurrencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts",
                columns: new[] { "Id", "OrderID", "ProductID" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "88911184-d68f-4016-9fa3-db29091d57a9", new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(813), new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(827), new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75356196-11f8-48a9-86f8-f9585b2d6d67", new DateTime(2022, 7, 19, 15, 15, 31, 735, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 19, 15, 15, 31, 735, DateTimeKind.Local).AddTicks(812), "AQAAAAEAACcQAAAAEIt/OU+iWB2tQC2GFkJRbXYhddgTtrmhZ4Le8BFQjZ3laKVJPisXYa/GjvGNgsxNKQ==", "118ecc06-f22c-45fa-81a3-071f14449906" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId1_OrdersProductOrderId_OrdersProductProductId",
                table: "OrdersProductCurrencies",
                columns: new[] { "OrdersProductId1", "OrdersProductOrderId", "OrdersProductProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId1_OrdersProductOrderId_OrdersProductProductId",
                table: "OrdersProductCurrencies",
                columns: new[] { "OrdersProductId1", "OrdersProductOrderId", "OrdersProductProductId" },
                principalTable: "OrdersProducts",
                principalColumns: new[] { "Id", "OrderID", "ProductID" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
