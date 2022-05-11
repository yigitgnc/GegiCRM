using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class seedtest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "46db4753-ca38-4741-a0d9-5acd56a36010", new DateTime(2022, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8872), new DateTime(2022, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "", new DateTime(2022, 5, 10, 18, 16, 34, 885, DateTimeKind.Local).AddTicks(3077), null, new DateTime(2022, 5, 10, 18, 16, 34, 885, DateTimeKind.Local).AddTicks(3093), "Yiğit", "YIGIT.GENC.GEGI.COM.TR", "ADMINYGT", "AQAAAAEAACcQAAAAECEPCJQv58/gxlI1NQ0QvEFT2nCS4ktwWm8GYQN5VDoz69O3LHCxQLF5IXBkw7nvuQ==", "", "Genç", "AdminYigit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "0d1e7bd2-35c3-4f62-b681-6ae2dd3681d0", new DateTime(2022, 5, 10, 11, 58, 20, 980, DateTimeKind.Local).AddTicks(1561), new DateTime(2022, 5, 10, 11, 58, 20, 980, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 10, 11, 58, 20, 980, DateTimeKind.Local).AddTicks(1580), new DateTime(2022, 5, 10, 11, 58, 20, 980, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { "22ce6205-bba7-4a34-b536-65cce2fb49ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Yigit", "ADMINYGT", "YIGIT.GENC.GEGI.COM.TR", "AQAAAAEAACcQAAAAECyfwlmVfHycw+q9jRMAzkuDRAyAIYb12voPMLFW6aNj/W7LON5Tiv/vuNzIeTm2ow==", "5ea9db75-3494-49ea-9ce0-5998196d0282", "Genc", "adminYgt" });
        }
    }
}
