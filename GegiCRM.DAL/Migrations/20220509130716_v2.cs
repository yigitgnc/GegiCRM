using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "e417ef46-9914-433e-9222-9fa7710a1cd4", new DateTime(2022, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3446), new DateTime(2022, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3469), new DateTime(2022, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d4da4ac-e28b-4a1c-84b1-fe8a475ae895", "AQAAAAEAACcQAAAAELkXfFt91b5qk7gsA6XdnTnI6DVKAdr6rE5AWPZd+JuAJ/Yukn2AjKCYTedCeoD3XQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "6fa58f02-c6a8-489a-89c2-253d058f4208", new DateTime(2022, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7062), new DateTime(2022, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7082), new DateTime(2022, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb4b1675-e4fc-4e52-a5d8-2522f1d63e5a", "AQAAAAEAACcQAAAAEPgMQ8V9VxywScL39aw8BigxT5j4h3JwisAFmqa1CtXxDDeQM5XCMvtO2XdM1ZFe/w==" });
        }
    }
}
