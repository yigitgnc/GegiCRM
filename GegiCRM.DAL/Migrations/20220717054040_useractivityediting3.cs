using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class useractivityediting3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "330bafbc-e6b6-430e-9e40-d8d0c32af98b", new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(94), new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(107), new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "465fa62b-d49b-4483-ac34-422210edfa57", new DateTime(2022, 7, 17, 7, 50, 8, 407, DateTimeKind.Local).AddTicks(9416), new DateTime(2022, 7, 17, 7, 50, 8, 407, DateTimeKind.Local).AddTicks(9428), "AQAAAAEAACcQAAAAEDrn0NPzJySHXD2izLn3rU6EpuDXz2MqAYBnmwB0JgAYvvbS5ZKljIm1XN9fUyXLaA==", "e6300908-9e56-4e8b-8044-06a488111320" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 17, 7, 50, 8, 409, DateTimeKind.Local).AddTicks(334));
        }
    }
}
