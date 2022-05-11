using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class typoCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "73636583-9341-4aa2-867e-dd6af359adaa", new DateTime(2022, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2212), new DateTime(2022, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "AddedBy", "Discriminator", "EndDate", "Id", "IsDeleted", "ModifiedBy", "StartDate" },
                values: new object[] { 1, 1, 1, "AppRolesOfUsers", new DateTime(2032, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2240), 0, false, null, new DateTime(2022, 5, 11, 14, 17, 15, 910, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash" },
                values: new object[] { "7f183313-6bd5-4991-9783-f044d3482f93", new DateTime(2022, 5, 11, 14, 17, 15, 908, DateTimeKind.Local).AddTicks(5823), new DateTime(2022, 5, 11, 14, 17, 15, 908, DateTimeKind.Local).AddTicks(5838), "AQAAAAEAACcQAAAAEMzrqjpEn6cxxD8BhGzfle43yqjHW6xx9z05BosHph4o9hqBcpoExngGvCHGJhGoWQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "8763df58-0bcd-45f5-9f1e-a9c6f7f20213", new DateTime(2022, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "AddedBy", "CreatedDate", "Discriminator", "EndDate", "Id", "IsDeleted", "ModifiedBy", "StartDate" },
                values: new object[] { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUsersAuthorizationRole", new DateTime(2032, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6795), 0, false, null, new DateTime(2022, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash" },
                values: new object[] { "81b01307-1f51-4c79-8522-979c0bc4f820", new DateTime(2022, 5, 11, 12, 34, 51, 945, DateTimeKind.Local).AddTicks(43), new DateTime(2022, 5, 11, 12, 34, 51, 945, DateTimeKind.Local).AddTicks(55), "AQAAAAEAACcQAAAAEHvog1r/NSAox+U7a91Hfo8ntsN9Y9aEB32NYbKqT/G5qvXsVlQiokeBxBv9c7dutA==" });
        }
    }
}
