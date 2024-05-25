using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Storages");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Items",
                newName: "StorageID");

            migrationBuilder.CreateTable(
                name: "GenreItem",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreItem", x => new { x.GenreId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_GenreItem_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => new { x.ItemsId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_ItemType_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemType_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsTypes_ItemId",
                table: "ItemsTypes",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsTypes_TypeId",
                table: "ItemsTypes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsGenres_GenreId",
                table: "ItemsGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsGenres_ItemId",
                table: "ItemsGenres",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AuthorId",
                table: "Items",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_StorageID",
                table: "Items",
                column: "StorageID");

            migrationBuilder.CreateIndex(
                name: "IX_GenreItem_ItemsId",
                table: "GenreItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemType_TypeId",
                table: "ItemType",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Authors_AuthorId",
                table: "Items",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Storages_StorageID",
                table: "Items",
                column: "StorageID",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsGenres_Genres_GenreId",
                table: "ItemsGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsGenres_Items_ItemId",
                table: "ItemsGenres",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsTypes_Items_ItemId",
                table: "ItemsTypes",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsTypes_Types_TypeId",
                table: "ItemsTypes",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Authors_AuthorId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Storages_StorageID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsGenres_Genres_GenreId",
                table: "ItemsGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsGenres_Items_ItemId",
                table: "ItemsGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsTypes_Items_ItemId",
                table: "ItemsTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsTypes_Types_TypeId",
                table: "ItemsTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "GenreItem");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ItemsTypes_ItemId",
                table: "ItemsTypes");

            migrationBuilder.DropIndex(
                name: "IX_ItemsTypes_TypeId",
                table: "ItemsTypes");

            migrationBuilder.DropIndex(
                name: "IX_ItemsGenres_GenreId",
                table: "ItemsGenres");

            migrationBuilder.DropIndex(
                name: "IX_ItemsGenres_ItemId",
                table: "ItemsGenres");

            migrationBuilder.DropIndex(
                name: "IX_Items_AuthorId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_StorageID",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "StorageID",
                table: "Items",
                newName: "TypeId");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Storages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
