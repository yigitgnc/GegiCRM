using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class useractivityediting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveMunites",
                table: "UserActivityLogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginDate",
                table: "UserActivityLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogoutDate",
                table: "UserActivityLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TotalActiveTime",
                table: "UserActivityLogs",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "23ed508e-1747-4425-b636-276c2924ee79", new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(7983), new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(7995), new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3ef870-3b17-4c78-adc5-3a5164c9de91", new DateTime(2022, 7, 17, 3, 53, 29, 660, DateTimeKind.Local).AddTicks(8213), new DateTime(2022, 7, 17, 3, 53, 29, 660, DateTimeKind.Local).AddTicks(8227), "AQAAAAEAACcQAAAAENqsWEv+N81f1dYYwBEbVLYw/YhBQk3xG+EcDLP7lHlvUUy/DRAcYUxXrPLx1pbJbg==", "348afc74-d68c-47bd-b316-36c2663e20d8" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 3, 53, 29, 661, DateTimeKind.Local).AddTicks(8212));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "UserActivityLogs");

            migrationBuilder.DropColumn(
                name: "LastLogoutDate",
                table: "UserActivityLogs");

            migrationBuilder.DropColumn(
                name: "TotalActiveTime",
                table: "UserActivityLogs");

            migrationBuilder.AddColumn<int>(
                name: "ActiveMunites",
                table: "UserActivityLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "34daa69f-93a0-4f1f-9226-6fa37498101b", new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5552), new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5585), new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6125633c-3193-4339-9267-2054dcfced15", new DateTime(2022, 7, 16, 21, 56, 55, 119, DateTimeKind.Local).AddTicks(5572), new DateTime(2022, 7, 16, 21, 56, 55, 119, DateTimeKind.Local).AddTicks(5584), "AQAAAAEAACcQAAAAEJkZ51wcmEp2szkRjHxvGebRHWq/UDzhlg+tgCdBIoGAR5Gb7sPnCPB0/WmPANn/Rw==", "f20278ac-92f0-4200-8165-eb6d6e52e75f" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 56, 55, 120, DateTimeKind.Local).AddTicks(5849));
        }
    }
}
