using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class useractivityediting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
