using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class seedtest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "1442ec8c-0078-409f-a44f-5ea37f2af3c5", new DateTime(2022, 5, 10, 18, 18, 54, 903, DateTimeKind.Local).AddTicks(5183), new DateTime(2022, 5, 10, 18, 18, 54, 903, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 10, 18, 18, 54, 903, DateTimeKind.Local).AddTicks(5204), new DateTime(2022, 5, 10, 18, 18, 54, 903, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb0be773-2b9d-4ad3-93a7-30a8fdf00c8a", new DateTime(2022, 5, 10, 18, 18, 54, 901, DateTimeKind.Local).AddTicks(3615), new DateTime(2022, 5, 10, 18, 18, 54, 901, DateTimeKind.Local).AddTicks(3631), "AQAAAAEAACcQAAAAELgMx2oAgGlkeYduLPK5Wy1wsFRytnKn+mC6XVlG46DQQZlqSlJbmAi8d8cYv3zxPA==", "VNB3UOQL5J2LFDAPPGL77YP643TINIZA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "46db4753-ca38-4741-a0d9-5acd56a36010", new DateTime(2022, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8872), new DateTime(2022, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 10, 18, 16, 34, 886, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "", new DateTime(2022, 5, 10, 18, 16, 34, 885, DateTimeKind.Local).AddTicks(3077), new DateTime(2022, 5, 10, 18, 16, 34, 885, DateTimeKind.Local).AddTicks(3093), "AQAAAAEAACcQAAAAECEPCJQv58/gxlI1NQ0QvEFT2nCS4ktwWm8GYQN5VDoz69O3LHCxQLF5IXBkw7nvuQ==", "" });
        }
    }
}
