using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class IdentityUsersRolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "UsersAuthorizationRoles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUserRoles",
                newName: "UserID");

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorizationRoleID",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUserRoles",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "AspNetUserRoles",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUserRoles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AspNetUserRoles",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "AspNetUserRoles",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_AddedBy",
                table: "AspNetUserRoles",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_AuthorizationRoleID",
                table: "AspNetUserRoles",
                column: "AuthorizationRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ModifiedBy",
                table: "AspNetUserRoles",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_Authorizations",
                table: "AspNetUserRoles",
                column: "AuthorizationRoleID",
                principalTable: "AspNetRoles",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_Users",
                table: "AspNetUserRoles",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_Users1",
                table: "AspNetUserRoles",
                column: "AddedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_Users2",
                table: "AspNetUserRoles",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersAuthorizations_Authorizations",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAuthorizations_Users",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAuthorizations_Users1",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAuthorizations_Users2",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_AddedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_AuthorizationRoleID",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ModifiedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "AuthorizationRoleID",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "AspNetUserRoles");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "AspNetUserRoles",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "UsersAuthorizationRoles",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AuthorizationRoleID = table.Column<int>(type: "int", nullable: false),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAuthorizations", x => new { x.UserID, x.AuthorizationRoleID });
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Authorizations",
                        column: x => x.AuthorizationRoleID,
                        principalTable: "AspNetRoles",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Users",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Users1",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Users2",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersAuthorizationRoles_AddedBy",
                table: "UsersAuthorizationRoles",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAuthorizationRoles_AuthorizationRoleID",
                table: "UsersAuthorizationRoles",
                column: "AuthorizationRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAuthorizationRoles_ModifiedBy",
                table: "UsersAuthorizationRoles",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
