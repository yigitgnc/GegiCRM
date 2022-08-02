using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class DefaultCustoemrContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerRepresentetiveUsers_DefaultRepresentetiveUserId1",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "DefaultRepresentetiveUserId1",
                table: "Customers",
                newName: "DefaultCustomerContactId1");

            migrationBuilder.RenameColumn(
                name: "DefaultRepresentetiveUserId",
                table: "Customers",
                newName: "DefaultCustomerContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_DefaultRepresentetiveUserId1",
                table: "Customers",
                newName: "IX_Customers_DefaultCustomerContactId1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerContacts_DefaultCustomerContactId1",
                table: "Customers",
                column: "DefaultCustomerContactId1",
                principalTable: "CustomerContacts",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerContacts_DefaultCustomerContactId1",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "DefaultCustomerContactId1",
                table: "Customers",
                newName: "DefaultRepresentetiveUserId1");

            migrationBuilder.RenameColumn(
                name: "DefaultCustomerContactId",
                table: "Customers",
                newName: "DefaultRepresentetiveUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_DefaultCustomerContactId1",
                table: "Customers",
                newName: "IX_Customers_DefaultRepresentetiveUserId1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "736be1da-6024-4372-982c-a4a515ecb73e", new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(634), new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(660), new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff15d9ab-57fa-46c6-b7d6-5013704b3f09", new DateTime(2022, 8, 1, 15, 26, 50, 869, DateTimeKind.Local).AddTicks(9788), new DateTime(2022, 8, 1, 15, 26, 50, 869, DateTimeKind.Local).AddTicks(9811), "AQAAAAEAACcQAAAAEENU1YTzktOORysk39TNi8oHh+e/SepWHGcNBTgVBEMOY1rGSU3VU1B3uERI37zwrA==", "043dbc84-ed24-4c0c-b349-0d42dbcf3975" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerRepresentetiveUsers_DefaultRepresentetiveUserId1",
                table: "Customers",
                column: "DefaultRepresentetiveUserId1",
                principalTable: "CustomerRepresentetiveUsers",
                principalColumn: "ID");
        }
    }
}
