using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b6bbf254-5e0c-4c4a-8ba3-cf8d4ea31b5d", new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(549), new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ac5f532-77bc-4f9f-9441-fd18433c5444", new DateTime(2022, 7, 18, 16, 7, 53, 478, DateTimeKind.Local).AddTicks(750), new DateTime(2022, 7, 18, 16, 7, 53, 478, DateTimeKind.Local).AddTicks(764), "AQAAAAEAACcQAAAAEKkq3DtB+gZCoHQLgKIWI7OjxYYNceOj13eTUNV3rViN/C/qpUlHx73O3BjI4xFyVw==", "b9b5716b-fb38-4c9b-9728-4666a3c57e45" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(856));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "addb2d98-a642-48a5-a53c-17be3b8a563c", new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(8925), new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c12e757c-5608-47ef-b03d-b51c052501f4", new DateTime(2022, 7, 18, 15, 10, 25, 827, DateTimeKind.Local).AddTicks(8162), new DateTime(2022, 7, 18, 15, 10, 25, 827, DateTimeKind.Local).AddTicks(8192), "AQAAAAEAACcQAAAAEBnZ60au+cjqXg7O7U57455nBJzM8JX9ijv5gsoPtL1KRAgEHPwouqysXkU8f04wLQ==", "320759b2-35d9-45a2-ab8e-ccbb200b202e" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 15, 10, 25, 828, DateTimeKind.Local).AddTicks(9255));
        }
    }
}
