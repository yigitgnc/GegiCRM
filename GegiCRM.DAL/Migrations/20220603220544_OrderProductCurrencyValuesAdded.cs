using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class OrderProductCurrencyValuesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "KesinCurrencyValue",
                table: "OrdersProducts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ReferansCurrencyValue",
                table: "OrdersProducts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "91c66243-eb39-43f5-a677-1b4588cebcea", new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7546), new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7556), new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d18de85c-4eb0-445b-a326-d657f77f5d9f", new DateTime(2022, 6, 4, 1, 5, 42, 737, DateTimeKind.Local).AddTicks(7669), new DateTime(2022, 6, 4, 1, 5, 42, 737, DateTimeKind.Local).AddTicks(7684), "AQAAAAEAACcQAAAAEJFDdu3CmDJcxntqfGWHPP2ULZ01Ltchm4VlCk5CG6fBpNXfx4o1IjDwPRih9FK3MA==", "d044a6ab-803d-48df-be46-a099c75a5106" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 1, 5, 42, 738, DateTimeKind.Local).AddTicks(7748));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KesinCurrencyValue",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "ReferansCurrencyValue",
                table: "OrdersProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "01f6b967-7b8b-40e8-9b45-fa900fc43e46", new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3302), new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ad3528e-2ac8-4158-a38d-32a7fde96587", new DateTime(2022, 6, 4, 0, 13, 32, 347, DateTimeKind.Local).AddTicks(3356), new DateTime(2022, 6, 4, 0, 13, 32, 347, DateTimeKind.Local).AddTicks(3369), "AQAAAAEAACcQAAAAEOIV0oqnM18h2pyjO8DOCdLPYZfvOvH/6vcSg7gOw9mzI7TFqIWyT4djjgQUZDCx6g==", "a4819e91-1ba9-4f4b-92bf-d6557306e4a2" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 0, 13, 32, 348, DateTimeKind.Local).AddTicks(3636));
        }
    }
}
