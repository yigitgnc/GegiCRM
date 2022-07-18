using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class UserActivyLogsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivityLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveMunites = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivityLogs_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "0d74524b-1d8f-4add-ad32-1bc9df6af7ac", new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1907), new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1919), new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88a65d4a-bf5e-4a7a-8adc-4f894518a281", new DateTime(2022, 7, 16, 21, 28, 7, 525, DateTimeKind.Local).AddTicks(1774), new DateTime(2022, 7, 16, 21, 28, 7, 525, DateTimeKind.Local).AddTicks(1786), "AQAAAAEAACcQAAAAECiJOguvFYGbLyl1osq44SSW00exX6+Gu8EFsqcuBTGD8ZYcqmM3cRm3KvQSPiuy8w==", "1f72d0f8-0058-4802-a7b3-8fb4f476d71e" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 16, 21, 28, 7, 526, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityLogs_AppUserId",
                table: "UserActivityLogs",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActivityLogs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "40a7fd16-eec6-4a97-a1f0-1fc894b7deaf", new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6373), new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6386), new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b1b5a5a-a87a-4271-8362-ec1c9e70d5f4", new DateTime(2022, 7, 1, 9, 52, 47, 735, DateTimeKind.Local).AddTicks(6503), new DateTime(2022, 7, 1, 9, 52, 47, 735, DateTimeKind.Local).AddTicks(6521), "AQAAAAEAACcQAAAAEC19vy+mzClasgL1bzIROnppx8PP6wVLacGJYxP6t5C9YfHJb/z77wu6kDRxlzr+mg==", "512049cf-54df-446a-b0e0-b543bd317447" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6566));
        }
    }
}
