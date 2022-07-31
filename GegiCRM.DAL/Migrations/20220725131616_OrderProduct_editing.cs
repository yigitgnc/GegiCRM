using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class OrderProduct_editing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ReferansBirimFiyat",
                table: "OrdersProducts",
                type: "decimal(18,2)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "590bf7e8-59e4-48f5-8ad3-a73570c221b0", new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2845), new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8d75a5d-a181-480a-ac59-070f84a24c7b", new DateTime(2022, 7, 25, 16, 16, 14, 305, DateTimeKind.Local).AddTicks(2867), new DateTime(2022, 7, 25, 16, 16, 14, 305, DateTimeKind.Local).AddTicks(2885), "AQAAAAEAACcQAAAAEDOSKIjNcAWyLK8/YwYOFBFk/awdjNlE8k/XlhcDSNJm+8OMcG6movkJkCdxlZjccQ==", "a42e5a7f-3d78-4ce1-a660-c8b5d813b22a" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2963));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReferansBirimFiyat",
                table: "OrdersProducts",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "28de416b-05b6-4cdf-af17-a0f1dc724208", new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5583), new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71213228-eab5-43c3-9d9a-cdabe615e39a", new DateTime(2022, 7, 25, 16, 2, 8, 637, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 7, 25, 16, 2, 8, 637, DateTimeKind.Local).AddTicks(5652), "AQAAAAEAACcQAAAAEEMWsXoZpNd/9djugHzrUs53jUkRTccSVVqy55qna8cDij2n+bfEGxLpGF8qvmOxHA==", "b9347180-0d68-439c-955c-e825622170c4" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 2, 8, 638, DateTimeKind.Local).AddTicks(5774));
        }
    }
}
