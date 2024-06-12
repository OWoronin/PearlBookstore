using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Items_ItemId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Types_TypeId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_ItemId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_TypeId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Counter",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Purchases",
                newName: "PurchaseID");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Purchases",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ItemPurchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    PurchaseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPurchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPurchase_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPurchase_Purchases_PurchaseID",
                        column: x => x.PurchaseID,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPurchase_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPurchase_ItemId",
                table: "ItemPurchase",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPurchase_PurchaseID",
                table: "ItemPurchase",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPurchase_TypeId",
                table: "ItemPurchase",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPurchase");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "PurchaseID",
                table: "Purchases",
                newName: "PaymentId");

            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ItemId",
                table: "Purchases",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_TypeId",
                table: "Purchases",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Items_ItemId",
                table: "Purchases",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Types_TypeId",
                table: "Purchases",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
