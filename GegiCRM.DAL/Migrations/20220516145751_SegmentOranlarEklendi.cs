using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class SegmentOranlarEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StartPrice",
                table: "SegmentOrans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Oran",
                table: "SegmentOrans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "EndPrice",
                table: "SegmentOrans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b6800f5f-81c1-46a5-8669-02147aa629bc", new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6226), new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6238), new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a231329-7598-4875-a4d5-980ac6d1b6a8", new DateTime(2022, 5, 16, 17, 57, 50, 135, DateTimeKind.Local).AddTicks(1737), new DateTime(2022, 5, 16, 17, 57, 50, 135, DateTimeKind.Local).AddTicks(1751), "AQAAAAEAACcQAAAAEIFt9dPS/wmumJmVpjdV0+tCJSsH82H52EIhx3+0nSWv/5HRjWC0rRAF9v0e3uRFDQ==", "904ad62a-190e-48b0-ab96-6aa5bd9140ca" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6422));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StartPrice",
                table: "SegmentOrans",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Oran",
                table: "SegmentOrans",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EndPrice",
                table: "SegmentOrans",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "f16dbb21-a606-4780-bf2d-6ae6fc95351d", new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6055), new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6065), new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d033d734-c639-42da-8793-02fa82281bc1", new DateTime(2022, 5, 16, 16, 29, 40, 461, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 5, 16, 16, 29, 40, 461, DateTimeKind.Local).AddTicks(1195), "AQAAAAEAACcQAAAAEJHTVOp55nfwjMQbrC5Img1xuLwmlLsA79SoLnZp96YzEMPpmkFv3gPv3qHFwO9gSA==", "ac59d013-e23b-4b6e-a7f1-f39968c8db04" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6222));
        }
    }
}
