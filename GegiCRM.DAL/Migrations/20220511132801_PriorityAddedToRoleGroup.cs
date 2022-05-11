    using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class PriorityAddedToRoleGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "AuthorizationsRoleGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "eec97062-2eca-43fc-84f9-d88bc5f32850", new DateTime(2022, 5, 11, 16, 27, 59, 744, DateTimeKind.Local).AddTicks(550), new DateTime(2022, 5, 11, 16, 27, 59, 744, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 11, 16, 27, 59, 744, DateTimeKind.Local).AddTicks(565), new DateTime(2022, 5, 11, 16, 27, 59, 744, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash" },
                values: new object[] { "54a6b78e-1744-4d87-a7f5-17cabd1787a0", new DateTime(2022, 5, 11, 16, 27, 59, 742, DateTimeKind.Local).AddTicks(4504), new DateTime(2022, 5, 11, 16, 27, 59, 742, DateTimeKind.Local).AddTicks(4517), "AQAAAAEAACcQAAAAEJZ2yFpM1EHnj5pcsDWlgocA/m3cf11erl6ruTFk/BkBBMemTZZWKWZvWK76+Xy/Og==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "AuthorizationsRoleGroups");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "73636583-9341-4aa2-867e-dd6af359adaa", new DateTime(2022, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2212), new DateTime(2022, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash" },
                values: new object[] { "7f183313-6bd5-4991-9783-f044d3482f93", new DateTime(2022, 5, 11, 14, 17, 15, 908, DateTimeKind.Local).AddTicks(5823), new DateTime(2022, 5, 11, 14, 17, 15, 908, DateTimeKind.Local).AddTicks(5838), "AQAAAAEAACcQAAAAEMzrqjpEn6cxxD8BhGzfle43yqjHW6xx9z05BosHph4o9hqBcpoExngGvCHGJhGoWQ==" });
        }
    }
}
