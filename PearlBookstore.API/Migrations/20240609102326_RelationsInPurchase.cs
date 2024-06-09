using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class RelationsInPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ItemId",
                table: "Purchases",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Items_ItemId",
                table: "Purchases",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Items_ItemId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_ItemId",
                table: "Purchases");
        }
    }
}
