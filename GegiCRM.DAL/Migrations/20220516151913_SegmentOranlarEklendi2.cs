using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class SegmentOranlarEklendi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 49.99m, false, null, 22.5m, 1, 0.00m },
                    { 2, 1, 1, 199.99m, false, null, 13.5m, 1, 50.00m },
                    { 3, 1, 1, 499.99m, false, null, 11m, 1, 200.00m },
                    { 4, 1, 1, 999.99m, false, null, 7.5m, 1, 500.00m },
                    { 5, 1, 1, 2499.99m, false, null, 6m, 1, 1000.00m },
                    { 6, 1, 1, 4999.99m, false, null, 5.25m, 1, 2500.00m },
                    { 7, 1, 1, 9999.99m, false, null, 5m, 1, 5000.00m },
                    { 8, 1, 1, 19999.99m, false, null, 4.5m, 1, 10000.00m },
                    { 9, 1, 1, 39999.99m, false, null, 4m, 1, 20000.00m },
                    { 10, 1, 1, 74999.99m, false, null, 3.38m, 1, 40000.00m },
                    { 11, 1, 1, 99999.99m, false, null, 3m, 1, 75000.00m },
                    { 12, 1, 1, 149999.99m, false, null, 3m, 1, 100000.00m },
                    { 13, 1, 1, 249999.99m, false, null, 2m, 1, 150000.00m },
                    { 14, 1, 1, 499999.99m, false, null, 1.88m, 1, 250000.00m },
                    { 15, 1, 1, 999999.99m, false, null, 2m, 1, 500000.00m },
                    { 16, 1, 1, 99999999.99m, false, null, 1.5m, 1, 1000000.00m },
                    { 17, 1, 1, 49.99m, false, null, 27m, 2, 0.00m },
                    { 18, 1, 1, 199.99m, false, null, 16.2m, 2, 50.00m },
                    { 19, 1, 1, 499.99m, false, null, 126.6m, 2, 200.00m },
                    { 20, 1, 1, 999.99m, false, null, 9m, 2, 500.00m },
                    { 21, 1, 1, 2499.99m, false, null, 7.2m, 2, 1000.00m },
                    { 22, 1, 1, 4999.99m, false, null, 6.3m, 2, 2500.00m },
                    { 23, 1, 1, 9999.99m, false, null, 5.85m, 2, 5000.00m },
                    { 24, 1, 1, 19999.99m, false, null, 5.4m, 2, 10000.00m },
                    { 25, 1, 1, 39999.99m, false, null, 4.5m, 2, 20000.00m },
                    { 26, 1, 1, 74999.99m, false, null, 4.05m, 2, 40000.00m },
                    { 27, 1, 1, 99999.99m, false, null, 3.78m, 2, 75000.00m },
                    { 28, 1, 1, 149999.99m, false, null, 3.6m, 2, 100000.00m },
                    { 29, 1, 1, 249999.99m, false, null, 2.7m, 2, 150000.00m },
                    { 30, 1, 1, 499999.99m, false, null, 2.25m, 2, 250000.00m },
                    { 31, 1, 1, 999999.99m, false, null, 1.98m, 2, 500000.00m },
                    { 32, 1, 1, 99999999.99m, false, null, 1.8m, 2, 1000000.00m },
                    { 33, 1, 1, 49.99m, false, null, 32.4m, 3, 0.00m },
                    { 34, 1, 1, 199.99m, false, null, 19.44m, 3, 50.00m },
                    { 35, 1, 1, 499.99m, false, null, 15.12m, 3, 200.00m },
                    { 36, 1, 1, 999.99m, false, null, 10.8m, 3, 500.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 37, 1, 1, 2499.99m, false, null, 8.64m, 3, 1000.00m },
                    { 38, 1, 1, 4999.99m, false, null, 7.56m, 3, 2500.00m },
                    { 39, 1, 1, 9999.99m, false, null, 7.02m, 3, 5000.00m },
                    { 40, 1, 1, 19999.99m, false, null, 6.48m, 3, 10000.00m },
                    { 41, 1, 1, 39999.99m, false, null, 5.4m, 3, 20000.00m },
                    { 42, 1, 1, 74999.99m, false, null, 4.86m, 3, 40000.00m },
                    { 43, 1, 1, 99999.99m, false, null, 4.54m, 3, 75000.00m },
                    { 44, 1, 1, 149999.99m, false, null, 4.32m, 3, 100000.00m },
                    { 45, 1, 1, 249999.99m, false, null, 3.24m, 3, 150000.00m },
                    { 46, 1, 1, 499999.99m, false, null, 2.7m, 3, 250000.00m },
                    { 47, 1, 1, 999999.99m, false, null, 2.38m, 3, 500000.00m },
                    { 48, 1, 1, 99999999.99m, false, null, 2.16m, 3, 1000000.00m },
                    { 49, 1, 1, 49.99m, false, null, 38.88m, 4, 0.00m },
                    { 50, 1, 1, 199.99m, false, null, 23.33m, 4, 50.00m },
                    { 51, 1, 1, 499.99m, false, null, 18.14m, 4, 200.00m },
                    { 52, 1, 1, 999.99m, false, null, 12.96m, 4, 500.00m },
                    { 53, 1, 1, 2499.99m, false, null, 10.37m, 4, 1000.00m },
                    { 54, 1, 1, 4999.99m, false, null, 9.07m, 4, 2500.00m },
                    { 55, 1, 1, 9999.99m, false, null, 8.42m, 4, 5000.00m },
                    { 56, 1, 1, 19999.99m, false, null, 7.78m, 4, 10000.00m },
                    { 57, 1, 1, 39999.99m, false, null, 6.48m, 4, 20000.00m },
                    { 58, 1, 1, 74999.99m, false, null, 5.83m, 4, 40000.00m },
                    { 59, 1, 1, 99999.99m, false, null, 5.44m, 4, 75000.00m },
                    { 60, 1, 1, 149999.99m, false, null, 5.18m, 4, 100000.00m },
                    { 61, 1, 1, 249999.99m, false, null, 3.89m, 4, 150000.00m },
                    { 62, 1, 1, 499999.99m, false, null, 3.24m, 4, 250000.00m },
                    { 63, 1, 1, 999999.99m, false, null, 2.85m, 4, 500000.00m },
                    { 64, 1, 1, 99999999.99m, false, null, 2.59m, 4, 1000000.00m },
                    { 65, 1, 1, 49.99m, false, null, 46.66m, 5, 0.00m },
                    { 66, 1, 1, 199.99m, false, null, 27.99m, 5, 50.00m },
                    { 67, 1, 1, 499.99m, false, null, 21.77m, 5, 200.00m },
                    { 68, 1, 1, 999.99m, false, null, 15.55m, 5, 500.00m },
                    { 69, 1, 1, 2499.99m, false, null, 12.44m, 5, 1000.00m },
                    { 70, 1, 1, 4999.99m, false, null, 10.89m, 5, 2500.00m },
                    { 71, 1, 1, 9999.99m, false, null, 10.11m, 5, 5000.00m },
                    { 72, 1, 1, 19999.99m, false, null, 9.33m, 5, 10000.00m },
                    { 73, 1, 1, 39999.99m, false, null, 7.78m, 5, 20000.00m },
                    { 74, 1, 1, 74999.99m, false, null, 7m, 5, 40000.00m },
                    { 75, 1, 1, 99999.99m, false, null, 6.53m, 5, 75000.00m },
                    { 76, 1, 1, 149999.99m, false, null, 6.22m, 5, 100000.00m },
                    { 77, 1, 1, 249999.99m, false, null, 4.67m, 5, 150000.00m },
                    { 78, 1, 1, 499999.99m, false, null, 3.89m, 5, 250000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 79, 1, 1, 999999.99m, false, null, 3.42m, 5, 500000.00m },
                    { 80, 1, 1, 99999999.99m, false, null, 3.11m, 5, 1000000.00m },
                    { 81, 1, 1, 49.99m, false, null, 55.99m, 6, 0.00m },
                    { 82, 1, 1, 199.99m, false, null, 33.59m, 6, 50.00m },
                    { 83, 1, 1, 499.99m, false, null, 26.13m, 6, 200.00m },
                    { 84, 1, 1, 999.99m, false, null, 18.66m, 6, 500.00m },
                    { 85, 1, 1, 2499.99m, false, null, 14.93m, 6, 1000.00m },
                    { 86, 1, 1, 4999.99m, false, null, 13.06m, 6, 2500.00m },
                    { 87, 1, 1, 9999.99m, false, null, 12.13m, 6, 5000.00m },
                    { 88, 1, 1, 19999.99m, false, null, 11.2m, 6, 10000.00m },
                    { 89, 1, 1, 39999.99m, false, null, 9.33m, 6, 20000.00m },
                    { 90, 1, 1, 74999.99m, false, null, 8.4m, 6, 40000.00m },
                    { 91, 1, 1, 99999.99m, false, null, 7.84m, 6, 75000.00m },
                    { 92, 1, 1, 149999.99m, false, null, 7.46m, 6, 100000.00m },
                    { 93, 1, 1, 249999.99m, false, null, 5.6m, 6, 150000.00m },
                    { 94, 1, 1, 499999.99m, false, null, 4.67m, 6, 250000.00m },
                    { 95, 1, 1, 999999.99m, false, null, 4.11m, 6, 500000.00m },
                    { 96, 1, 1, 99999999.99m, false, null, 3.73m, 6, 1000000.00m },
                    { 97, 1, 1, 49.99m, false, null, 67.18m, 7, 0.00m },
                    { 98, 1, 1, 199.99m, false, null, 40.31m, 7, 50.00m },
                    { 99, 1, 1, 499.99m, false, null, 31.35m, 7, 200.00m },
                    { 100, 1, 1, 999.99m, false, null, 22.39m, 7, 500.00m },
                    { 101, 1, 1, 2499.99m, false, null, 17.92m, 7, 1000.00m },
                    { 102, 1, 1, 4999.99m, false, null, 15.68m, 7, 2500.00m },
                    { 103, 1, 1, 9999.99m, false, null, 14.56m, 7, 5000.00m },
                    { 104, 1, 1, 19999.99m, false, null, 13.44m, 7, 10000.00m },
                    { 105, 1, 1, 39999.99m, false, null, 11.2m, 7, 20000.00m },
                    { 106, 1, 1, 74999.99m, false, null, 10.08m, 7, 40000.00m },
                    { 107, 1, 1, 99999.99m, false, null, 9.41m, 7, 75000.00m },
                    { 108, 1, 1, 149999.99m, false, null, 8.96m, 7, 100000.00m },
                    { 109, 1, 1, 249999.99m, false, null, 6.72m, 7, 150000.00m },
                    { 110, 1, 1, 499999.99m, false, null, 5.6m, 7, 250000.00m },
                    { 111, 1, 1, 999999.99m, false, null, 4.93m, 7, 500000.00m },
                    { 112, 1, 1, 99999999.99m, false, null, 4.48m, 7, 1000000.00m },
                    { 113, 1, 1, 49.99m, false, null, 80.62m, 8, 0.00m },
                    { 114, 1, 1, 199.99m, false, null, 48.37m, 8, 50.00m },
                    { 115, 1, 1, 499.99m, false, null, 37.62m, 8, 200.00m },
                    { 116, 1, 1, 999.99m, false, null, 26.87m, 8, 500.00m },
                    { 117, 1, 1, 2499.99m, false, null, 21.5m, 8, 1000.00m },
                    { 118, 1, 1, 4999.99m, false, null, 18.81m, 8, 2500.00m },
                    { 119, 1, 1, 9999.99m, false, null, 17.47m, 8, 5000.00m },
                    { 120, 1, 1, 19999.99m, false, null, 16.12m, 8, 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 121, 1, 1, 39999.99m, false, null, 13.44m, 8, 20000.00m },
                    { 122, 1, 1, 74999.99m, false, null, 12.09m, 8, 40000.00m },
                    { 123, 1, 1, 99999.99m, false, null, 11.29m, 8, 75000.00m },
                    { 124, 1, 1, 149999.99m, false, null, 10.75m, 8, 100000.00m },
                    { 125, 1, 1, 249999.99m, false, null, 8.06m, 8, 150000.00m },
                    { 126, 1, 1, 499999.99m, false, null, 6.72m, 8, 250000.00m },
                    { 127, 1, 1, 999999.99m, false, null, 5.91m, 8, 500000.00m },
                    { 128, 1, 1, 99999999.99m, false, null, 5.37m, 8, 1000000.00m },
                    { 129, 1, 1, 49.99m, false, null, 96.75m, 9, 0.00m },
                    { 130, 1, 1, 199.99m, false, null, 58.05m, 9, 50.00m },
                    { 131, 1, 1, 499.99m, false, null, 45.15m, 9, 200.00m },
                    { 132, 1, 1, 999.99m, false, null, 32.25m, 9, 500.00m },
                    { 133, 1, 1, 2499.99m, false, null, 25.8m, 9, 1000.00m },
                    { 134, 1, 1, 4999.99m, false, null, 22.57m, 9, 2500.00m },
                    { 135, 1, 1, 9999.99m, false, null, 20.96m, 9, 5000.00m },
                    { 136, 1, 1, 19999.99m, false, null, 19.35m, 9, 10000.00m },
                    { 137, 1, 1, 39999.99m, false, null, 16.12m, 9, 20000.00m },
                    { 138, 1, 1, 74999.99m, false, null, 14.51m, 9, 40000.00m },
                    { 139, 1, 1, 99999.99m, false, null, 13.54m, 9, 75000.00m },
                    { 140, 1, 1, 149999.99m, false, null, 12.9m, 9, 100000.00m },
                    { 141, 1, 1, 249999.99m, false, null, 9.67m, 9, 150000.00m },
                    { 142, 1, 1, 499999.99m, false, null, 8.06m, 9, 250000.00m },
                    { 143, 1, 1, 999999.99m, false, null, 7m, 9, 500000.00m },
                    { 144, 1, 1, 99999999.99m, false, null, 6.45m, 9, 1000000.00m },
                    { 145, 1, 1, 49.99m, false, null, 116.1m, 10, 0.00m },
                    { 146, 1, 1, 199.99m, false, null, 72.56m, 10, 50.00m },
                    { 147, 1, 1, 499.99m, false, null, 58.69m, 10, 200.00m },
                    { 148, 1, 1, 999.99m, false, null, 43.54m, 10, 500.00m },
                    { 149, 1, 1, 2499.99m, false, null, 36.12m, 10, 1000.00m },
                    { 150, 1, 1, 4999.99m, false, null, 32.73m, 10, 2500.00m },
                    { 151, 1, 1, 9999.99m, false, null, 31.44m, 10, 5000.00m },
                    { 152, 1, 1, 19999.99m, false, null, 29.99m, 10, 10000.00m },
                    { 153, 1, 1, 39999.99m, false, null, 25.8m, 10, 20000.00m },
                    { 154, 1, 1, 74999.99m, false, null, 23.94m, 10, 40000.00m },
                    { 155, 1, 1, 99999.99m, false, null, 23.03m, 10, 75000.00m },
                    { 156, 1, 1, 149999.99m, false, null, 22.57m, 10, 100000.00m },
                    { 157, 1, 1, 249999.99m, false, null, 17.41m, 10, 150000.00m },
                    { 158, 1, 1, 499999.99m, false, null, 14.91m, 10, 250000.00m },
                    { 159, 1, 1, 999999.99m, false, null, 13.48m, 10, 500000.00m },
                    { 160, 1, 1, 99999999.99m, false, null, 12.58m, 10, 1000000.00m },
                    { 161, 1, 2, 49.99m, false, null, 15m, 1, 0.00m },
                    { 162, 1, 2, 199.99m, false, null, 9m, 1, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 163, 1, 2, 499.99m, false, null, 7m, 1, 200.00m },
                    { 164, 1, 2, 999.99m, false, null, 5m, 1, 500.00m },
                    { 165, 1, 2, 2499.99m, false, null, 4m, 1, 1000.00m },
                    { 166, 1, 2, 4999.99m, false, null, 3.5m, 1, 2500.00m },
                    { 167, 1, 2, 9999.99m, false, null, 3.25m, 1, 5000.00m },
                    { 168, 1, 2, 19999.99m, false, null, 3m, 1, 10000.00m },
                    { 169, 1, 2, 39999.99m, false, null, 2.5m, 1, 20000.00m },
                    { 170, 1, 2, 74999.99m, false, null, 2.25m, 1, 40000.00m },
                    { 171, 1, 2, 99999.99m, false, null, 2.1m, 1, 75000.00m },
                    { 172, 1, 2, 149999.99m, false, null, 2m, 1, 100000.00m },
                    { 173, 1, 2, 249999.99m, false, null, 1.5m, 1, 150000.00m },
                    { 174, 1, 2, 499999.99m, false, null, 1.25m, 1, 250000.00m },
                    { 175, 1, 2, 999999.99m, false, null, 1.1m, 1, 500000.00m },
                    { 176, 1, 2, 99999999.99m, false, null, 1m, 1, 1000000.00m },
                    { 177, 1, 2, 49.99m, false, null, 18m, 2, 0.00m },
                    { 178, 1, 2, 199.99m, false, null, 10.8m, 2, 50.00m },
                    { 179, 1, 2, 499.99m, false, null, 8.4m, 2, 200.00m },
                    { 180, 1, 2, 999.99m, false, null, 6m, 2, 500.00m },
                    { 181, 1, 2, 2499.99m, false, null, 4.8m, 2, 1000.00m },
                    { 182, 1, 2, 4999.99m, false, null, 4.2m, 2, 2500.00m },
                    { 183, 1, 2, 9999.99m, false, null, 3.9m, 2, 5000.00m },
                    { 184, 1, 2, 19999.99m, false, null, 3.6m, 2, 10000.00m },
                    { 185, 1, 2, 39999.99m, false, null, 3m, 2, 20000.00m },
                    { 186, 1, 2, 74999.99m, false, null, 2.7m, 2, 40000.00m },
                    { 187, 1, 2, 99999.99m, false, null, 2.52m, 2, 75000.00m },
                    { 188, 1, 2, 149999.99m, false, null, 2.4m, 2, 100000.00m },
                    { 189, 1, 2, 249999.99m, false, null, 1.8m, 2, 150000.00m },
                    { 190, 1, 2, 499999.99m, false, null, 1.5m, 2, 250000.00m },
                    { 191, 1, 2, 999999.99m, false, null, 1.32m, 2, 500000.00m },
                    { 192, 1, 2, 99999999.99m, false, null, 1.2m, 2, 1000000.00m },
                    { 193, 1, 2, 49.99m, false, null, 21.6m, 3, 0.00m },
                    { 194, 1, 2, 199.99m, false, null, 12.96m, 3, 50.00m },
                    { 195, 1, 2, 499.99m, false, null, 10.08m, 3, 200.00m },
                    { 196, 1, 2, 999.99m, false, null, 7.2m, 3, 500.00m },
                    { 197, 1, 2, 2499.99m, false, null, 5.76m, 3, 1000.00m },
                    { 198, 1, 2, 4999.99m, false, null, 5.04m, 3, 2500.00m },
                    { 199, 1, 2, 9999.99m, false, null, 4.68m, 3, 5000.00m },
                    { 200, 1, 2, 19999.99m, false, null, 4.32m, 3, 10000.00m },
                    { 201, 1, 2, 39999.99m, false, null, 3.6m, 3, 20000.00m },
                    { 202, 1, 2, 74999.99m, false, null, 3.24m, 3, 40000.00m },
                    { 203, 1, 2, 99999.99m, false, null, 3.02m, 3, 75000.00m },
                    { 204, 1, 2, 149999.99m, false, null, 2.88m, 3, 100000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 205, 1, 2, 249999.99m, false, null, 2.16m, 3, 150000.00m },
                    { 206, 1, 2, 499999.99m, false, null, 1.8m, 3, 250000.00m },
                    { 207, 1, 2, 999999.99m, false, null, 1.58m, 3, 500000.00m },
                    { 208, 1, 2, 99999999.99m, false, null, 1.44m, 3, 1000000.00m },
                    { 209, 1, 2, 49.99m, false, null, 25.92m, 4, 0.00m },
                    { 210, 1, 2, 199.99m, false, null, 15.55m, 4, 50.00m },
                    { 211, 1, 2, 499.99m, false, null, 12.1m, 4, 200.00m },
                    { 212, 1, 2, 999.99m, false, null, 8.64m, 4, 500.00m },
                    { 213, 1, 2, 2499.99m, false, null, 6.91m, 4, 1000.00m },
                    { 214, 1, 2, 4999.99m, false, null, 6.05m, 4, 2500.00m },
                    { 215, 1, 2, 9999.99m, false, null, 5.62m, 4, 5000.00m },
                    { 216, 1, 2, 19999.99m, false, null, 5.18m, 4, 10000.00m },
                    { 217, 1, 2, 39999.99m, false, null, 4.32m, 4, 20000.00m },
                    { 218, 1, 2, 74999.99m, false, null, 3.89m, 4, 40000.00m },
                    { 219, 1, 2, 99999.99m, false, null, 3.63m, 4, 75000.00m },
                    { 220, 1, 2, 149999.99m, false, null, 3.46m, 4, 100000.00m },
                    { 221, 1, 2, 249999.99m, false, null, 2.59m, 4, 150000.00m },
                    { 222, 1, 2, 499999.99m, false, null, 2.16m, 4, 250000.00m },
                    { 223, 1, 2, 999999.99m, false, null, 1.9m, 4, 500000.00m },
                    { 224, 1, 2, 99999999.99m, false, null, 1.73m, 4, 1000000.00m },
                    { 225, 1, 2, 49.99m, false, null, 31.1m, 5, 0.00m },
                    { 226, 1, 2, 199.99m, false, null, 18.66m, 5, 50.00m },
                    { 227, 1, 2, 499.99m, false, null, 14.52m, 5, 200.00m },
                    { 228, 1, 2, 999.99m, false, null, 10.37m, 5, 500.00m },
                    { 229, 1, 2, 2499.99m, false, null, 8.29m, 5, 1000.00m },
                    { 230, 1, 2, 4999.99m, false, null, 7.26m, 5, 2500.00m },
                    { 231, 1, 2, 9999.99m, false, null, 6.74m, 5, 5000.00m },
                    { 232, 1, 2, 19999.99m, false, null, 6.22m, 5, 10000.00m },
                    { 233, 1, 2, 39999.99m, false, null, 5.18m, 5, 20000.00m },
                    { 234, 1, 2, 74999.99m, false, null, 4.67m, 5, 40000.00m },
                    { 235, 1, 2, 99999.99m, false, null, 4.35m, 5, 75000.00m },
                    { 236, 1, 2, 149999.99m, false, null, 4.15m, 5, 100000.00m },
                    { 237, 1, 2, 249999.99m, false, null, 3.11m, 5, 150000.00m },
                    { 238, 1, 2, 499999.99m, false, null, 2.59m, 5, 250000.00m },
                    { 239, 1, 2, 999999.99m, false, null, 2.28m, 5, 500000.00m },
                    { 240, 1, 2, 99999999.99m, false, null, 2.07m, 5, 1000000.00m },
                    { 241, 1, 2, 49.99m, false, null, 37.32m, 6, 0.00m },
                    { 242, 1, 2, 199.99m, false, null, 22.39m, 6, 50.00m },
                    { 243, 1, 2, 499.99m, false, null, 17.42m, 6, 200.00m },
                    { 244, 1, 2, 999.99m, false, null, 12.44m, 6, 500.00m },
                    { 245, 1, 2, 2499.99m, false, null, 9.95m, 6, 1000.00m },
                    { 246, 1, 2, 4999.99m, false, null, 8.71m, 6, 2500.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 247, 1, 2, 9999.99m, false, null, 8.09m, 6, 5000.00m },
                    { 248, 1, 2, 19999.99m, false, null, 7.46m, 6, 10000.00m },
                    { 249, 1, 2, 39999.99m, false, null, 6.22m, 6, 20000.00m },
                    { 250, 1, 2, 74999.99m, false, null, 5.6m, 6, 40000.00m },
                    { 251, 1, 2, 99999.99m, false, null, 5.23m, 6, 75000.00m },
                    { 252, 1, 2, 149999.99m, false, null, 4.98m, 6, 100000.00m },
                    { 253, 1, 2, 249999.99m, false, null, 3.73m, 6, 150000.00m },
                    { 254, 1, 2, 499999.99m, false, null, 3.11m, 6, 250000.00m },
                    { 255, 1, 2, 999999.99m, false, null, 2.74m, 6, 500000.00m },
                    { 256, 1, 2, 99999999.99m, false, null, 2.49m, 6, 1000000.00m },
                    { 257, 1, 2, 49.99m, false, null, 44.79m, 7, 0.00m },
                    { 258, 1, 2, 199.99m, false, null, 26.87m, 7, 50.00m },
                    { 259, 1, 2, 499.99m, false, null, 20.9m, 7, 200.00m },
                    { 260, 1, 2, 999.99m, false, null, 14.93m, 7, 500.00m },
                    { 261, 1, 2, 2499.99m, false, null, 11.94m, 7, 1000.00m },
                    { 262, 1, 2, 4999.99m, false, null, 10.45m, 7, 2500.00m },
                    { 263, 1, 2, 9999.99m, false, null, 9.7m, 7, 5000.00m },
                    { 264, 1, 2, 19999.99m, false, null, 8.96m, 7, 10000.00m },
                    { 265, 1, 2, 39999.99m, false, null, 7.46m, 7, 20000.00m },
                    { 266, 1, 2, 74999.99m, false, null, 6.72m, 7, 40000.00m },
                    { 267, 1, 2, 99999.99m, false, null, 6.27m, 7, 75000.00m },
                    { 268, 1, 2, 149999.99m, false, null, 5.97m, 7, 100000.00m },
                    { 269, 1, 2, 249999.99m, false, null, 4.48m, 7, 150000.00m },
                    { 270, 1, 2, 499999.99m, false, null, 3.73m, 7, 250000.00m },
                    { 271, 1, 2, 999999.99m, false, null, 3.28m, 7, 500000.00m },
                    { 272, 1, 2, 99999999.99m, false, null, 2.99m, 7, 1000000.00m },
                    { 273, 1, 2, 49.99m, false, null, 53.75m, 8, 0.00m },
                    { 274, 1, 2, 199.99m, false, null, 32.25m, 8, 50.00m },
                    { 275, 1, 2, 499.99m, false, null, 25.08m, 8, 200.00m },
                    { 276, 1, 2, 999.99m, false, null, 17.92m, 8, 500.00m },
                    { 277, 1, 2, 2499.99m, false, null, 14.33m, 8, 1000.00m },
                    { 278, 1, 2, 4999.99m, false, null, 12.54m, 8, 2500.00m },
                    { 279, 1, 2, 9999.99m, false, null, 11.65m, 8, 5000.00m },
                    { 280, 1, 2, 19999.99m, false, null, 10.75m, 8, 10000.00m },
                    { 281, 1, 2, 39999.99m, false, null, 8.96m, 8, 20000.00m },
                    { 282, 1, 2, 74999.99m, false, null, 8.06m, 8, 40000.00m },
                    { 283, 1, 2, 99999.99m, false, null, 7.52m, 8, 75000.00m },
                    { 284, 1, 2, 149999.99m, false, null, 7.17m, 8, 100000.00m },
                    { 285, 1, 2, 249999.99m, false, null, 5.37m, 8, 150000.00m },
                    { 286, 1, 2, 499999.99m, false, null, 4.48m, 8, 250000.00m },
                    { 287, 1, 2, 999999.99m, false, null, 3.94m, 8, 500000.00m },
                    { 288, 1, 2, 99999999.99m, false, null, 3.58m, 8, 1000000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 289, 1, 2, 49.99m, false, null, 64.5m, 9, 0.00m },
                    { 290, 1, 2, 199.99m, false, null, 38.7m, 9, 50.00m },
                    { 291, 1, 2, 499.99m, false, null, 30.1m, 9, 200.00m },
                    { 292, 1, 2, 999.99m, false, null, 21.5m, 9, 500.00m },
                    { 293, 1, 2, 2499.99m, false, null, 17.2m, 9, 1000.00m },
                    { 294, 1, 2, 4999.99m, false, null, 15.05m, 9, 2500.00m },
                    { 295, 1, 2, 9999.99m, false, null, 13.97m, 9, 5000.00m },
                    { 296, 1, 2, 19999.99m, false, null, 12.9m, 9, 10000.00m },
                    { 297, 1, 2, 39999.99m, false, null, 10.75m, 9, 20000.00m },
                    { 298, 1, 2, 74999.99m, false, null, 9.67m, 9, 40000.00m },
                    { 299, 1, 2, 99999.99m, false, null, 9.03m, 9, 75000.00m },
                    { 300, 1, 2, 149999.99m, false, null, 8.6m, 9, 100000.00m },
                    { 301, 1, 2, 249999.99m, false, null, 6.45m, 9, 150000.00m },
                    { 302, 1, 2, 499999.99m, false, null, 5.37m, 9, 250000.00m },
                    { 303, 1, 2, 999999.99m, false, null, 4.73m, 9, 500000.00m },
                    { 304, 1, 2, 99999999.99m, false, null, 4.3m, 9, 1000000.00m },
                    { 305, 1, 2, 49.99m, false, null, 77.4m, 10, 0.00m },
                    { 306, 1, 2, 199.99m, false, null, 48.37m, 10, 50.00m },
                    { 307, 1, 2, 499.99m, false, null, 39.13m, 10, 200.00m },
                    { 308, 1, 2, 999.99m, false, null, 29.02m, 10, 500.00m },
                    { 309, 1, 2, 2499.99m, false, null, 24.08m, 10, 1000.00m },
                    { 310, 1, 2, 4999.99m, false, null, 21.82m, 10, 2500.00m },
                    { 311, 1, 2, 9999.99m, false, null, 20.96m, 10, 5000.00m },
                    { 312, 1, 2, 19999.99m, false, null, 19.99m, 10, 10000.00m },
                    { 313, 1, 2, 39999.99m, false, null, 17.2m, 10, 20000.00m },
                    { 314, 1, 2, 74999.99m, false, null, 15.96m, 10, 40000.00m },
                    { 315, 1, 2, 99999.99m, false, null, 15.35m, 10, 75000.00m },
                    { 316, 1, 2, 149999.99m, false, null, 15.05m, 10, 100000.00m },
                    { 317, 1, 2, 249999.99m, false, null, 11.61m, 10, 150000.00m },
                    { 318, 1, 2, 499999.99m, false, null, 9.94m, 10, 250000.00m },
                    { 319, 1, 2, 999999.99m, false, null, 8.99m, 10, 500000.00m },
                    { 320, 1, 2, 99999999.99m, false, null, 5.96m, 10, 1000000.00m },
                    { 321, 1, 3, 49.99m, false, null, 13.5m, 1, 0.00m },
                    { 322, 1, 3, 199.99m, false, null, 8.1m, 1, 50.00m },
                    { 323, 1, 3, 499.99m, false, null, 6.3m, 1, 200.00m },
                    { 324, 1, 3, 999.99m, false, null, 4.5m, 1, 500.00m },
                    { 325, 1, 3, 2499.99m, false, null, 3.6m, 1, 1000.00m },
                    { 326, 1, 3, 4999.99m, false, null, 3.15m, 1, 2500.00m },
                    { 327, 1, 3, 9999.99m, false, null, 2.93m, 1, 5000.00m },
                    { 328, 1, 3, 19999.99m, false, null, 2.7m, 1, 10000.00m },
                    { 329, 1, 3, 39999.99m, false, null, 2.25m, 1, 20000.00m },
                    { 330, 1, 3, 74999.99m, false, null, 2.03m, 1, 40000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 331, 1, 3, 99999.99m, false, null, 1.89m, 1, 75000.00m },
                    { 332, 1, 3, 149999.99m, false, null, 1.8m, 1, 100000.00m },
                    { 333, 1, 3, 249999.99m, false, null, 1.35m, 1, 150000.00m },
                    { 334, 1, 3, 499999.99m, false, null, 1.13m, 1, 250000.00m },
                    { 335, 1, 3, 999999.99m, false, null, 0.99m, 1, 500000.00m },
                    { 336, 1, 3, 99999999.99m, false, null, 0.9m, 1, 1000000.00m },
                    { 337, 1, 3, 49.99m, false, null, 16.2m, 2, 0.00m },
                    { 338, 1, 3, 199.99m, false, null, 9.72m, 2, 50.00m },
                    { 339, 1, 3, 499.99m, false, null, 7.56m, 2, 200.00m },
                    { 340, 1, 3, 999.99m, false, null, 5.4m, 2, 500.00m },
                    { 341, 1, 3, 2499.99m, false, null, 4.32m, 2, 1000.00m },
                    { 342, 1, 3, 4999.99m, false, null, 3.78m, 2, 2500.00m },
                    { 343, 1, 3, 9999.99m, false, null, 3.51m, 2, 5000.00m },
                    { 344, 1, 3, 19999.99m, false, null, 3.24m, 2, 10000.00m },
                    { 345, 1, 3, 39999.99m, false, null, 2.7m, 2, 20000.00m },
                    { 346, 1, 3, 74999.99m, false, null, 2.43m, 2, 40000.00m },
                    { 347, 1, 3, 99999.99m, false, null, 2.27m, 2, 75000.00m },
                    { 348, 1, 3, 149999.99m, false, null, 2.16m, 2, 100000.00m },
                    { 349, 1, 3, 249999.99m, false, null, 1.62m, 2, 150000.00m },
                    { 350, 1, 3, 499999.99m, false, null, 1.35m, 2, 250000.00m },
                    { 351, 1, 3, 999999.99m, false, null, 1.19m, 2, 500000.00m },
                    { 352, 1, 3, 99999999.99m, false, null, 1.08m, 2, 1000000.00m },
                    { 353, 1, 3, 49.99m, false, null, 19.44m, 3, 0.00m },
                    { 354, 1, 3, 199.99m, false, null, 11.66m, 3, 50.00m },
                    { 355, 1, 3, 499.99m, false, null, 9.07m, 3, 200.00m },
                    { 356, 1, 3, 999.99m, false, null, 6.48m, 3, 500.00m },
                    { 357, 1, 3, 2499.99m, false, null, 5.18m, 3, 1000.00m },
                    { 358, 1, 3, 4999.99m, false, null, 4.54m, 3, 2500.00m },
                    { 359, 1, 3, 9999.99m, false, null, 4.21m, 3, 5000.00m },
                    { 360, 1, 3, 19999.99m, false, null, 3.89m, 3, 10000.00m },
                    { 361, 1, 3, 39999.99m, false, null, 3.24m, 3, 20000.00m },
                    { 362, 1, 3, 74999.99m, false, null, 2.92m, 3, 40000.00m },
                    { 363, 1, 3, 99999.99m, false, null, 2.72m, 3, 75000.00m },
                    { 364, 1, 3, 149999.99m, false, null, 2.59m, 3, 100000.00m },
                    { 365, 1, 3, 249999.99m, false, null, 1.94m, 3, 150000.00m },
                    { 366, 1, 3, 499999.99m, false, null, 1.62m, 3, 250000.00m },
                    { 367, 1, 3, 999999.99m, false, null, 1.43m, 3, 500000.00m },
                    { 368, 1, 3, 99999999.99m, false, null, 1.3m, 3, 1000000.00m },
                    { 369, 1, 3, 49.99m, false, null, 23.33m, 4, 0.00m },
                    { 370, 1, 3, 199.99m, false, null, 14m, 4, 50.00m },
                    { 371, 1, 3, 499.99m, false, null, 10.89m, 4, 200.00m },
                    { 372, 1, 3, 999.99m, false, null, 7.78m, 4, 500.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 373, 1, 3, 2499.99m, false, null, 6.22m, 4, 1000.00m },
                    { 374, 1, 3, 4999.99m, false, null, 5.44m, 4, 2500.00m },
                    { 375, 1, 3, 9999.99m, false, null, 5.05m, 4, 5000.00m },
                    { 376, 1, 3, 19999.99m, false, null, 4.67m, 4, 10000.00m },
                    { 377, 1, 3, 39999.99m, false, null, 3.89m, 4, 20000.00m },
                    { 378, 1, 3, 74999.99m, false, null, 3.5m, 4, 40000.00m },
                    { 379, 1, 3, 99999.99m, false, null, 3.27m, 4, 75000.00m },
                    { 380, 1, 3, 149999.99m, false, null, 3.11m, 4, 100000.00m },
                    { 381, 1, 3, 249999.99m, false, null, 2.33m, 4, 150000.00m },
                    { 382, 1, 3, 499999.99m, false, null, 1.9m, 4, 250000.00m },
                    { 383, 1, 3, 999999.99m, false, null, 1.71m, 4, 500000.00m },
                    { 384, 1, 3, 99999999.99m, false, null, 1.56m, 4, 1000000.00m },
                    { 385, 1, 3, 49.99m, false, null, 27.99m, 5, 0.00m },
                    { 386, 1, 3, 199.99m, false, null, 16.8m, 5, 50.00m },
                    { 387, 1, 3, 499.99m, false, null, 13.06m, 5, 200.00m },
                    { 388, 1, 3, 999.99m, false, null, 9.33m, 5, 500.00m },
                    { 389, 1, 3, 2499.99m, false, null, 7.46m, 5, 1000.00m },
                    { 390, 1, 3, 4999.99m, false, null, 6.53m, 5, 2500.00m },
                    { 391, 1, 3, 9999.99m, false, null, 6.07m, 5, 5000.00m },
                    { 392, 1, 3, 19999.99m, false, null, 5.6m, 5, 10000.00m },
                    { 393, 1, 3, 39999.99m, false, null, 4.67m, 5, 20000.00m },
                    { 394, 1, 3, 74999.99m, false, null, 4.2m, 5, 40000.00m },
                    { 395, 1, 3, 99999.99m, false, null, 3.92m, 5, 75000.00m },
                    { 396, 1, 3, 149999.99m, false, null, 3.73m, 5, 100000.00m },
                    { 397, 1, 3, 249999.99m, false, null, 2.8m, 5, 150000.00m },
                    { 398, 1, 3, 499999.99m, false, null, 2.33m, 5, 250000.00m },
                    { 399, 1, 3, 999999.99m, false, null, 2.05m, 5, 500000.00m },
                    { 400, 1, 3, 99999999.99m, false, null, 1.87m, 5, 1000000.00m },
                    { 401, 1, 3, 49.99m, false, null, 33.59m, 6, 0.00m },
                    { 402, 1, 3, 199.99m, false, null, 20.16m, 6, 50.00m },
                    { 403, 1, 3, 499.99m, false, null, 15.68m, 6, 200.00m },
                    { 404, 1, 3, 999.99m, false, null, 11.2m, 6, 500.00m },
                    { 405, 1, 3, 2499.99m, false, null, 8.96m, 6, 1000.00m },
                    { 406, 1, 3, 4999.99m, false, null, 7.84m, 6, 2500.00m },
                    { 407, 1, 3, 9999.99m, false, null, 7.28m, 6, 5000.00m },
                    { 408, 1, 3, 19999.99m, false, null, 6.72m, 6, 10000.00m },
                    { 409, 1, 3, 39999.99m, false, null, 5.6m, 6, 20000.00m },
                    { 410, 1, 3, 74999.99m, false, null, 5.04m, 6, 40000.00m },
                    { 411, 1, 3, 99999.99m, false, null, 4.7m, 6, 75000.00m },
                    { 412, 1, 3, 149999.99m, false, null, 4.48m, 6, 100000.00m },
                    { 413, 1, 3, 249999.99m, false, null, 3.36m, 6, 150000.00m },
                    { 414, 1, 3, 499999.99m, false, null, 2.8m, 6, 250000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 415, 1, 3, 999999.99m, false, null, 2.46m, 6, 500000.00m },
                    { 416, 1, 3, 99999999.99m, false, null, 2.24m, 6, 1000000.00m },
                    { 417, 1, 3, 49.99m, false, null, 40.31m, 7, 0.00m },
                    { 418, 1, 3, 199.99m, false, null, 24.19m, 7, 50.00m },
                    { 419, 1, 3, 499.99m, false, null, 18.81m, 7, 200.00m },
                    { 420, 1, 3, 999.99m, false, null, 13.44m, 7, 500.00m },
                    { 421, 1, 3, 2499.99m, false, null, 10.75m, 7, 1000.00m },
                    { 422, 1, 3, 4999.99m, false, null, 9.41m, 7, 2500.00m },
                    { 423, 1, 3, 9999.99m, false, null, 8.73m, 7, 5000.00m },
                    { 424, 1, 3, 19999.99m, false, null, 8.06m, 7, 10000.00m },
                    { 425, 1, 3, 39999.99m, false, null, 6.72m, 7, 20000.00m },
                    { 426, 1, 3, 74999.99m, false, null, 6.05m, 7, 40000.00m },
                    { 427, 1, 3, 99999.99m, false, null, 5.64m, 7, 75000.00m },
                    { 428, 1, 3, 149999.99m, false, null, 5.37m, 7, 100000.00m },
                    { 429, 1, 3, 249999.99m, false, null, 4.03m, 7, 150000.00m },
                    { 430, 1, 3, 499999.99m, false, null, 3.36m, 7, 250000.00m },
                    { 431, 1, 3, 999999.99m, false, null, 2.96m, 7, 500000.00m },
                    { 432, 1, 3, 99999999.99m, false, null, 2.69m, 7, 1000000.00m },
                    { 433, 1, 3, 49.99m, false, null, 48.37m, 8, 0.00m },
                    { 434, 1, 3, 199.99m, false, null, 29.02m, 8, 50.00m },
                    { 435, 1, 3, 499.99m, false, null, 22.57m, 8, 200.00m },
                    { 436, 1, 3, 999.99m, false, null, 16.12m, 8, 500.00m },
                    { 437, 1, 3, 2499.99m, false, null, 12.9m, 8, 1000.00m },
                    { 438, 1, 3, 4999.99m, false, null, 11.29m, 8, 2500.00m },
                    { 439, 1, 3, 9999.99m, false, null, 10.48m, 8, 5000.00m },
                    { 440, 1, 3, 19999.99m, false, null, 9.67m, 8, 10000.00m },
                    { 441, 1, 3, 39999.99m, false, null, 8.06m, 8, 20000.00m },
                    { 442, 1, 3, 74999.99m, false, null, 7.26m, 8, 40000.00m },
                    { 443, 1, 3, 99999.99m, false, null, 6.77m, 8, 75000.00m },
                    { 444, 1, 3, 149999.99m, false, null, 6.45m, 8, 100000.00m },
                    { 445, 1, 3, 249999.99m, false, null, 4.84m, 8, 150000.00m },
                    { 446, 1, 3, 499999.99m, false, null, 4.03m, 8, 250000.00m },
                    { 447, 1, 3, 999999.99m, false, null, 3.55m, 8, 500000.00m },
                    { 448, 1, 3, 99999999.99m, false, null, 3.22m, 8, 1000000.00m },
                    { 449, 1, 3, 49.99m, false, null, 58.05m, 9, 0.00m },
                    { 450, 1, 3, 199.99m, false, null, 34.83m, 9, 50.00m },
                    { 451, 1, 3, 499.99m, false, null, 27.09m, 9, 200.00m },
                    { 452, 1, 3, 999.99m, false, null, 19.35m, 9, 500.00m },
                    { 453, 1, 3, 2499.99m, false, null, 15.48m, 9, 1000.00m },
                    { 454, 1, 3, 4999.99m, false, null, 13.54m, 9, 2500.00m },
                    { 455, 1, 3, 9999.99m, false, null, 12.58m, 9, 5000.00m },
                    { 456, 1, 3, 19999.99m, false, null, 11.61m, 9, 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 457, 1, 3, 39999.99m, false, null, 9.67m, 9, 20000.00m },
                    { 458, 1, 3, 74999.99m, false, null, 8.71m, 9, 40000.00m },
                    { 459, 1, 3, 99999.99m, false, null, 8.13m, 9, 75000.00m },
                    { 460, 1, 3, 149999.99m, false, null, 7.74m, 9, 100000.00m },
                    { 461, 1, 3, 249999.99m, false, null, 5.8m, 9, 150000.00m },
                    { 462, 1, 3, 499999.99m, false, null, 4.84m, 9, 250000.00m },
                    { 463, 1, 3, 999999.99m, false, null, 4.26m, 9, 500000.00m },
                    { 464, 1, 3, 99999999.99m, false, null, 3.87m, 9, 1000000.00m },
                    { 465, 1, 3, 49.99m, false, null, 69.66m, 10, 0.00m },
                    { 466, 1, 3, 199.99m, false, null, 43.54m, 10, 50.00m },
                    { 467, 1, 3, 499.99m, false, null, 35.22m, 10, 200.00m },
                    { 468, 1, 3, 999.99m, false, null, 26.12m, 10, 500.00m },
                    { 469, 1, 3, 2499.99m, false, null, 21.67m, 10, 1000.00m },
                    { 470, 1, 3, 4999.99m, false, null, 19.64m, 10, 2500.00m },
                    { 471, 1, 3, 9999.99m, false, null, 18.87m, 10, 5000.00m },
                    { 472, 1, 3, 19999.99m, false, null, 17.99m, 10, 10000.00m },
                    { 473, 1, 3, 39999.99m, false, null, 15.48m, 10, 20000.00m },
                    { 474, 1, 3, 74999.99m, false, null, 14.37m, 10, 40000.00m },
                    { 475, 1, 3, 99999.99m, false, null, 13.82m, 10, 75000.00m },
                    { 476, 1, 3, 149999.99m, false, null, 13.54m, 10, 100000.00m },
                    { 477, 1, 3, 249999.99m, false, null, 10.45m, 10, 150000.00m },
                    { 478, 1, 3, 499999.99m, false, null, 8.05m, 10, 250000.00m },
                    { 479, 1, 3, 999999.99m, false, null, 8.09m, 10, 500000.00m },
                    { 480, 1, 3, 99999999.99m, false, null, 7.55m, 10, 1000000.00m }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "SegmentOrans",
                keyColumn: "ID",
                keyValue: 480);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate" },
                values: new object[] { "b6800f5f-81c1-46a5-8669-02147aa629bc", new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6226), new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2032, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6238), new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "ModifiedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a231329-7598-4875-a4d5-980ac6d1b6a8", new DateTime(2022, 5, 16, 17, 57, 50, 135, DateTimeKind.Local).AddTicks(1737), new DateTime(2022, 5, 16, 17, 57, 50, 135, DateTimeKind.Local).AddTicks(1751), "AQAAAAEAACcQAAAAEIFt9dPS/wmumJmVpjdV0+tCJSsH82H52EIhx3+0nSWv/5HRjWC0rRAF9v0e3uRFDQ==", "904ad62a-190e-48b0-ab96-6aa5bd9140ca" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 16, 17, 57, 50, 136, DateTimeKind.Local).AddTicks(6422));
        }
    }
}
