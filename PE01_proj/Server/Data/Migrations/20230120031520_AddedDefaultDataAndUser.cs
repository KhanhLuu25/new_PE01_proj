using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE01_proj.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Devices_DevicesId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrdersId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staffs_StaffsId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrdersId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeDevs_Devices_DevicesId",
                table: "TradeDevs");

            migrationBuilder.DropForeignKey(
                name: "FK_Trades_Staffs_StaffsId",
                table: "Trades");

            migrationBuilder.DropIndex(
                name: "IX_Trades_StaffsId",
                table: "Trades");

            migrationBuilder.DropIndex(
                name: "IX_TradeDevs_DevicesId",
                table: "TradeDevs");

            migrationBuilder.DropIndex(
                name: "IX_Payments_OrdersId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StaffsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_DevicesId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrdersId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "Trades");

            migrationBuilder.DropColumn(
                name: "DevicesId",
                table: "TradeDevs");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DevicesId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "OrderItems");

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DevCost", "DevDesc", "DevName", "DevType", "DeviceID", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2023, 1, 20, 11, 15, 19, 849, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 1, 20, 11, 15, 19, 853, DateTimeKind.Local).AddTicks(4842), "$1688", "256GB", "iPhone 13 Pro Max", "Phone", 0, "System" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DevCost", "DevDesc", "DevName", "DevType", "DeviceID", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2023, 1, 20, 11, 15, 19, 853, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 1, 20, 11, 15, 19, 853, DateTimeKind.Local).AddTicks(6543), "$1255", "512GB", "Samsung Galaxy Flip 4", "Phone", 0, "System" });

            migrationBuilder.CreateIndex(
                name: "IX_Trades_StaffID",
                table: "Trades",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_TradeDevs_DeviceID",
                table: "TradeDevs",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderID",
                table: "Payments",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StaffID",
                table: "Orders",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DeviceID",
                table: "OrderItems",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Devices_DeviceID",
                table: "OrderItems",
                column: "DeviceID",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staffs_StaffID",
                table: "Orders",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrderID",
                table: "Payments",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeDevs_Devices_DeviceID",
                table: "TradeDevs",
                column: "DeviceID",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_Staffs_StaffID",
                table: "Trades",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Devices_DeviceID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staffs_StaffID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrderID",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeDevs_Devices_DeviceID",
                table: "TradeDevs");

            migrationBuilder.DropForeignKey(
                name: "FK_Trades_Staffs_StaffID",
                table: "Trades");

            migrationBuilder.DropIndex(
                name: "IX_Trades_StaffID",
                table: "Trades");

            migrationBuilder.DropIndex(
                name: "IX_TradeDevs_DeviceID",
                table: "TradeDevs");

            migrationBuilder.DropIndex(
                name: "IX_Payments_OrderID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StaffID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_DeviceID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "Trades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicesId",
                table: "TradeDevs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicesId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trades_StaffsId",
                table: "Trades",
                column: "StaffsId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeDevs_DevicesId",
                table: "TradeDevs",
                column: "DevicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrdersId",
                table: "Payments",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StaffsId",
                table: "Orders",
                column: "StaffsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DevicesId",
                table: "OrderItems",
                column: "DevicesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrdersId",
                table: "OrderItems",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Devices_DevicesId",
                table: "OrderItems",
                column: "DevicesId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrdersId",
                table: "OrderItems",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staffs_StaffsId",
                table: "Orders",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrdersId",
                table: "Payments",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeDevs_Devices_DevicesId",
                table: "TradeDevs",
                column: "DevicesId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_Staffs_StaffsId",
                table: "Trades",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
