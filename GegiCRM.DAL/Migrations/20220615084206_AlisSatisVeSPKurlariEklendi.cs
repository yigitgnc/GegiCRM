using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class AlisSatisVeSPKurlariEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TercihEdilenKur",
                table: "Customers",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "AlisKuru",
                table: "Currencies",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SatisKuru",
                table: "Currencies",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SerbestPiyasaKuru",
                table: "Currencies",
                type: "decimal(18,2)",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "425a464c-b716-4ac9-8da3-f636feccead7", new DateTime(2022, 6, 15, 11, 42, 4, 723, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 6, 15, 11, 42, 4, 723, DateTimeKind.Local).AddTicks(390), "YG", "AQAAAAEAACcQAAAAEPAhrJgL25meePGW04++FoB+sfRYScQwH5KQvk1pwQUG4Tef/BROedYmVsGCNnZV6w==", "84734f4d-8a80-481c-9ae1-ed649d9f8084", "YG" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TercihEdilenKur",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AlisKuru",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "SatisKuru",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "SerbestPiyasaKuru",
                table: "Currencies");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "10359aa9-7d61-416d-b23a-622924a9a06e", new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7831), new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7841), new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b642e296-6241-43d3-a4d7-cf103db2aba9", new DateTime(2022, 6, 4, 2, 2, 57, 551, DateTimeKind.Local).AddTicks(7953), new DateTime(2022, 6, 4, 2, 2, 57, 551, DateTimeKind.Local).AddTicks(7965), "ADMINYGT", "AQAAAAEAACcQAAAAEDUtBnCdkObjbYMSmNla0okZ90sGhBjwrJ98qaIaTjuaVOMz5furiY+ez4eAnYQeeQ==", "fb309f57-2dc6-410c-8012-1951dc18f76b", "AdminYigit" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 2, 2, 57, 552, DateTimeKind.Local).AddTicks(8063));
        }
    }
}
