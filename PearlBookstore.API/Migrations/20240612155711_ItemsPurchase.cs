using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class ItemsPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersItems_Orders_OrderId",
                table: "OrdersItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersItems",
                table: "OrdersItems");

            migrationBuilder.DropColumn(
                name: "Counter",
                table: "Returns");

            migrationBuilder.RenameTable(
                name: "OrdersItems",
                newName: "ItemsOrder");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Returns",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Returns",
                newName: "TotalReturn");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Returns",
                newName: "PurchaseID");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersItems_OrderId",
                table: "ItemsOrder",
                newName: "IX_ItemsOrder_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsOrder",
                table: "ItemsOrder",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ItemReturns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    ReturnID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemReturns_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemReturns_Returns_ReturnID",
                        column: x => x.ReturnID,
                        principalTable: "Returns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemReturns_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_EmployeeID",
                table: "Returns",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_PurchaseID",
                table: "Returns",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReturns_ItemId",
                table: "ItemReturns",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReturns_ReturnID",
                table: "ItemReturns",
                column: "ReturnID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReturns_TypeId",
                table: "ItemReturns",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsOrder_Orders_OrderId",
                table: "ItemsOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Returns_Purchases_PurchaseID",
                table: "Returns",
                column: "PurchaseID",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Returns_Users_EmployeeID",
                table: "Returns",
                column: "EmployeeID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsOrder_Orders_OrderId",
                table: "ItemsOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Returns_Purchases_PurchaseID",
                table: "Returns");

            migrationBuilder.DropForeignKey(
                name: "FK_Returns_Users_EmployeeID",
                table: "Returns");

            migrationBuilder.DropTable(
                name: "ItemReturns");

            migrationBuilder.DropIndex(
                name: "IX_Returns_EmployeeID",
                table: "Returns");

            migrationBuilder.DropIndex(
                name: "IX_Returns_PurchaseID",
                table: "Returns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsOrder",
                table: "ItemsOrder");

            migrationBuilder.RenameTable(
                name: "ItemsOrder",
                newName: "OrdersItems");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Returns",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "TotalReturn",
                table: "Returns",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "PurchaseID",
                table: "Returns",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsOrder_OrderId",
                table: "OrdersItems",
                newName: "IX_OrdersItems_OrderId");

            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "Returns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersItems",
                table: "OrdersItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersItems_Orders_OrderId",
                table: "OrdersItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
