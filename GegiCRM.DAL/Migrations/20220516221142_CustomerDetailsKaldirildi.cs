using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class CustomerDetailsKaldirildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDetails");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreferredCurrencyId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SideSuppliers",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "f7415de2-632c-4c03-8eb5-3288bcea313d", new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4510), new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4522), new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc445e18-8d0a-4996-adba-0a8b4281223f", new DateTime(2022, 5, 17, 1, 11, 38, 210, DateTimeKind.Local).AddTicks(6146), new DateTime(2022, 5, 17, 1, 11, 38, 210, DateTimeKind.Local).AddTicks(6160), "AQAAAAEAACcQAAAAEMDpR/t3hbuLofR2waGH/lT4CGbmQXXDI4WdpZOeC47Kh2wYFEhP2yzM0canM+4gCA==", "d4cb2d9f-cd39-4811-82d7-5ca101ea601b" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 1, 11, 38, 212, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PreferredCurrencyId",
                table: "Customers",
                column: "PreferredCurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Currencies_PreferredCurrencyId",
                table: "Customers",
                column: "PreferredCurrencyId",
                principalTable: "Currencies",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Currencies_PreferredCurrencyId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PreferredCurrencyId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PreferredCurrencyId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SideSuppliers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Tel",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideSuppliers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerDetails_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerDetails_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerDetails_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "2333022b-8b6e-4046-9f3d-d8296835f2f5", new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8063), new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8096), new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b77e7f-115c-4954-a528-da265732c5d8", new DateTime(2022, 5, 16, 18, 19, 11, 111, DateTimeKind.Local).AddTicks(6179), new DateTime(2022, 5, 16, 18, 19, 11, 111, DateTimeKind.Local).AddTicks(6194), "AQAAAAEAACcQAAAAEJOl42vYFkZbo/zNFideKZW9xEdmqWvpVbK5Xv2uin8y56xsOD3eP8p797Edoj8u3Q==", "8bc1ede8-59c1-48c9-ba9e-ac19ab3641c8" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 18, 19, 11, 113, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_AddedBy",
                table: "CustomerDetails",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CurrencyID",
                table: "CustomerDetails",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerID",
                table: "CustomerDetails",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_ModifiedBy",
                table: "CustomerDetails",
                column: "ModifiedBy");
        }
    }
}
