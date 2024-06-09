using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class RelationsInEmployeePurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Purchases_EmployeeId",
                table: "Purchases",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Users_EmployeeId",
                table: "Purchases",
                column: "EmployeeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Users_EmployeeId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_EmployeeId",
                table: "Purchases");
        }
    }
}
