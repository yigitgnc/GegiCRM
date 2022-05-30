using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class currencyCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExchangeRate",
                table: "OrdersCurrencies",
                newName: "Value");

            migrationBuilder.AddColumn<decimal>(
                name: "CurentValue",
                table: "Currencies",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "178382e7-304d-4ec9-b4ef-7ef21d18894c", new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6587), new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6605), new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b66efec-ab6c-4896-a37f-d52599b96e6f", new DateTime(2022, 5, 30, 4, 31, 2, 795, DateTimeKind.Local).AddTicks(6681), new DateTime(2022, 5, 30, 4, 31, 2, 795, DateTimeKind.Local).AddTicks(6692), "AQAAAAEAACcQAAAAEPUMcpMXIFI9uCJzZrG7SKw/ITVqw5kPwwaPYzMUG+Xvhw6scDrYl8AVzjH35+XjbQ==", "975a3858-83df-4ae1-8229-410e11151c02" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 30, 4, 31, 2, 796, DateTimeKind.Local).AddTicks(6819));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurentValue",
                table: "Currencies");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "OrdersCurrencies",
                newName: "ExchangeRate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "148bc7bb-af0b-46a2-9b20-66d1ba9550eb", new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9338), new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9353), new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec06e58-5488-4056-8367-e838ab5c9d67", new DateTime(2022, 5, 29, 2, 54, 17, 261, DateTimeKind.Local).AddTicks(9364), new DateTime(2022, 5, 29, 2, 54, 17, 261, DateTimeKind.Local).AddTicks(9378), "AQAAAAEAACcQAAAAEGP80JMNB1MswV0sENbpLCIOlTMgt9J9ngkWJP6OrsTOUGZ54/7IGw3tEchFuOi+0Q==", "e11bee1b-275d-4216-a445-852a503f4a8a" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 29, 2, 54, 17, 262, DateTimeKind.Local).AddTicks(9647));
        }
    }
}
