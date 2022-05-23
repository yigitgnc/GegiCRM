using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class teklifTakip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeniedDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeneied",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "04d8dbe5-3db1-44ab-8b93-460fba3e10c3", new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(26), new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(36), new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfe5db11-62fa-4007-97b8-37d91d1b1fa4", new DateTime(2022, 5, 23, 23, 48, 41, 742, DateTimeKind.Local).AddTicks(4786), new DateTime(2022, 5, 23, 23, 48, 41, 742, DateTimeKind.Local).AddTicks(4797), "AQAAAAEAACcQAAAAEKbEenTa7nCVv0TUvgnAprBL+3+lkXIMFi3gTQWX3igMkf/1ex74eTimMfdJIh0cXw==", "e2ab040e-592e-40ef-b628-da9648818e0e" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 48, 41, 744, DateTimeKind.Local).AddTicks(264));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelledDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeniedDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeneied",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "387e1dd5-92c5-4da1-96d3-e7f4d9e7b2e0", new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6868), new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6886), new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e3c73e8-c011-4e5d-86b6-b9265255621b", new DateTime(2022, 5, 18, 17, 3, 39, 770, DateTimeKind.Local).AddTicks(1466), new DateTime(2022, 5, 18, 17, 3, 39, 770, DateTimeKind.Local).AddTicks(1482), "AQAAAAEAACcQAAAAELd6cIEgkJjaBxZ4ZvwsZ91tG1ptq7B6J7k8XzLATatII7Q8Gxdqe2zeLw51Nyqhbg==", "585178de-9259-4236-b31b-60096098e375" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7075));
        }
    }
}
