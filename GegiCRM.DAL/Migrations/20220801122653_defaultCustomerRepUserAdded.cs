using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class defaultCustomerRepUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SonKullaniciilgisi",
                table: "CustomerAddresses",
                newName: "SonKullaniciBilgisi");

            migrationBuilder.AddColumn<int>(
                name: "DefaultRepresentetiveUserId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefaultRepresentetiveUserId1",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "736be1da-6024-4372-982c-a4a515ecb73e", new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(634), new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(660), new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff15d9ab-57fa-46c6-b7d6-5013704b3f09", new DateTime(2022, 8, 1, 15, 26, 50, 869, DateTimeKind.Local).AddTicks(9788), new DateTime(2022, 8, 1, 15, 26, 50, 869, DateTimeKind.Local).AddTicks(9811), "AQAAAAEAACcQAAAAEENU1YTzktOORysk39TNi8oHh+e/SepWHGcNBTgVBEMOY1rGSU3VU1B3uERI37zwrA==", "043dbc84-ed24-4c0c-b349-0d42dbcf3975" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 26, 50, 871, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DefaultRepresentetiveUserId1",
                table: "Customers",
                column: "DefaultRepresentetiveUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerRepresentetiveUsers_DefaultRepresentetiveUserId1",
                table: "Customers",
                column: "DefaultRepresentetiveUserId1",
                principalTable: "CustomerRepresentetiveUsers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerRepresentetiveUsers_DefaultRepresentetiveUserId1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DefaultRepresentetiveUserId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DefaultRepresentetiveUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DefaultRepresentetiveUserId1",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "SonKullaniciBilgisi",
                table: "CustomerAddresses",
                newName: "SonKullaniciilgisi");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "129e8176-386b-4a50-a565-efb4e81d8c78", new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2751), new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d93d4cba-e7dc-41e3-beb8-09469b9cc404", new DateTime(2022, 8, 1, 15, 17, 51, 571, DateTimeKind.Local).AddTicks(2779), new DateTime(2022, 8, 1, 15, 17, 51, 571, DateTimeKind.Local).AddTicks(2794), "AQAAAAEAACcQAAAAEBKiChDGUs08d2rdm4+Z0iYz0idv2zNzWeih05Hughs/dV0nIcpk922EXroUM3SKTA==", "96f8a848-302e-45b1-9465-9429c041a338" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 15, 17, 51, 572, DateTimeKind.Local).AddTicks(2952));
        }
    }
}
