using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class UserSeedSecurityStampNewGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AuthorizationsRoleGroups_RoleGroupId",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorizationsRoleGroups",
                table: "AuthorizationsRoleGroups");

            migrationBuilder.RenameTable(
                name: "AuthorizationsRoleGroups",
                newName: "AppAuthorizationsRoleGroups");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorizationsRoleGroups_ModifiedBy",
                table: "AppAuthorizationsRoleGroups",
                newName: "IX_AppAuthorizationsRoleGroups_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorizationsRoleGroups_AddedBy",
                table: "AppAuthorizationsRoleGroups",
                newName: "IX_AppAuthorizationsRoleGroups_AddedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAuthorizationsRoleGroups",
                table: "AppAuthorizationsRoleGroups",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "f7bd7f70-2c93-49aa-a57a-f6e512896af3", new DateTime(2022, 5, 13, 13, 52, 7, 991, DateTimeKind.Local).AddTicks(8078), new DateTime(2022, 5, 13, 13, 52, 7, 991, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 13, 13, 52, 7, 991, DateTimeKind.Local).AddTicks(8095), new DateTime(2022, 5, 13, 13, 52, 7, 991, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5026e16a-2b57-4cb8-86f1-42bbf9a76d9a", new DateTime(2022, 5, 13, 13, 52, 7, 990, DateTimeKind.Local).AddTicks(2654), new DateTime(2022, 5, 13, 13, 52, 7, 990, DateTimeKind.Local).AddTicks(2670), "AQAAAAEAACcQAAAAEBDs92gVemN2hD4sPfgoyZlGkDerPPj5AT7rLi5pFIbnrz7i7OkBxA6pxdh09mE0qA==", "8c594552-96d2-42d5-a03e-00c4a7776e71" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AppAuthorizationsRoleGroups_RoleGroupId",
                table: "AspNetRoles",
                column: "RoleGroupId",
                principalTable: "AppAuthorizationsRoleGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AppAuthorizationsRoleGroups_RoleGroupId",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAuthorizationsRoleGroups",
                table: "AppAuthorizationsRoleGroups");

            migrationBuilder.RenameTable(
                name: "AppAuthorizationsRoleGroups",
                newName: "AuthorizationsRoleGroups");

            migrationBuilder.RenameIndex(
                name: "IX_AppAuthorizationsRoleGroups_ModifiedBy",
                table: "AuthorizationsRoleGroups",
                newName: "IX_AuthorizationsRoleGroups_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_AppAuthorizationsRoleGroups_AddedBy",
                table: "AuthorizationsRoleGroups",
                newName: "IX_AuthorizationsRoleGroups_AddedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorizationsRoleGroups",
                table: "AuthorizationsRoleGroups",
                column: "ID");

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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54a6b78e-1744-4d87-a7f5-17cabd1787a0", new DateTime(2022, 5, 11, 16, 27, 59, 742, DateTimeKind.Local).AddTicks(4504), new DateTime(2022, 5, 11, 16, 27, 59, 742, DateTimeKind.Local).AddTicks(4517), "AQAAAAEAACcQAAAAEJZ2yFpM1EHnj5pcsDWlgocA/m3cf11erl6ruTFk/BkBBMemTZZWKWZvWK76+Xy/Og==", null });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AuthorizationsRoleGroups_RoleGroupId",
                table: "AspNetRoles",
                column: "RoleGroupId",
                principalTable: "AuthorizationsRoleGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
