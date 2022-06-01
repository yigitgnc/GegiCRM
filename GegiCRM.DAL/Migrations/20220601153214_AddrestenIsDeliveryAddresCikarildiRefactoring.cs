using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class AddrestenIsDeliveryAddresCikarildiRefactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeliveryAddress",
                table: "CustomerAddresses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "ae72e402-9b2c-4830-aa69-c9fb3ecdad42", new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5558), new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5571), new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d0f1a86-a2a0-4201-89ae-e0099f67605b", new DateTime(2022, 6, 1, 18, 32, 11, 779, DateTimeKind.Local).AddTicks(2407), new DateTime(2022, 6, 1, 18, 32, 11, 779, DateTimeKind.Local).AddTicks(2420), "AQAAAAEAACcQAAAAEPCis6dO+fUnapLDj6c1D/S5T/AYxB4He6ri2ctpXFghKINo9k9QFJHlyMutluoCWg==", "4a13755e-e1c8-464a-af85-a67e2d9d7d30" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 18, 32, 11, 780, DateTimeKind.Local).AddTicks(5829));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeliveryAddress",
                table: "CustomerAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "de12a709-7674-4053-8ba4-0d1b929ec50d", new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9645), new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9657), new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5825184e-ac1c-4c71-80ea-18abfdf2a22a", new DateTime(2022, 6, 1, 13, 0, 56, 283, DateTimeKind.Local).AddTicks(4858), new DateTime(2022, 6, 1, 13, 0, 56, 283, DateTimeKind.Local).AddTicks(4871), "AQAAAAEAACcQAAAAEPPnMgAG0T+Aed3Uvh//QOcsv1UN/BMbfJ6F4lKro4p0zNu2HWpny5mXFntFTnRzrw==", "ad24ad08-af1d-4e2d-ae54-5a68c2862090" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 13, 0, 56, 284, DateTimeKind.Local).AddTicks(9772));
        }
    }
}
