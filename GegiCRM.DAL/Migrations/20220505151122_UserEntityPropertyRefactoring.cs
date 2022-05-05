using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class UserEntityPropertyRefactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassHash",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AspNetUserRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "6fa58f02-c6a8-489a-89c2-253d058f4208", new DateTime(2022, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7062), new DateTime(2022, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7082), new DateTime(2022, 5, 5, 18, 11, 20, 791, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb4b1675-e4fc-4e52-a5d8-2522f1d63e5a", "AQAAAAEAACcQAAAAEPgMQ8V9VxywScL39aw8BigxT5j4h3JwisAFmqa1CtXxDDeQM5XCMvtO2XdM1ZFe/w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PassHash",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "44be01ad-d52b-4951-af85-97d5aba11890", new DateTime(2022, 5, 5, 14, 20, 24, 571, DateTimeKind.Local).AddTicks(542), new DateTime(2022, 5, 5, 14, 20, 24, 571, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 5, 14, 20, 24, 571, DateTimeKind.Local).AddTicks(571), new DateTime(2022, 5, 5, 14, 20, 24, 571, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PassHash", "PasswordHash" },
                values: new object[] { "5eb1383e-a305-462b-99b9-e4870e701038", "hash1", "AQAAAAEAACcQAAAAEKfGdbCYYnVFF1raH5kmdRgw7TbUfoQD6SmKfcSoBKVuJZS6T2kASbs+xbQJYV/+cg==" });
        }
    }
}
