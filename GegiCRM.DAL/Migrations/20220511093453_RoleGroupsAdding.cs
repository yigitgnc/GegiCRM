using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class RoleGroupsAdding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUserRoles",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AspNetUserRoles",
                type: "int",
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

            migrationBuilder.AddColumn<int>(
                name: "RoleGroupId",
                table: "AspNetRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AuthorizationsRoleGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationsRoleGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AuthorizationRoleGroup_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AuthorizationRoleGroups_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "AddedBy", "Discriminator", "EndDate", "Id", "IsDeleted", "ModifiedBy", "StartDate" },
                values: new object[] { 1, 1, 1, "AppUsersAuthorizationRole", new DateTime(2032, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6795), 0, false, null, new DateTime(2022, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81b01307-1f51-4c79-8522-979c0bc4f820", new DateTime(2022, 5, 11, 12, 34, 51, 945, DateTimeKind.Local).AddTicks(43), new DateTime(2022, 5, 11, 12, 34, 51, 945, DateTimeKind.Local).AddTicks(55), "AQAAAAEAACcQAAAAEHvog1r/NSAox+U7a91Hfo8ntsN9Y9aEB32NYbKqT/G5qvXsVlQiokeBxBv9c7dutA==", null });

            migrationBuilder.InsertData(
                table: "AuthorizationsRoleGroups",
                columns: new[] { "ID", "AddedBy", "Description", "IsDeleted", "ModifiedBy", "Name" },
                values: new object[] { 1, 1, "Admin Rollerinin Bulunduğu Grup", false, null, "Admin Role Grubu" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "RoleGroupId" },
                values: new object[] { "8763df58-0bcd-45f5-9f1e-a9c6f7f20213", new DateTime(2022, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 5, 11, 12, 34, 51, 946, DateTimeKind.Local).AddTicks(6784), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_AddedBy",
                table: "AspNetUserRoles",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ModifiedBy",
                table: "AspNetUserRoles",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_RoleGroupId",
                table: "AspNetRoles",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationsRoleGroups_AddedBy",
                table: "AuthorizationsRoleGroups",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationsRoleGroups_ModifiedBy",
                table: "AuthorizationsRoleGroups",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AuthorizationsRoleGroups_RoleGroupId",
                table: "AspNetRoles",
                column: "RoleGroupId",
                principalTable: "AuthorizationsRoleGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_AddedBy",
                table: "AspNetUserRoles",
                column: "AddedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_ModifiedBy",
                table: "AspNetUserRoles",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AuthorizationsRoleGroups_RoleGroupId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAuthorizations_AddedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAuthorizations_ModifiedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AuthorizationsRoleGroups");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_AddedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ModifiedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_RoleGroupId",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "RoleGroupId",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "c9549a40-0018-4657-872f-4e7e4d4ba61c", new DateTime(2022, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator", "EndDate", "IsDeleted", "StartDate" },
                values: new object[] { 1, 1, "UsersAuthorizationRole", new DateTime(2032, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5412), false, new DateTime(2022, 5, 10, 18, 31, 15, 65, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb0be773-2b9d-4ad3-93a7-30a8fdf00c8a", new DateTime(2022, 5, 10, 18, 31, 15, 63, DateTimeKind.Local).AddTicks(1693), new DateTime(2022, 5, 10, 18, 31, 15, 63, DateTimeKind.Local).AddTicks(1708), "AQAAAAEAACcQAAAAEMgLVazMvF/fnp+CBVafvIcXns9hQyvKN64i/IZgi+vLeaOMjTL2OWKQRCC/U+Wlsg==", "VNB3UOQL5J2LFDAPPGL77YP643TINIZA" });
        }
    }
}
