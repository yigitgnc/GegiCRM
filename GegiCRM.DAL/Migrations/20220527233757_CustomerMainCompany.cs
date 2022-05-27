using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class CustomerMainCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerMainCompanyId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CustomerMainCompanies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMainCompanies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerMainCompany_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerMainCompany_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "821598d7-40ca-41ca-8a26-a520c0b81285", new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5391), new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ca979eb-5b11-4378-b5dd-ac8cf0338b8e", new DateTime(2022, 5, 28, 2, 37, 55, 884, DateTimeKind.Local).AddTicks(5314), new DateTime(2022, 5, 28, 2, 37, 55, 884, DateTimeKind.Local).AddTicks(5327), "AQAAAAEAACcQAAAAEB/dD5rMDPSv6qOkxJznEuO92sJsF/JZcDWiE7ZSi4P729cE2p+pkc11LL05vcvD0g==", "8f072948-2418-42e3-a91f-4984300f1134" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.InsertData(
                table: "CustomerMainCompanies",
                columns: new[] { "ID", "AddedBy", "Description", "IsDeleted", "ModifiedBy", "Name" },
                values: new object[] { 1, 1, "Test Müşterisinin Ana Müşterisi (çatı firma)", false, null, "Test Ana Müşterisi" });

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 28, 2, 37, 55, 885, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CustomerMainCompanyId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerMainCompanyId",
                table: "Customers",
                column: "CustomerMainCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMainCompanies_AddedBy",
                table: "CustomerMainCompanies",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMainCompanies_ModifiedBy",
                table: "CustomerMainCompanies",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerMainCompanies_CustomerMainCompanyId",
                table: "Customers",
                column: "CustomerMainCompanyId",
                principalTable: "CustomerMainCompanies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerMainCompanies_CustomerMainCompanyId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerMainCompanies");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerMainCompanyId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerMainCompanyId",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b6b93b33-244d-40fc-bf95-b76e7973174b", new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4435), new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b00af3-ba74-4747-8112-b4b18f2442b0", new DateTime(2022, 5, 24, 15, 18, 46, 680, DateTimeKind.Local).AddTicks(7927), new DateTime(2022, 5, 24, 15, 18, 46, 680, DateTimeKind.Local).AddTicks(7942), "AQAAAAEAACcQAAAAEGq2kQPYWEhYG3IpQKaCpCNaJCxzKzkmSyfI77bUzUCNUMJ1NAOKJMbW/39tMhyfAA==", "75065bfc-ad8c-4c50-955e-362ed7d4f601" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 24, 15, 18, 46, 682, DateTimeKind.Local).AddTicks(4623));
        }
    }
}
