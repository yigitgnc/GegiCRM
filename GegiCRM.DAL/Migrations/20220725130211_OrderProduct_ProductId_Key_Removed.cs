using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class OrderProduct_ProductId_Key_Removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OrdersProductId1",
                table: "OrdersProductCurrencies");

            migrationBuilder.DropColumn(
                name: "OrdersProductProductId",
                table: "OrdersProductCurrencies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "28de416b-05b6-4cdf-af17-a0f1dc724208", new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5583), new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71213228-eab5-43c3-9d9a-cdabe615e39a", new DateTime(2022, 7, 25, 16, 2, 8, 637, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 7, 25, 16, 2, 8, 637, DateTimeKind.Local).AddTicks(5652), "AQAAAAEAACcQAAAAEEMWsXoZpNd/9djugHzrUs53jUkRTccSVVqy55qna8cDij2n+bfEGxLpGF8qvmOxHA==", "b9347180-0d68-439c-955c-e825622170c4" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId",
                table: "OrdersProductCurrencies",
                column: "OrdersProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId",
                table: "OrdersProductCurrencies",
                column: "OrdersProductId",
                principalTable: "OrdersProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId",
                table: "OrdersProductCurrencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersProducts",
                table: "OrdersProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId",
                table: "OrdersProductCurrencies");

            migrationBuilder.AddColumn<int>(
                name: "OrdersProductId1",
                table: "OrdersProductCurrencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersProductProductId",
                table: "OrdersProductCurrencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
