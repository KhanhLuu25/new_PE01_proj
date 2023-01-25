using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE01_proj.Server.Data.Migrations
{
    public partial class AddedDefaultCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedBy", "CustAddress", "CustContactNo", "CustEmail", "CustID", "CustName", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "Blk 91 Ang Mo Kio Ave 3", "98765788", "jeromeyufei54@gmail.com", 0, "Jerome Ng ", new DateTime(2023, 1, 24, 23, 40, 59, 526, DateTimeKind.Local).AddTicks(260), new DateTime(2023, 1, 24, 23, 40, 59, 526, DateTimeKind.Local).AddTicks(296), "System" },
                    { 2, "System", "Blk 92 Potong Pasir Ave 1", "98997654", "jescrenachan77@yahoo.com", 0, "Jescrena Chan Yu Ying ", new DateTime(2023, 1, 24, 23, 40, 59, 526, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 1, 24, 23, 40, 59, 526, DateTimeKind.Local).AddTicks(310), "System" }
                });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 40, 59, 477, DateTimeKind.Local).AddTicks(4511), new DateTime(2023, 1, 24, 23, 40, 59, 520, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 40, 59, 521, DateTimeKind.Local).AddTicks(1972), new DateTime(2023, 1, 24, 23, 40, 59, 521, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 40, 59, 525, DateTimeKind.Local).AddTicks(940), new DateTime(2023, 1, 24, 23, 40, 59, 525, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 40, 59, 525, DateTimeKind.Local).AddTicks(1002), new DateTime(2023, 1, 24, 23, 40, 59, 525, DateTimeKind.Local).AddTicks(1005) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 17, 22, 826, DateTimeKind.Local).AddTicks(848), new DateTime(2023, 1, 24, 23, 17, 22, 829, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 17, 22, 829, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 1, 24, 23, 17, 22, 829, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5876) });
        }
    }
}
