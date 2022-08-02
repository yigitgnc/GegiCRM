using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class KesinSevkDurumu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KesinSevkDurumu",
                table: "OrdersProducts");

            migrationBuilder.AddColumn<int>(
                name: "KesinSevkDurumuId",
                table: "OrdersProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SendBill",
                table: "OrdersProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SonKullaniciilgisi",
                table: "CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeslimAlacakAdSoyad",
                table: "CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KesinSevkiyatDurumus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KesinSevkiyatDurumus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KesinSevkiyatDurumus_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KesinSevkiyatDurumus_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b99896a7-352d-4af2-91b5-9e8bfd289c6f", new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1773), new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a1634b-0a10-4db6-854f-0b53304afca3", new DateTime(2022, 8, 1, 12, 18, 39, 753, DateTimeKind.Local).AddTicks(1802), new DateTime(2022, 8, 1, 12, 18, 39, 753, DateTimeKind.Local).AddTicks(1815), "AQAAAAEAACcQAAAAEHoBxuLJwCzfVBbZXMgVkNrgt1Ven5TvnsRqifGK97bVvK+MOsAfIcrMfPX3vUcVJg==", "4f31626d-2034-407a-9300-f3d517dfc6f0" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.InsertData(
                table: "KesinSevkiyatDurumus",
                columns: new[] { "Id", "AddedById", "CreatedDate", "Description", "IsDeleted", "ModifiedById", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Sevkiyat" },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kargo" },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Email" },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Depo" },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Depo Teslim" },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Depo Teslim" }
                });

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 1, 12, 18, 39, 754, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_KesinSevkDurumuId",
                table: "OrdersProducts",
                column: "KesinSevkDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_KesinSevkiyatDurumus_AddedById",
                table: "KesinSevkiyatDurumus",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_KesinSevkiyatDurumus_ModifiedById",
                table: "KesinSevkiyatDurumus",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_KesinSevkiyatDurumus_KesinSevkDurumuId",
                table: "OrdersProducts",
                column: "KesinSevkDurumuId",
                principalTable: "KesinSevkiyatDurumus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersProducts_KesinSevkiyatDurumus_KesinSevkDurumuId",
                table: "OrdersProducts");

            migrationBuilder.DropTable(
                name: "KesinSevkiyatDurumus");

            migrationBuilder.DropIndex(
                name: "IX_OrdersProducts_KesinSevkDurumuId",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "KesinSevkDurumuId",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "SendBill",
                table: "OrdersProducts");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SonKullaniciilgisi",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "TeslimAlacakAdSoyad",
                table: "CustomerAddresses");

            migrationBuilder.AddColumn<string>(
                name: "KesinSevkDurumu",
                table: "OrdersProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "590bf7e8-59e4-48f5-8ad3-a73570c221b0", new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2845), new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8d75a5d-a181-480a-ac59-070f84a24c7b", new DateTime(2022, 7, 25, 16, 16, 14, 305, DateTimeKind.Local).AddTicks(2867), new DateTime(2022, 7, 25, 16, 16, 14, 305, DateTimeKind.Local).AddTicks(2885), "AQAAAAEAACcQAAAAEDOSKIjNcAWyLK8/YwYOFBFk/awdjNlE8k/XlhcDSNJm+8OMcG6movkJkCdxlZjccQ==", "a42e5a7f-3d78-4ce1-a660-c8b5d813b22a" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 25, 16, 16, 14, 306, DateTimeKind.Local).AddTicks(2963));
        }
    }
}
