using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class TypoFix_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDenied",
                table: "OrdersProducts",
                newName: "IsDenied");

            migrationBuilder.RenameColumn(
                name: "IsDenied",
                table: "Orders",
                newName: "IsDenied");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "4546cb24-e1f0-41c3-958c-cea89a9c847e", new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(1881), new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(1918), new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c2a2dda-3fa3-4cff-8605-d405b1be1a9c", new DateTime(2022, 8, 2, 12, 8, 37, 726, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 8, 2, 12, 8, 37, 726, DateTimeKind.Local).AddTicks(1388), "AQAAAAEAACcQAAAAECy6unIxM4FDeecwT7Ozqjk0v+pUIowAIEh7/TOBKkyBtAy/tL3edoqCPNc/JXRqsw==", "0f1745ea-50a9-4a1d-a68d-48c704caa999" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 12, 8, 37, 727, DateTimeKind.Local).AddTicks(2145));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDenied",
                table: "OrdersProducts",
                newName: "IsDenied");

            migrationBuilder.RenameColumn(
                name: "IsDenied",
                table: "Orders",
                newName: "IsDenied");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "ad936585-2936-46d6-8f81-b3e8a358689a", new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3178), new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "127fd4b5-91cd-4adb-b374-7eecbfb66b48", new DateTime(2022, 8, 1, 17, 39, 36, 804, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 8, 1, 17, 39, 36, 804, DateTimeKind.Local).AddTicks(3056), "AQAAAAEAACcQAAAAEPGkjOjHquQTfLe3VW7MqXaHGnAjRGTMXxRiJhYVbFC5+NIEtTHrM9rYC/h1PZAS2Q==", "92a574ff-0d03-424d-ad0f-259c2cf1628e" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 17, 39, 36, 805, DateTimeKind.Local).AddTicks(3524));
        }
    }
}
