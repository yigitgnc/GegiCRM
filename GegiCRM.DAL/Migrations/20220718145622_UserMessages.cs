using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class UserMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SenderUserId = table.Column<int>(type: "int", nullable: false),
                    RecieverUserId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMessages_AspNetUsers_RecieverUserId",
                        column: x => x.RecieverUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserMessages_AspNetUsers_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_RecieverUserId",
                table: "UserMessages",
                column: "RecieverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_SenderUserId",
                table: "UserMessages",
                column: "SenderUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMessages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b6bbf254-5e0c-4c4a-8ba3-cf8d4ea31b5d", new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(549), new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ac5f532-77bc-4f9f-9441-fd18433c5444", new DateTime(2022, 7, 18, 16, 7, 53, 478, DateTimeKind.Local).AddTicks(750), new DateTime(2022, 7, 18, 16, 7, 53, 478, DateTimeKind.Local).AddTicks(764), "AQAAAAEAACcQAAAAEKkq3DtB+gZCoHQLgKIWI7OjxYYNceOj13eTUNV3rViN/C/qpUlHx73O3BjI4xFyVw==", "b9b5716b-fb38-4c9b-9728-4666a3c57e45" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 18, 16, 7, 53, 479, DateTimeKind.Local).AddTicks(856));
        }
    }
}
