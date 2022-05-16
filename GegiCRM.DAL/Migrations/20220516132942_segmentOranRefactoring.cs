using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class segmentOranRefactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SegmentOrans_Segments",
                table: "SegmentOrans");

            migrationBuilder.DropColumn(
                name: "EURO_ORAN",
                table: "SegmentOrans");

            migrationBuilder.DropColumn(
                name: "TL_ORAN",
                table: "SegmentOrans");

            migrationBuilder.DropColumn(
                name: "USD_ORAN",
                table: "SegmentOrans");

            migrationBuilder.AlterColumn<int>(
                name: "SegmentID",
                table: "SegmentOrans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyID",
                table: "SegmentOrans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Oran",
                table: "SegmentOrans",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "f16dbb21-a606-4780-bf2d-6ae6fc95351d", new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6055), new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6065), new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d033d734-c639-42da-8793-02fa82281bc1", new DateTime(2022, 5, 16, 16, 29, 40, 461, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 5, 16, 16, 29, 40, 461, DateTimeKind.Local).AddTicks(1195), "AQAAAAEAACcQAAAAEJHTVOp55nfwjMQbrC5Img1xuLwmlLsA79SoLnZp96YzEMPpmkFv3gPv3qHFwO9gSA==", "ac59d013-e23b-4b6e-a7f1-f39968c8db04" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 29, 40, 462, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_CurrencyID",
                table: "SegmentOrans",
                column: "CurrencyID");

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentOrans_Currencies_CurrencyID",
                table: "SegmentOrans",
                column: "CurrencyID",
                principalTable: "Currencies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentOrans_Segments",
                table: "SegmentOrans",
                column: "SegmentID",
                principalTable: "Segments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SegmentOrans_Currencies_CurrencyID",
                table: "SegmentOrans");

            migrationBuilder.DropForeignKey(
                name: "FK_SegmentOrans_Segments",
                table: "SegmentOrans");

            migrationBuilder.DropIndex(
                name: "IX_SegmentOrans_CurrencyID",
                table: "SegmentOrans");

            migrationBuilder.DropColumn(
                name: "CurrencyID",
                table: "SegmentOrans");

            migrationBuilder.DropColumn(
                name: "Oran",
                table: "SegmentOrans");

            migrationBuilder.AlterColumn<int>(
                name: "SegmentID",
                table: "SegmentOrans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "EURO_ORAN",
                table: "SegmentOrans",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TL_ORAN",
                table: "SegmentOrans",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "USD_ORAN",
                table: "SegmentOrans",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "dd75c814-dec7-4432-8241-88d73c1d1126", new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6542), new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6563), new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70a4c440-32ae-4dfc-ac9f-ae8e33270c0d", new DateTime(2022, 5, 16, 16, 11, 50, 807, DateTimeKind.Local).AddTicks(8881), new DateTime(2022, 5, 16, 16, 11, 50, 807, DateTimeKind.Local).AddTicks(8894), "AQAAAAEAACcQAAAAEFGVqhNhW4h4fD+L6IGbBuTF65ddFiz7LXEZqHH0qIEHq1PQfZMq4sAd4yfCACyFvw==", "bf7f10e4-45c1-456a-b505-609bc3fa6827" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 16, 11, 50, 809, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentOrans_Segments",
                table: "SegmentOrans",
                column: "SegmentID",
                principalTable: "Segments",
                principalColumn: "ID");
        }
    }
}
