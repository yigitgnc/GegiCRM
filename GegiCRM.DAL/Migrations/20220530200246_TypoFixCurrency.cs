using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class TypoFixCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurentValue",
                table: "Currencies",
                newName: "CurrentValue");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "2f04b1a6-3b76-489b-8ea1-52bb2834f841", new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9419), new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "426a6e0d-d62a-427f-a5d8-8caa5dc82078", new DateTime(2022, 5, 30, 23, 2, 44, 545, DateTimeKind.Local).AddTicks(8993), new DateTime(2022, 5, 30, 23, 2, 44, 545, DateTimeKind.Local).AddTicks(9004), "AQAAAAEAACcQAAAAEF3pkihcT2ck+eET2n1aHG65ZIwCzJU2i1MIu72TXXSHaXHiX/w+K+WErcOeZXmmOQ==", "3038dee8-1152-4575-8bac-5cf6c662644a" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 23, 2, 44, 546, DateTimeKind.Local).AddTicks(9617));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentValue",
                table: "Currencies",
                newName: "CurentValue");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "178382e7-304d-4ec9-b4ef-7ef21d18894c", new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6587), new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6605), new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b66efec-ab6c-4896-a37f-d52599b96e6f", new DateTime(2022, 5, 30, 4, 31, 2, 795, DateTimeKind.Local).AddTicks(6681), new DateTime(2022, 5, 30, 4, 31, 2, 795, DateTimeKind.Local).AddTicks(6692), "AQAAAAEAACcQAAAAEPUMcpMXIFI9uCJzZrG7SKw/ITVqw5kPwwaPYzMUG+Xvhw6scDrYl8AVzjH35+XjbQ==", "975a3858-83df-4ae1-8229-410e11151c02" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6819));
        }
    }
}
