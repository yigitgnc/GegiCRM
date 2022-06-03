using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class OfferNoteAndOrderNoteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OfferNote",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderNote",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "12c5e3f1-5e15-436c-9a21-b2bfe626774c", new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6974), new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eb79329-5922-4861-b050-029035d9e6a2", new DateTime(2022, 6, 3, 22, 39, 55, 792, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 6, 3, 22, 39, 55, 792, DateTimeKind.Local).AddTicks(6982), "AQAAAAEAACcQAAAAEBMqQANXXbkgzgqhqVfryxyoKODXxIYOpnoOMwsiLgUtWqxqwQHLUMRd3odUfVf1CA==", "d3d0876f-26ef-4ed3-8f9e-289cdcb6f550" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CurrentValue" },
                values: new object[] { new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7142), 1m });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CurrentValue" },
                values: new object[] { new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7165), 16m });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CurrentValue" },
                values: new object[] { new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7169), 17m });

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 3, 22, 39, 55, 793, DateTimeKind.Local).AddTicks(7303));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferNote",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderNote",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "ae72e402-9b2c-4830-aa69-c9fb3ecdad42", new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5558), new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5571), new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d0f1a86-a2a0-4201-89ae-e0099f67605b", new DateTime(2022, 6, 1, 18, 32, 11, 779, DateTimeKind.Local).AddTicks(2407), new DateTime(2022, 6, 1, 18, 32, 11, 779, DateTimeKind.Local).AddTicks(2420), "AQAAAAEAACcQAAAAEPCis6dO+fUnapLDj6c1D/S5T/AYxB4He6ri2ctpXFghKINo9k9QFJHlyMutluoCWg==", "4a13755e-e1c8-464a-af85-a67e2d9d7d30" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CurrentValue" },
                values: new object[] { new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5702), null });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CurrentValue" },
                values: new object[] { new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5720), null });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CurrentValue" },
                values: new object[] { new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5723), null });

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5829));
        }
    }
}
