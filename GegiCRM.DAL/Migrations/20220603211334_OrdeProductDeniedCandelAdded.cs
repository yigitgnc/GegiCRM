using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class OrdeProductDeniedCandelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "OrdersProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledDate",
                table: "OrdersProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeniedDate",
                table: "OrdersProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "OrdersProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "OrdersProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeneied",
                table: "OrdersProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "CancelledDate",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "DeniedDate",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "IsDeneied",
                table: "OrdersProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "12c5e3f1-5e15-436c-9a21-b2bfe626774c", new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6974), new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eb79329-5922-4861-b050-029035d9e6a2", new DateTime(2022, 6, 3, 22, 39, 55, 792, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 6, 3, 22, 39, 55, 792, DateTimeKind.Local).AddTicks(6982), "AQAAAAEAACcQAAAAEBMqQANXXbkgzgqhqVfryxyoKODXxIYOpnoOMwsiLgUtWqxqwQHLUMRd3odUfVf1CA==", "d3d0876f-26ef-4ed3-8f9e-289cdcb6f550" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7303));
        }
    }
}
