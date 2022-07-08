using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "40a7fd16-eec6-4a97-a1f0-1fc894b7deaf", new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6373), new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6386), new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b1b5a5a-a87a-4271-8362-ec1c9e70d5f4", new DateTime(2022, 7, 1, 9, 52, 47, 735, DateTimeKind.Local).AddTicks(6503), new DateTime(2022, 7, 1, 9, 52, 47, 735, DateTimeKind.Local).AddTicks(6521), "AQAAAAEAACcQAAAAEC19vy+mzClasgL1bzIROnppx8PP6wVLacGJYxP6t5C9YfHJb/z77wu6kDRxlzr+mg==", "512049cf-54df-446a-b0e0-b543bd317447" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Standart Müşteri Tipi", "Standart" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "ID", "AddedById", "CreatedDate", "Description", "IsDeleted", "ModifiedById", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potansiyel Bayi Müşteri Tipi", false, null, null, "Potansiyel Bayi" },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potansiyel Son Kullanıcı Müşteri Tipi", false, null, null, "Potansiyel Son Kullanıcı" }
                });

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 1, 9, 52, 47, 736, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                column: "SupplierName",
                value: "Penta");

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "AddedById", "DealerCode", "IsDeleted", "LastContactDate", "ModifiedById", "OncelikSirasi", "SupplierName", "URL" },
                values: new object[,]
                {
                    { 2, 1, "1234", false, null, null, null, "APC", null },
                    { 3, 1, "1235", false, null, null, null, "12M", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "021008c1-c01a-4a64-8425-90f93fb5dc0e", new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7895), new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7906), new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42d2b119-9146-459a-9cec-87d21c1ece91", new DateTime(2022, 6, 30, 11, 58, 53, 427, DateTimeKind.Local).AddTicks(7909), new DateTime(2022, 6, 30, 11, 58, 53, 427, DateTimeKind.Local).AddTicks(7929), "AQAAAAEAACcQAAAAEKzNRpyZG1OJufJl0g4uX5HhkPeeG1JX8ImtD8TV7CK9+lrUh2bCpucuKSCZO8QXwQ==", "a7f864b4-d6fa-479c-bac2-6cf1e99b8a72" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "CustomerTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Bu Müşteri Tipi Tesat Amaçlı Eklenmiştir", "Test Müşteri Tipi" });

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                column: "SupplierName",
                value: "Test Tedarikçisi");
        }
    }
}
