using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class lastvisitedpageTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastVisitedPageTitle",
                table: "UserActivityLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "3ce7879f-26e5-4947-9a10-adfe86efd4a9", new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4572), new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4585), new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "406097da-46ab-47aa-a743-8dd0994ee635", new DateTime(2022, 7, 17, 10, 43, 47, 376, DateTimeKind.Local).AddTicks(4573), new DateTime(2022, 7, 17, 10, 43, 47, 376, DateTimeKind.Local).AddTicks(4595), "AQAAAAEAACcQAAAAEA3aSjUTDDz/dqYpJvgRVr+EEV+SIYeKCHam7R0kUk/mSZZoIn19nHnmMa04hAymMQ==", "c83a138a-b30b-4875-a0ad-ca2f51b5837a" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 10, 43, 47, 377, DateTimeKind.Local).AddTicks(4822));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastVisitedPageTitle",
                table: "UserActivityLogs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "f58de31a-4f39-4fa8-9158-9c1711a7c102", new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(3801), new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(3813), new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27540d70-e1a8-429d-8a7a-5a95554d9a32", new DateTime(2022, 7, 17, 8, 40, 37, 789, DateTimeKind.Local).AddTicks(3817), new DateTime(2022, 7, 17, 8, 40, 37, 789, DateTimeKind.Local).AddTicks(3831), "AQAAAAEAACcQAAAAELdZFQITUZ4AEYfEMOoc6nWvx3XKnYE5IJFEkXxcSN80uaVivxHUte8kBOjbcqUCWw==", "3e0a0fc1-ac89-4c92-a8bd-eb086a2ea06e" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 8, 40, 37, 790, DateTimeKind.Local).AddTicks(4089));
        }
    }
}
