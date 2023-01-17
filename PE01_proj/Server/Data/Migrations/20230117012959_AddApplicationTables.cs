using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE01_proj.Server.Data.Migrations
{
    public partial class AddApplicationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustID = table.Column<int>(type: "int", nullable: false),
                    CustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceID = table.Column<int>(type: "int", nullable: false),
                    DevName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeDevs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeDevID = table.Column<int>(type: "int", nullable: false),
                    TradeDevType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeDecPrice = table.Column<int>(type: "int", nullable: false),
                    DeviceID = table.Column<int>(type: "int", nullable: false),
                    DevicesId = table.Column<int>(type: "int", nullable: true),
                    CustID = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeDevs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TradeDevs_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TradeDevs_Devices_DevicesId",
                        column: x => x.DevicesId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    OrdDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    Orderquantity = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    StaffsId = table.Column<int>(type: "int", nullable: true),
                    CustID = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Staffs_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeID = table.Column<int>(type: "int", nullable: false),
                    TradeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalTradeAmount = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    StaffsId = table.Column<int>(type: "int", nullable: true),
                    CustID = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trades_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trades_Staffs_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemID = table.Column<int>(type: "int", nullable: false),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: true),
                    DeviceID = table.Column<int>(type: "int", nullable: false),
                    DevicesId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Devices_DevicesId",
                        column: x => x.DevicesId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentID = table.Column<int>(type: "int", nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNo = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DevicesId",
                table: "OrderItems",
                column: "DevicesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrdersId",
                table: "OrderItems",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersId",
                table: "Orders",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StaffsId",
                table: "Orders",
                column: "StaffsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrdersId",
                table: "Payments",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeDevs_CustomersId",
                table: "TradeDevs",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeDevs_DevicesId",
                table: "TradeDevs",
                column: "DevicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Trades_CustomersId",
                table: "Trades",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Trades_StaffsId",
                table: "Trades",
                column: "StaffsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "TradeDevs");

            migrationBuilder.DropTable(
                name: "Trades");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
