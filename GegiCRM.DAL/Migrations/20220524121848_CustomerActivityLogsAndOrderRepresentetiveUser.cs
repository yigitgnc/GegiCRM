using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class CustomerActivityLogsAndOrderRepresentetiveUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepresentetiveUserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CustomerActivityLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerActivityLogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerActivityLogs_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersActivityLog_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomersActivityLog_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b6b93b33-244d-40fc-bf95-b76e7973174b", new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4435), new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b00af3-ba74-4747-8112-b4b18f2442b0", new DateTime(2022, 5, 24, 15, 18, 46, 680, DateTimeKind.Local).AddTicks(7927), new DateTime(2022, 5, 24, 15, 18, 46, 680, DateTimeKind.Local).AddTicks(7942), "AQAAAAEAACcQAAAAEGq2kQPYWEhYG3IpQKaCpCNaJCxzKzkmSyfI77bUzUCNUMJ1NAOKJMbW/39tMhyfAA==", "75065bfc-ad8c-4c50-955e-362ed7d4f601" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RepresentetiveUserId",
                table: "Orders",
                column: "RepresentetiveUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerActivityLogs_AddedBy",
                table: "CustomerActivityLogs",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerActivityLogs_CustomerId",
                table: "CustomerActivityLogs",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerActivityLogs_ModifiedBy",
                table: "CustomerActivityLogs",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersRepresentetiveUsers",
                table: "Orders",
                column: "RepresentetiveUserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersRepresentetiveUsers",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "CustomerActivityLogs");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RepresentetiveUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RepresentetiveUserId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "881b1bdb-e039-4444-965f-270285db481b", new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2453), new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2468), new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a29b979-6125-4a92-8bae-3e6ee1171f88", new DateTime(2022, 5, 24, 12, 20, 27, 730, DateTimeKind.Local).AddTicks(6862), new DateTime(2022, 5, 24, 12, 20, 27, 730, DateTimeKind.Local).AddTicks(6876), "AQAAAAEAACcQAAAAEN0GpBHDb6obtrA2HTneRYiYZFD5uaVCko4ihAzDYvi4as3jhO3D6bPOChhNpibGog==", "ef7b1e4d-d442-4b4c-990f-49ab27b389d0" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2720));
        }
    }
}
