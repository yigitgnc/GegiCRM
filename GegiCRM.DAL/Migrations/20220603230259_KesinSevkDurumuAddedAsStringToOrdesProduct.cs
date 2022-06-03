using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class KesinSevkDurumuAddedAsStringToOrdesProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductStateID",
                table: "OrdersProducts");

            migrationBuilder.AddColumn<string>(
                name: "KesinSevkDurumu",
                table: "OrdersProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "10359aa9-7d61-416d-b23a-622924a9a06e", new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7831), new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7841), new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b642e296-6241-43d3-a4d7-cf103db2aba9", new DateTime(2022, 6, 4, 2, 2, 57, 551, DateTimeKind.Local).AddTicks(7953), new DateTime(2022, 6, 4, 2, 2, 57, 551, DateTimeKind.Local).AddTicks(7965), "AQAAAAEAACcQAAAAEDUtBnCdkObjbYMSmNla0okZ90sGhBjwrJ98qaIaTjuaVOMz5furiY+ez4eAnYQeeQ==", "fb309f57-2dc6-410c-8012-1951dc18f76b" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8063));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KesinSevkDurumu",
                table: "OrdersProducts");

            migrationBuilder.AddColumn<int>(
                name: "ProductStateID",
                table: "OrdersProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
