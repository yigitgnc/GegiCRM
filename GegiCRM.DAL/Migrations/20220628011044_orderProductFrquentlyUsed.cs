using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class orderProductFrquentlyUsed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFrequentlyUsed",
                table: "OrdersProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "3fe03e9a-0e17-466b-93bf-3db37119ab53", new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7444), new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f29142d8-2989-4d0f-925b-49bbf5717ead", new DateTime(2022, 6, 28, 4, 10, 42, 647, DateTimeKind.Local).AddTicks(7588), new DateTime(2022, 6, 28, 4, 10, 42, 647, DateTimeKind.Local).AddTicks(7611), "AQAAAAEAACcQAAAAENl3iM5TczU3X3Wfon/8Vq4N1ufKGa0NH7rkgpH0Fxqkab2P2lQU4JEsX/ZPtDV3kw==", "e76419a7-a7c5-473d-9bcb-eef7c414650c" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 4, 10, 42, 648, DateTimeKind.Local).AddTicks(7595));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFrequentlyUsed",
                table: "OrdersProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "e31334a7-fee0-47a9-8982-64af393a152a", new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(344), new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(354), new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "425a464c-b716-4ac9-8da3-f636feccead7", new DateTime(2022, 6, 15, 11, 42, 4, 723, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 6, 15, 11, 42, 4, 723, DateTimeKind.Local).AddTicks(390), "AQAAAAEAACcQAAAAEPAhrJgL25meePGW04++FoB+sfRYScQwH5KQvk1pwQUG4Tef/BROedYmVsGCNnZV6w==", "84734f4d-8a80-481c-9ae1-ed649d9f8084" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 15, 11, 42, 4, 724, DateTimeKind.Local).AddTicks(491));
        }
    }
}
