using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class ConnectionIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SignalrConnectionId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "287f5f80-baaf-4c82-a124-728d158c2cf4", new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7285), new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e5d8c01-1cac-41fd-9a89-ceeee65fc43c", new DateTime(2022, 7, 19, 11, 47, 43, 103, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 7, 19, 11, 47, 43, 103, DateTimeKind.Local).AddTicks(7292), "AQAAAAEAACcQAAAAEAX/izBbaiYUTrjxFZ3PhPKKHv7ma7AZtyvttdZaU/YRFdam8mRQED920ZnyVHAMnw==", "f757c577-70d1-4ca4-aa57-6dcab691c46f" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7396));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SignalrConnectionId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "e6fbdfa2-9670-4ed6-9e10-de099cd2a5c6", new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9864), new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9875), new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c302b01-da5c-40e1-848d-390ecf8966cb", new DateTime(2022, 7, 18, 17, 56, 19, 570, DateTimeKind.Local).AddTicks(9872), new DateTime(2022, 7, 18, 17, 56, 19, 570, DateTimeKind.Local).AddTicks(9890), "AQAAAAEAACcQAAAAEIXo2efx0tRwuI3dsZu3YdV2qwvN9WyTxchC+QlYUU05CqhXCPAYoNlDaswA6PNdRw==", "3e481725-7aab-4e3b-a8ba-a0ede63c5b54" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 17, 56, 19, 571, DateTimeKind.Local).AddTicks(9984));
        }
    }
}
