using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class BaseEntity_Ekleniyor_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ModifiedBy",
                table: "Birims",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Banks",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<Guid>(
                name: "AddedBy",
                table: "BankInformations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AddedByNavigationId",
                table: "BankInformations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BankInformations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "BankInformations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedByNavigationId",
                table: "BankInformations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "BankInformations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ModifiedBy",
                table: "AuthorizationsRoles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_AddedByNavigationId",
                table: "BankInformations",
                column: "AddedByNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_ModifiedByNavigationId",
                table: "BankInformations",
                column: "ModifiedByNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankInformations_Users_AddedByNavigationId",
                table: "BankInformations",
                column: "AddedByNavigationId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankInformations_Users_ModifiedByNavigationId",
                table: "BankInformations",
                column: "ModifiedByNavigationId",
                principalTable: "Users",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankInformations_Users_AddedByNavigationId",
                table: "BankInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_BankInformations_Users_ModifiedByNavigationId",
                table: "BankInformations");

            migrationBuilder.DropIndex(
                name: "IX_BankInformations_AddedByNavigationId",
                table: "BankInformations");

            migrationBuilder.DropIndex(
                name: "IX_BankInformations_ModifiedByNavigationId",
                table: "BankInformations");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "BankInformations");

            migrationBuilder.DropColumn(
                name: "AddedByNavigationId",
                table: "BankInformations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BankInformations");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "BankInformations");

            migrationBuilder.DropColumn(
                name: "ModifiedByNavigationId",
                table: "BankInformations");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "BankInformations");

            migrationBuilder.AlterColumn<Guid>(
                name: "ModifiedBy",
                table: "Birims",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Banks",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "ModifiedBy",
                table: "AuthorizationsRoles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
