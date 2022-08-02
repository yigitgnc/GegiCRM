using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class TeslimAlacakAdSoyadAddedToAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeslimTelefon",
                table: "CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "019fb17f-1d2a-4745-b34b-ffd531fb9e4e", new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1421), new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1431), new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f92ce62a-ddf5-4596-b680-7ff335b5fc66", new DateTime(2022, 8, 2, 17, 32, 6, 9, DateTimeKind.Local).AddTicks(1252), new DateTime(2022, 8, 2, 17, 32, 6, 9, DateTimeKind.Local).AddTicks(1268), "AQAAAAEAACcQAAAAELhENRiiYKfXR/wSVpCv7e0pnSkC1zheyf75L6btn2i1ah9D4wvHJ/SJ48V0PhmI7A==", "3f10e283-aee6-46eb-bc22-9cc18c7515f9" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 17, 32, 6, 10, DateTimeKind.Local).AddTicks(1666));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeslimTelefon",
                table: "CustomerAddresses");

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
    }
}
