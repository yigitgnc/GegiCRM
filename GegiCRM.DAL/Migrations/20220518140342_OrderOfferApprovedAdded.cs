using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class OrderOfferApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApprovedDate",
                table: "Orders",
                newName: "OrderApprovedDate");

            migrationBuilder.AddColumn<bool>(
                name: "IsOfferApproved",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOrderApproved",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "OfferApprovedDate",
                table: "Orders",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "387e1dd5-92c5-4da1-96d3-e7f4d9e7b2e0", new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6868), new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6886), new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e3c73e8-c011-4e5d-86b6-b9265255621b", new DateTime(2022, 5, 18, 17, 3, 39, 770, DateTimeKind.Local).AddTicks(1466), new DateTime(2022, 5, 18, 17, 3, 39, 770, DateTimeKind.Local).AddTicks(1482), "AQAAAAEAACcQAAAAELd6cIEgkJjaBxZ4ZvwsZ91tG1ptq7B6J7k8XzLATatII7Q8Gxdqe2zeLw51Nyqhbg==", "585178de-9259-4236-b31b-60096098e375" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 18, 17, 3, 39, 771, DateTimeKind.Local).AddTicks(7075));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOfferApproved",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsOrderApproved",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OfferApprovedDate",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderApprovedDate",
                table: "Orders",
                newName: "ApprovedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
        }
    }
}
