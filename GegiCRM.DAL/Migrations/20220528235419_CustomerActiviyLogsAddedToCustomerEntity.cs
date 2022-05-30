using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class CustomerActiviyLogsAddedToCustomerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
