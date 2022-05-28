using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class CustomerRemovedLastContactDateProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastContactDate",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "7232da43-5438-43b0-8b6a-21239622c3bd", new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5656), new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5666), new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9383802-643e-497c-ba18-a4077baadc86", new DateTime(2022, 5, 29, 2, 27, 30, 796, DateTimeKind.Local).AddTicks(5844), new DateTime(2022, 5, 29, 2, 27, 30, 796, DateTimeKind.Local).AddTicks(5856), "AQAAAAEAACcQAAAAEK5E3D/6Q3rq9zgRDZ0RPGruQ6PSu92vlSfJgqmxZeRMnNNQp2hHyd+Sld6mzuPZaA==", "0db0607c-369c-4a52-8502-48bd12083670" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 27, 30, 797, DateTimeKind.Local).AddTicks(5863));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastContactDate",
                table: "Customers",
                type: "datetime",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "821598d7-40ca-41ca-8a26-a520c0b81285", new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5391), new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ca979eb-5b11-4378-b5dd-ac8cf0338b8e", new DateTime(2022, 5, 28, 2, 37, 55, 884, DateTimeKind.Local).AddTicks(5314), new DateTime(2022, 5, 28, 2, 37, 55, 884, DateTimeKind.Local).AddTicks(5327), "AQAAAAEAACcQAAAAEB/dD5rMDPSv6qOkxJznEuO92sJsF/JZcDWiE7ZSi4P729cE2p+pkc11LL05vcvD0g==", "8f072948-2418-42e3-a91f-4984300f1134" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5707));
        }
    }
}
