using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class ItemPurchaseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPurchase_Items_ItemId",
                table: "ItemPurchase");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPurchase_Purchases_PurchaseID",
                table: "ItemPurchase");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPurchase_Types_TypeId",
                table: "ItemPurchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPurchase",
                table: "ItemPurchase");

            migrationBuilder.RenameTable(
                name: "ItemPurchase",
                newName: "ItemPurchases");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPurchase_TypeId",
                table: "ItemPurchases",
                newName: "IX_ItemPurchases_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPurchase_PurchaseID",
                table: "ItemPurchases",
                newName: "IX_ItemPurchases_PurchaseID");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPurchase_ItemId",
                table: "ItemPurchases",
                newName: "IX_ItemPurchases_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPurchases",
                table: "ItemPurchases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPurchases_Items_ItemId",
                table: "ItemPurchases",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPurchases_Purchases_PurchaseID",
                table: "ItemPurchases",
                column: "PurchaseID",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPurchases_Types_TypeId",
                table: "ItemPurchases",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPurchases_Items_ItemId",
                table: "ItemPurchases");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPurchases_Purchases_PurchaseID",
                table: "ItemPurchases");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPurchases_Types_TypeId",
                table: "ItemPurchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPurchases",
                table: "ItemPurchases");

            migrationBuilder.RenameTable(
                name: "ItemPurchases",
                newName: "ItemPurchase");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPurchases_TypeId",
                table: "ItemPurchase",
                newName: "IX_ItemPurchase_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPurchases_PurchaseID",
                table: "ItemPurchase",
                newName: "IX_ItemPurchase_PurchaseID");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPurchases_ItemId",
                table: "ItemPurchase",
                newName: "IX_ItemPurchase_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPurchase",
                table: "ItemPurchase",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPurchase_Items_ItemId",
                table: "ItemPurchase",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPurchase_Purchases_PurchaseID",
                table: "ItemPurchase",
                column: "PurchaseID",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPurchase_Types_TypeId",
                table: "ItemPurchase",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
