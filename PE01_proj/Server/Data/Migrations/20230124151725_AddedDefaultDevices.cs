using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE01_proj.Server.Data.Migrations
{
    public partial class AddedDefaultDevices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "StaffAddress", "StaffID", "StaffName", "StaffPosition", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5864), "Blk 53 Marsiling Road", 0, "John Tan", "Manager", "System" },
                    { 2, "System", new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 1, 24, 23, 17, 22, 832, DateTimeKind.Local).AddTicks(5876), "Blk 143 Bedok North", 0, "Mei Yan", "Sale Associate", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 20, 11, 15, 19, 849, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 1, 20, 11, 15, 19, 853, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 20, 11, 15, 19, 853, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 1, 20, 11, 15, 19, 853, DateTimeKind.Local).AddTicks(6543) });
        }
    }
}
