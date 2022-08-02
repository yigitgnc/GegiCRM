using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class duzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendBill",
                table: "OrdersProducts");

            migrationBuilder.AddColumn<bool>(
                name: "SendBill",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "bf0ea21c-f48b-4427-8d31-513f78adeff8", new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5698), new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8464036e-e4e9-497a-83a2-9624b480b00c", new DateTime(2022, 8, 1, 13, 23, 43, 928, DateTimeKind.Local).AddTicks(5846), new DateTime(2022, 8, 1, 13, 23, 43, 928, DateTimeKind.Local).AddTicks(5864), "AQAAAAEAACcQAAAAEPARZ5Qbe7/ryHz0BgftC4zgCqQrwmEu4jEOMNZrtfFz8QQT94WARPs/vWIc+mYCKQ==", "f510e69f-92b0-4d53-88ed-44d4f7d7e843" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 13, 23, 43, 929, DateTimeKind.Local).AddTicks(5947));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendBill",
                table: "Orders");

            migrationBuilder.AddColumn<bool>(
                name: "SendBill",
                table: "OrdersProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b99896a7-352d-4af2-91b5-9e8bfd289c6f", new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1773), new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a1634b-0a10-4db6-854f-0b53304afca3", new DateTime(2022, 8, 1, 12, 18, 39, 753, DateTimeKind.Local).AddTicks(1802), new DateTime(2022, 8, 1, 12, 18, 39, 753, DateTimeKind.Local).AddTicks(1815), "AQAAAAEAACcQAAAAEHoBxuLJwCzfVBbZXMgVkNrgt1Ven5TvnsRqifGK97bVvK+MOsAfIcrMfPX3vUcVJg==", "4f31626d-2034-407a-9300-f3d517dfc6f0" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2016));
        }
    }
}
