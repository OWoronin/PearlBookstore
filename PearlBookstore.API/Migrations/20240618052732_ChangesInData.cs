using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Counter",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 0, 35.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 0, 2, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Counter",
                value: 23);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AuthorId", "Description", "Title", "YearPublication" },
                values: new object[] { 3, 1, "Książka autorstwa: Wisława Szymborska o tytule: Map wydana w roku: 2015", "Map", 2015 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Counter",
                value: 66);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 63, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 93, 3, 31.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Counter",
                value: 47);

            migrationBuilder.InsertData(
                table: "ItemsGenres",
                columns: new[] { "Id", "GenreId", "ItemId" },
                values: new object[] { 3, 6, 3 });
        }
    }
}
