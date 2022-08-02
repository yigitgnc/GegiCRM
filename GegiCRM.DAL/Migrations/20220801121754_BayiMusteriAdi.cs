using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class BayiMusteriAdi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BayiMusteriAdi",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "129e8176-386b-4a50-a565-efb4e81d8c78", new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2751), new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d93d4cba-e7dc-41e3-beb8-09469b9cc404", new DateTime(2022, 8, 1, 15, 17, 51, 571, DateTimeKind.Local).AddTicks(2779), new DateTime(2022, 8, 1, 15, 17, 51, 571, DateTimeKind.Local).AddTicks(2794), "AQAAAAEAACcQAAAAEBKiChDGUs08d2rdm4+Z0iYz0idv2zNzWeih05Hughs/dV0nIcpk922EXroUM3SKTA==", "96f8a848-302e-45b1-9465-9429c041a338" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2952));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BayiMusteriAdi",
                table: "Orders");

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
    }
}
