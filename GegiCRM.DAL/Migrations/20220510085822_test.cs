using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22ce6205-bba7-4a34-b536-65cce2fb49ff", "AQAAAAEAACcQAAAAECyfwlmVfHycw+q9jRMAzkuDRAyAIYb12voPMLFW6aNj/W7LON5Tiv/vuNzIeTm2ow==", "5ea9db75-3494-49ea-9ce0-5998196d0282" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "3f6bf77b-dbe3-4a47-9879-b55155e30c48", new DateTime(2022, 5, 10, 11, 0, 1, 143, DateTimeKind.Local).AddTicks(2530), new DateTime(2022, 5, 10, 11, 0, 1, 143, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 10, 11, 0, 1, 143, DateTimeKind.Local).AddTicks(2556), new DateTime(2022, 5, 10, 11, 0, 1, 143, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32969d02-9921-48eb-a72b-78b51a63b45f", "AQAAAAEAACcQAAAAEN2Kx7URYKPkyAY+c918AdmAS4aXJNKLp6tE1cH1A8m5Y+moWamezJEKeOJ0EYj3yQ==", "c5693665-3cf2-4806-8e72-3d8f34e102bf" });
        }
    }
}
