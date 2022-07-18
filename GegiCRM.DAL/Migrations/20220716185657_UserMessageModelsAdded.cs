using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class UserMessageModelsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "0d74524b-1d8f-4add-ad32-1bc9df6af7ac", new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1907), new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1919), new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88a65d4a-bf5e-4a7a-8adc-4f894518a281", new DateTime(2022, 7, 16, 21, 28, 7, 525, DateTimeKind.Local).AddTicks(1774), new DateTime(2022, 7, 16, 21, 28, 7, 525, DateTimeKind.Local).AddTicks(1786), "AQAAAAEAACcQAAAAECiJOguvFYGbLyl1osq44SSW00exX6+Gu8EFsqcuBTGD8ZYcqmM3cRm3KvQSPiuy8w==", "1f72d0f8-0058-4802-a7b3-8fb4f476d71e" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2121));
        }
    }
}
