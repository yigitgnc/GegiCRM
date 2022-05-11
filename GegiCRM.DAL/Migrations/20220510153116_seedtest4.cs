using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class seedtest4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "c9549a40-0018-4657-872f-4e7e4d4ba61c", new DateTime(2022, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5412), new DateTime(2022, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 10, 18, 31, 15, 63, DateTimeKind.Local).AddTicks(1693), new DateTime(2022, 5, 10, 18, 31, 15, 63, DateTimeKind.Local).AddTicks(1708), "YIGIT.GENC@GEGI.COM.TR", "AQAAAAEAACcQAAAAEMgLVazMvF/fnp+CBVafvIcXns9hQyvKN64i/IZgi+vLeaOMjTL2OWKQRCC/U+Wlsg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "ModifiedDate", "NormalizedEmail", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 10, 18, 18, 54, 901, DateTimeKind.Local).AddTicks(3615), new DateTime(2022, 5, 10, 18, 18, 54, 901, DateTimeKind.Local).AddTicks(3631), "YIGIT.GENC.GEGI.COM.TR", "AQAAAAEAACcQAAAAELgMx2oAgGlkeYduLPK5Wy1wsFRytnKn+mC6XVlG46DQQZlqSlJbmAi8d8cYv3zxPA==" });
        }
    }
}
