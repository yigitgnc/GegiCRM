using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class UserMessagesAddedv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_AspNetUsers_RecieverUserId",
                table: "UserMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_AspNetUsers_SenderUserId",
                table: "UserMessages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "88911184-d68f-4016-9fa3-db29091d57a9", new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(813), new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(827), new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75356196-11f8-48a9-86f8-f9585b2d6d67", new DateTime(2022, 7, 19, 15, 15, 31, 735, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 7, 19, 15, 15, 31, 735, DateTimeKind.Local).AddTicks(812), "AQAAAAEAACcQAAAAEIt/OU+iWB2tQC2GFkJRbXYhddgTtrmhZ4Le8BFQjZ3laKVJPisXYa/GjvGNgsxNKQ==", "118ecc06-f22c-45fa-81a3-071f14449906" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 15, 15, 31, 736, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_RecievedMessages",
                table: "UserMessages",
                column: "RecieverUserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SendedMessages",
                table: "UserMessages",
                column: "SenderUserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_RecievedMessages",
                table: "UserMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_SendedMessages",
                table: "UserMessages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "287f5f80-baaf-4c82-a124-728d158c2cf4", new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7285), new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e5d8c01-1cac-41fd-9a89-ceeee65fc43c", new DateTime(2022, 7, 19, 11, 47, 43, 103, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 7, 19, 11, 47, 43, 103, DateTimeKind.Local).AddTicks(7292), "AQAAAAEAACcQAAAAEAX/izBbaiYUTrjxFZ3PhPKKHv7ma7AZtyvttdZaU/YRFdam8mRQED920ZnyVHAMnw==", "f757c577-70d1-4ca4-aa57-6dcab691c46f" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 19, 11, 47, 43, 104, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_AspNetUsers_RecieverUserId",
                table: "UserMessages",
                column: "RecieverUserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_AspNetUsers_SenderUserId",
                table: "UserMessages",
                column: "SenderUserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
