using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class UserPpUrlAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "e53ef25f-b673-42e9-bc6a-4154998e4e48", new DateTime(2022, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 5, 9, 18, 24, 20, 538, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "719f4544-78da-49e9-82e7-5d02615af4d0", "AQAAAAEAACcQAAAAEBHFGnPZoTzBvmm33nCLvRd9VE+1hEvL2zvBUFLE5+jp6sfKI/k4LytOfDdt11ToXw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "e417ef46-9914-433e-9222-9fa7710a1cd4", new DateTime(2022, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3446), new DateTime(2022, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3469), new DateTime(2022, 5, 9, 16, 7, 15, 500, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d4da4ac-e28b-4a1c-84b1-fe8a475ae895", "AQAAAAEAACcQAAAAELkXfFt91b5qk7gsA6XdnTnI6DVKAdr6rE5AWPZd+JuAJ/Yukn2AjKCYTedCeoD3XQ==" });
        }
    }
}
