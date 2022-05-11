using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class AppUserSeedTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "32969d02-9921-48eb-a72b-78b51a63b45f", true, "ADMINYGT", "YIGIT.GENC.GEGI.COM.TR", "AQAAAAEAACcQAAAAEN2Kx7URYKPkyAY+c918AdmAS4aXJNKLp6tE1cH1A8m5Y+moWamezJEKeOJ0EYj3yQ==", "+905382630008", "c5693665-3cf2-4806-8e72-3d8f34e102bf", "adminYgt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "e53ef25f-b673-42e9-bc6a-4154998e4e48", new DateTime(2022, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "719f4544-78da-49e9-82e7-5d02615af4d0", false, null, null, "AQAAAAEAACcQAAAAEBHFGnPZoTzBvmm33nCLvRd9VE+1hEvL2zvBUFLE5+jp6sfKI/k4LytOfDdt11ToXw==", null, null, null });
        }
    }
}
