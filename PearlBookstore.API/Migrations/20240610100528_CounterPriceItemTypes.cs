using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class CounterPriceItemTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Counter",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "ItemsTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ItemsTypes",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 11, 45.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 71, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 1, 28.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 1, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 66, 41.99m, 1 });

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
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 93, 31.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 47, 4, 39.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 37, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 5, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 94, 32.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 5, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 64, 5, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 6, 29.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 55, 7, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 59, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 19, 22.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Counter", "Price", "TypeId" },
                values: new object[] { 37, 39.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 9, 29.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 9, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 57, 10, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 35, 10, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 50, 10, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 10, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 14, 11, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 11, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 35, 12, 41.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 15, 12, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 79, 12, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 13, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 13, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 13, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 83, 14, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 39, 14, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 14, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 64, 15, 22.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 35, 16, 34.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 11, 16, 30.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 16, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 48, 17, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 80, 17, 31.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 17, 27.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 17, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 81, 18, 25.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 51, 19, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 19, 39.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 87, 19, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 14, 19, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 63, 20, 33.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 63, 20, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 20, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 21, 45.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 60, 21, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 21, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 51, 22, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 59, 23, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 28, 24, 40.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 78, 24, 33.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 74, 24, 28.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 25, 24, 21.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 25, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 69, 25, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 53, 26, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 26, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 27, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 27, 37.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 96, 27, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 25, 27, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 28, 28, 44.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 84, 29, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 20, 29, 29.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 10, 29, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 49, 30, 38.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 21, 30, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 96, 30, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 31, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 42, 32, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 14, 32, 36.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 63, 32, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 12, 33, 29.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 34, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 34, 32.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 98, 34, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 52, 35, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 36, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 62, 36, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 37, 38.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 34, 37, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 37, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 38, 32.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 38, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 45, 39, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 75, 39, 31.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 11, 39, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 84, 39, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 29, 40, 43.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 12, 40, 36.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 99, 40, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 40, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 47, 41, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 97, 41, 35.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 41, 30.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 90, 41, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 49, 42, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 23, 42, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 43, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 43, 30.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 37, 43, 29.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 43, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 44, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 64, 44, 35.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 96, 44, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 44, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 33, 45, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 45, 39.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 42, 45, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 17, 46, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 71, 46, 21.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 49, 47, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 60, 47, 21.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 34, 48, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 45, 48, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 65, 48, 27.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 78, 49, 34.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 45, 49, 31.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 52, 50, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 52, 50, 35.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 57, 50, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 90, 50, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 59, 51, 36.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 52, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 12, 52, 24.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 36, 53, 44.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 19, 53, 34.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 96, 53, 26.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 18, 53, 20.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 29, 54, 45.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 91, 54, 34.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 15, 54, 29.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 81, 54, 24.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 77, 55, 45.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 83, 55, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 98, 56, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 56, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 10, 57, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 16, 57, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 58, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 58, 33.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 34, 58, 29.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 58, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 59, 35.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 34, 59, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 15, 60, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 60, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 61, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 68, 61, 38.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 72, 61, 32.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 24, 62, 43.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 62, 37.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 63, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 87, 63, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 64, 29.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 40, 65, 31.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 64, 65, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 66, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 63, 66, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 21, 67, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 25, 67, 39.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 65, 67, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 67, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 53, 68, 40.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 36, 68, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 10, 69, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 49, 69, 38.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 69, 29.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 15, 69, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 23, 70, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 51, 70, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 17, 70, 28.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 70, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 50, 71, 44.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 52, 71, 34.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 15, 71, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 72, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 73, 45.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 74, 74, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 30, 74, 32.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 56, 74, 28.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 14, 74, 23.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 29, 75, 43.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 14, 75, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 45, 75, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 75, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 36, 76, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 76, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 76, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 71, 77, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 97, 77, 36.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 83, 77, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 78, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 11, 78, 36.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 80, 78, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 74, 78, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 79, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 12, 80, 44.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 57, 80, 37.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 80, 28.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 12, 80, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 81, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 36, 82, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 97, 83, 44.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 83, 30.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 47, 84, 43.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 44, 84, 39.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 20, 84, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 54, 84, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 40, 85, 44.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 70, 85, 33.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 85, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 27, 86, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 24, 86, 27.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 86, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 57, 87, 37.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 20, 87, 31.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 96, 87, 20.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 74, 88, 42.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 61, 88, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 87, 89, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 72, 89, 31.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 67, 89, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 54, 89, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 25, 90, 40.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 73, 91, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 97, 92, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 97, 92, 24.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 93, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 28, 93, 27.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 93, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 94, 45.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 42, 94, 26.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 77, 94, 21.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 23, 95, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 34, 96, 28.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 97, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 75, 97, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 21, 98, 45.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 80, 98, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 57, 98, 31.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 39, 98, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 94, 99, 42.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 88, 99, 33.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 45, 99, 26.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 33, 99, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 16, 100, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 39, 100, 29.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 35, 101, 44.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 33, 101, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 98, 101, 31.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 61, 102, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 102, 32.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 102, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 102, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 77, 103, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 34, 104, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 14, 105, 42.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 51, 105, 32.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 106, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 40, 106, 29.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 13, 106, 24.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 88, 107, 41.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 107, 38.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 44, 107, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 87, 107, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 69, 108, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 24, 108, 30.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 45, 108, 28.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 108, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 64, 109, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 89, 109, 35.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 11, 109, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 92, 109, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 12, 110, 34.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 27, 111, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 111, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 111, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 40, 111, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 112, 45.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 33, 112, 38.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 112, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 92, 112, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 80, 113, 34.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 113, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 72, 114, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 89, 114, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 14, 114, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 79, 115, 33.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 57, 115, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 64, 115, 24.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 96, 116, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 117, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 69, 117, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 47, 118, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 17, 118, 36.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 118, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 99, 118, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 119, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 80, 119, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 61, 119, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 75, 119, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 120, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 121, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 54, 121, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 85, 121, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 122, 31.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 72, 123, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 123, 37.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 124, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 16, 124, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 48, 125, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 71, 126, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 61, 126, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 127, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 48, 127, 30.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 62, 127, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 127, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 128, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 128, 32.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 85, 128, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 128, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 59, 129, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 130, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 130, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 88, 130, 24.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 23, 131, 43.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 13, 131, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 54, 131, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 132, 37.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 30, 132, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 20, 132, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 88, 133, 29.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 133, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 134, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 134, 37.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 134, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 92, 134, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 27, 135, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 38, 135, 25.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 35, 136, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 136, 33.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 136, 29.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 136, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 83, 137, 36.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 68, 138, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 55, 138, 35.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 138, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 37, 139, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 71, 139, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 139, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 16, 139, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 25, 140, 38.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 140, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 65, 141, 36.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 142, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 83, 143, 36.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 45, 144, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 44, 144, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 144, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 81, 145, 42.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 23, 145, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 65, 146, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 92, 146, 38.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 146, 28.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 57, 146, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 18, 147, 29.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 71, 147, 23.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 90, 148, 34.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 39, 148, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 46, 149, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 19, 149, 21.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 90, 150, 43.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 64, 151, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 65, 151, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 54, 151, 27.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 66, 151, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 32, 152, 42.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 65, 152, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 49, 152, 28.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 77, 153, 44.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 80, 153, 37.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 39, 153, 25.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 41, 153, 21.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 154, 32.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 154, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 90, 155, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 155, 38.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 155, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 64, 155, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 97, 156, 43.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 98, 156, 29.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 157, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 157, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 46, 157, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 48, 157, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 158, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 90, 158, 27.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 158, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 42, 159, 28.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 91, 160, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 160, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 19, 160, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 160, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 161, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 161, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 162, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 30, 162, 36.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 88, 162, 31.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 61, 162, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 56, 163, 31.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 53, 163, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 83, 164, 40.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 30, 164, 28.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 164, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 59, 165, 39.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 30, 165, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 165, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 72, 166, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 167, 32.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 30, 167, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 69, 168, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 169, 30.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 43, 170, 41.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 170, 30.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 170, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 70, 170, 24.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 15, 171, 42.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 60, 171, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 79, 171, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 65, 172, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 33, 172, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 25, 172, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 173, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 99, 173, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 47, 174, 43.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 27, 174, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 18, 174, 22.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 34, 175, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 79, 175, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 175, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 73, 175, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 62, 176, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 63, 176, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 36, 177, 36.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 42, 177, 31.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 99, 177, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 18, 178, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 34, 179, 44.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 80, 179, 37.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 74, 179, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 77, 179, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 83, 180, 34.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 44, 180, 29.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 181, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 52, 182, 45.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 49, 182, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 32, 182, 24.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 54, 183, 43.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 14, 183, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 77, 183, 28.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 31, 183, 22.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 31, 184, 42.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 184, 36.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 35, 184, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 10, 184, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 18, 185, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 185, 32.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 39, 185, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 186, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 94, 186, 25.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 83, 186, 23.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 38, 187, 39.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 187, 29.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 187, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 35, 188, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 188, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 62, 188, 22.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 55, 189, 36.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 89, 189, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 63, 189, 23.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 88, 190, 41.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 91, 191, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 191, 32.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 79, 191, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 191, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 192, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 77, 192, 21.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 42, 193, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 89, 193, 30.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 59, 193, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 19, 194, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 55, 195, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 196, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 87, 197, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 95, 197, 27.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 197, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 198, 37.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 198, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 18, 198, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 84, 199, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 64, 200, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 18, 200, 30.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 55, 200, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 200, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 97, 201, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 201, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 45, 201, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 55, 202, 45.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 67, 202, 33.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 27, 202, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 36, 202, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 15, 203, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 12, 203, 30.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 84, 204, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 204, 35.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 204, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 15, 204, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 73, 205, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 85, 205, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 205, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 37, 205, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 67, 206, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 18, 206, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 97, 206, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 69, 207, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 14, 207, 31.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 10, 207, 31.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 89, 208, 41.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 98, 208, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 78, 208, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 76, 208, 24.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 43, 209, 40.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 93, 210, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 210, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 60, 211, 32.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 45, 212, 37.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 213, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 89, 214, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 35, 215, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 63, 215, 38.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 91, 215, 28.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 79, 216, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 79, 216, 35.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 91, 216, 27.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 65, 216, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 37, 217, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 43, 217, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 79, 218, 43.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 87, 218, 39.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 71, 218, 28.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 99, 218, 24.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 219, 31.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 219, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 46, 220, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 33, 221, 42.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 56, 221, 38.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 96, 221, 21.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 47, 222, 33.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 99, 222, 23.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 223, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 223, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 90, 223, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 80, 223, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 92, 224, 44.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 53, 224, 35.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 62, 224, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 16, 224, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 225, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 33, 225, 39.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 57, 225, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 51, 225, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 95, 226, 29.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 227, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 227, 34.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 97, 227, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 70, 227, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 64, 228, 45.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 33, 228, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 38, 228, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 23, 228, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 62, 229, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 27, 229, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 229, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 230, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 231, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 98, 231, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 22, 231, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 232, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 83, 232, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 30, 233, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 23, 233, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 96, 234, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 234, 38.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 30, 235, 20.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 52, 236, 41.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 98, 237, 33.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 237, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 237, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 238, 20.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 30, 239, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 23, 239, 28.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 239, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 240, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 240, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 20, 241, 31.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 38, 242, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 32, 243, 30.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 82, 243, 25.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 243, 24.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 29, 244, 31.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 244, 32.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 90, 245, 44.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 80, 245, 39.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 245, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 46, 246, 33.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 27, 246, 28.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 76, 246, 20.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 93, 247, 35.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 91, 247, 28.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 42, 248, 43.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 45, 248, 33.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 96, 248, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 84, 248, 22.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 15, 249, 40.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 72, 249, 31.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 87, 249, 30.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 71, 249, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 70, 250, 36.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 65, 250, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 251, 39.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 251, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 97, 252, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 35, 252, 25.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 48, 252, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 58, 253, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 23, 253, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 44, 254, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 14, 255, 45.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 42, 255, 34.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 83, 256, 24.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 257, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 21, 258, 32.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 17, 259, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 37, 259, 33.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 27, 259, 27.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 27, 259, 22.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 70, 260, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 24, 260, 36.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 75, 260, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 93, 261, 42.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 39, 261, 39.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 53, 261, 23.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 56, 262, 42.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 73, 262, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 15, 263, 41.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 63, 263, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 22, 263, 27.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 11, 263, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 67, 264, 23.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 10, 265, 37.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 23, 265, 30.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 16, 265, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 80, 266, 32.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 81, 267, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 54, 267, 33.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 45, 267, 26.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 14, 268, 36.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 46, 268, 22.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 10, 269, 40.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 69, 269, 35.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 53, 269, 25.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 41, 269, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 270, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 76, 270, 33.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 10, 270, 28.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 63, 270, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 28, 271, 43.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 44, 271, 37.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 68, 271, 30.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 49, 271, 22.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 86, 272, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 81, 272, 37.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 79, 272, 22.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 40, 273, 41.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 86, 273, 38.49m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 273, 29.49m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 66, 273, 20.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 43, 274, 43.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 63, 274, 31.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 94, 274, 30.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 51, 274, 24.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 13, 275, 31.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 276, 40.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 276, 32.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 78, 277, 40.99m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 82, 277, 24.99m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 31, 278, 39.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 13, 279, 43.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 88, 280, 44.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 75, 280, 32.99m, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 75, 281, 42.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 91, 281, 33.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 12, 281, 32.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 58, 281, 24.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 17, 282, 33.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 70, 282, 29.49m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 84, 283, 26.99m, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 20, 283, 21.49m, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 50, 284, 42.49m, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Counter", "ItemId", "Price" },
                values: new object[] { 29, 284, 33.99m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Counter", "ItemId", "Price", "TypeId" },
                values: new object[] { 19, 285, 31.49m, 2 });

            migrationBuilder.InsertData(
                table: "ItemsTypes",
                columns: new[] { "Id", "Counter", "ItemId", "Price", "TypeId" },
                values: new object[,]
                {
                    { 720, 80, 286, 34.99m, 2 },
                    { 721, 26, 286, 23.99m, 4 },
                    { 722, 88, 287, 43.99m, 1 },
                    { 723, 46, 287, 30.99m, 2 },
                    { 724, 55, 287, 29.99m, 3 },
                    { 725, 72, 287, 24.99m, 4 },
                    { 726, 37, 288, 26.99m, 3 },
                    { 727, 73, 289, 44.49m, 1 },
                    { 728, 83, 289, 37.49m, 2 },
                    { 729, 70, 289, 29.99m, 3 },
                    { 730, 13, 290, 44.99m, 1 },
                    { 731, 62, 290, 35.49m, 2 },
                    { 732, 82, 290, 32.99m, 3 },
                    { 733, 91, 291, 23.49m, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_TypeId",
                table: "Purchases",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Types_TypeId",
                table: "Purchases",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Types_TypeId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_TypeId",
                table: "Purchases");

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Counter",
                table: "ItemsTypes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ItemsTypes");

            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 37, 16.3m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 31.41m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 30, 40.15m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 10.0m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 29.17m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 25.77m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 22.73m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 46.85m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 34.46m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 34.92m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 45, 47.72m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 37.69m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 12.10m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 40.49m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 19, 33.1m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 10.4m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 31, 31.89m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 41, 38.52m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 47, 42.98m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 31.88m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 14.56m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 23, 46.61m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 48.54m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 21, 20.82m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 16.83m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 30, 22.37m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 41, 48.94m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 12.59m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 26, 47.90m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 27, 45.24m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 28.58m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 22, 24.23m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 19.64m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 42.53m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 17.23m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 15, 37.2m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 15, 42.31m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 31.98m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 23.15m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 18.25m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 15, 31.2m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 32, 25.6m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 21, 35.65m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 35.82m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 43.49m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 10.70m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 32, 38.60m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 21.94m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 15.12m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 34, 26.24m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 19.82m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 18.43m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 42.19m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 22, 25.82m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 40.49m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 25.18m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 18.29m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 23, 42.53m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 40, 17.31m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 31, 20.28m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 13, 17.81m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 10, 17.78m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 23, 42.51m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 41.97m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 12, 16.28m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 13.34m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 37, 45.88m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 14.81m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 24.24m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 34, 40.42m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 14, 22.78m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 17.85m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 14.13m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 39.63m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 10, 29.41m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 37, 21.39m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 29, 17.32m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 36.56m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 28.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 37.53m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 15, 25.51m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 15, 45.21m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 49, 44.66m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 40, 31.60m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 40.75m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 21, 34.75m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 34, 42.19m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 23, 19.51m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 27.51m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 15, 16.4m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 18.91m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 47, 10.84m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 24.25m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 40, 35.32m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 31.86m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 26, 36.6m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 49.70m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 15.94m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 28.91m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 38.48m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 48.89m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 21.14m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 30.37m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 19.57m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 12.97m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 10.28m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 17.69m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 10.12m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 29.54m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 14.40m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 47.1m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 32.98m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 11.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 44.82m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 26.83m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 42.91m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 11, 30.38m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 44.87m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 41, 42.23m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 33.82m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 49, 11.47m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 21.79m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 48.24m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 25.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 41.42m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 26, 20.68m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 29, 27.91m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 22.11m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 27, 47.19m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 41, 48.94m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 30, 32.21m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 19, 16.66m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 27.93m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 31.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 11.23m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 31, 23.14m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 10, 14.76m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 31, 12.58m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 30, 47.9m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 13, 40.60m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 13, 17.90m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 21, 38.31m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 31.20m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 41.30m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 18.81m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 32, 12.91m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 27, 44.38m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 27.54m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 25.30m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 11, 35.83m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 31, 29.92m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 14, 26.25m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 34, 19.13m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 20.39m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 36, 32.67m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 27.23m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 32, 23.12m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 19, 46.23m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 12.42m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 39.73m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 12.76m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 33.47m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 12, 11.4m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 23.84m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 16.58m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 26.77m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 17.88m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 47.28m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 31.91m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 43, 25.24m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 23, 15.31m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 33.92m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 45.30m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 12.9m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 21.87m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 13, 49.41m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 25.4m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 36, 18.1m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 30, 41.1m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 41.84m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 47, 24.73m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 41, 30.97m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 39, 27.16m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 27, 21.33m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 47, 24.96m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 45, 47.44m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 43.3m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 25, 11.98m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 15, 23.93m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 14, 47.18m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 41.49m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 45, 28.68m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 39.53m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 29, 32.58m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 49, 21.67m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 36, 19.38m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 40.45m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 14.22m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 40, 28.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 43, 45.96m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 28.10m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 12, 43.92m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 49.70m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 14, 42.74m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 13.16m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 32, 49.44m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 29.87m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 34, 15.22m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 24.74m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 41, 11.3m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 24.7m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 36, 32.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 22.89m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 32.85m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 34.42m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 49.25m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 41.40m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 41.77m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 41, 13.77m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 47, 41.81m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 31.94m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 14, 19.37m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 26.54m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 10, 16.49m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 11, 26.66m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 27.92m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 43.16m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 19, 34.11m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 44, 34.31m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 27, 25.63m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 19.43m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 45, 45.47m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 19.83m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 21.7m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 22, 18.41m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 18.3m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 38, 16.11m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 47, 18.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 28.93m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 47, 34.33m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 27, 19.6m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 43.41m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 16.1m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 37, 10.79m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 30, 38.59m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 40, 42.61m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 28.31m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 31.89m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 37, 39.90m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 50, 17.20m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 37, 41.45m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 14, 17.32m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 35, 18.16m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 19, 45.30m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 31, 21.34m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 29.17m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 42.76m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 43, 49.22m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 21, 39.15m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 10, 41.24m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 25.89m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 16, 24.70m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 42, 30.62m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 41.37m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 43.22m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 21, 40.55m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 40.62m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 17, 27.3m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 22, 20.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 45.21m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 49.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 24, 15.28m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 40, 32.78m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 20, 22.67m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 33, 48.7m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 22, 16.83m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 26, 45.85m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 29, 19.56m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 19, 42.14m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 30, 10.33m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 46, 27.9m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 18, 27.97m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 27, 33.98m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 34, 20.81m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 23, 38.77m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 36, 15.35m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 29, 31.80m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 29, 31.90m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 48, 43.81m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 14, 30.36m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Counter", "Price" },
                values: new object[] { 28, 35.16m });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ItemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ItemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 11, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ItemId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 13, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ItemId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ItemId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 14, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 16, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 17, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 17, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 17, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 18, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 18, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "ItemId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 19, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 19, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 19, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 20, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "ItemId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 21, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 23, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 23, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 25, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 25, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 25, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 27, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 27, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 57,
                column: "ItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 58,
                column: "ItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 59,
                column: "ItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 60,
                column: "ItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 62,
                column: "ItemId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 29, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 30, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 30, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 31, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 31, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 69,
                column: "ItemId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 32, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 33, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 33, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 33, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 34, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 36, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 37, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 37, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 37, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 38, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 39, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 86,
                column: "ItemId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 39, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 40, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 40, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 40, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 41, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 41, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 41, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 41, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 42, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 96,
                column: "ItemId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 97,
                column: "ItemId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 98,
                column: "ItemId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 44, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 44, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 44, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 44, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 45, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 45, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 46, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 46, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 46, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 47, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 48, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 48, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 49, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 50, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 50, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 50, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 51, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 51, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 117,
                column: "ItemId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 118,
                column: "ItemId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 52, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 120,
                column: "ItemId",
                value: 52);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 53, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 122,
                column: "ItemId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 55, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 124,
                column: "ItemId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 125,
                column: "ItemId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 55, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 56, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 56, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 56, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 57, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 57, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 132,
                column: "ItemId",
                value: 57);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 133,
                column: "ItemId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 134,
                column: "ItemId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 135,
                column: "ItemId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 136,
                column: "ItemId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 137,
                column: "ItemId",
                value: 59);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 138,
                column: "ItemId",
                value: 59);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 139,
                column: "ItemId",
                value: 60);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 140,
                column: "ItemId",
                value: 60);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 141,
                column: "ItemId",
                value: 61);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 61, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 61, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 62, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 62, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 62, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 63, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 64, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 149,
                column: "ItemId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 65, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 66, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 66, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 66, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 67, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 67, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 67, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 67, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 158,
                column: "ItemId",
                value: 68);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 68, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 69, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 70, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 70, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 163,
                column: "ItemId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 164,
                column: "ItemId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 71, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 166,
                column: "ItemId",
                value: 71);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 71, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 72, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 73, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 73, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 171,
                column: "ItemId",
                value: 74);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 74, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 74, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 74, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 75, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 75, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 75, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 75, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 76, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 76, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 181,
                column: "ItemId",
                value: 77);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 182,
                column: "ItemId",
                value: 77);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 183,
                column: "ItemId",
                value: 77);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 77, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 78, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 79, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 80, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 188,
                column: "ItemId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 189,
                column: "ItemId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 190,
                column: "ItemId",
                value: 81);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 81, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 82, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 82, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 82, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 83, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 83, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 83, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 84, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 84, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 84, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 85, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 85, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 85, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 85, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 205,
                column: "ItemId",
                value: 86);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 206,
                column: "ItemId",
                value: 86);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 87, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 87, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 88, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 210,
                column: "ItemId",
                value: 89);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 211,
                column: "ItemId",
                value: 90);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 90, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 213,
                column: "ItemId",
                value: 91);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 92, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 92, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 92, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 217,
                column: "ItemId",
                value: 93);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 218,
                column: "ItemId",
                value: 93);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 93, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 94, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 221,
                column: "ItemId",
                value: 94);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 95, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 223,
                column: "ItemId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 224,
                column: "ItemId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 225,
                column: "ItemId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 226,
                column: "ItemId",
                value: 96);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 96, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 96, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 97, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 97, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 97, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 232,
                column: "ItemId",
                value: 98);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 235,
                column: "ItemId",
                value: 98);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 99, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 237,
                column: "ItemId",
                value: 99);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 100, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 100, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 240,
                column: "ItemId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 241,
                column: "ItemId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 101, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 243,
                column: "ItemId",
                value: 101);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 101, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 245,
                column: "ItemId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 246,
                column: "ItemId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 247,
                column: "ItemId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 248,
                column: "ItemId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 104, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 250,
                column: "ItemId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 251,
                column: "ItemId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 252,
                column: "ItemId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 253,
                column: "ItemId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 106, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 255,
                column: "ItemId",
                value: 106);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 256,
                column: "ItemId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 257,
                column: "ItemId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 258,
                column: "ItemId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 107, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 108, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 108, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 108, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 263,
                column: "ItemId",
                value: 108);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 264,
                column: "ItemId",
                value: 109);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 265,
                column: "ItemId",
                value: 110);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 268,
                column: "ItemId",
                value: 111);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 269,
                column: "ItemId",
                value: 111);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 270,
                column: "ItemId",
                value: 112);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 112, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 113, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 113, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 113, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 113, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 114, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 114, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 114, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 279,
                column: "ItemId",
                value: 115);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 280,
                column: "ItemId",
                value: 115);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 116, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 116, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 117, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 117, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 118, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 286,
                column: "ItemId",
                value: 119);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 120, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 120, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 120, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 121, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 122, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 122, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 122, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 122, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 123, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 296,
                column: "ItemId",
                value: 123);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 297,
                column: "ItemId",
                value: 123);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 298,
                column: "ItemId",
                value: 123);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 124, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 125, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 125, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 125, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 125, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 126, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 126, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 127, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 127, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 127, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 128, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 128, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 128, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 128, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 129, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 130, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 131, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 131, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 131, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 132, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 132, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 132, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 133, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 133, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 133, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 134, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 134, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 134, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 135, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 136, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 136, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 136, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 136, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 137, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 333,
                column: "ItemId",
                value: 138);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 334,
                column: "ItemId",
                value: 139);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 335,
                column: "ItemId",
                value: 139);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 139, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 139, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 140, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 140, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 340,
                column: "ItemId",
                value: 140);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 141, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 141, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 141, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 142, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 143, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 143, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 347,
                column: "ItemId",
                value: 143);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 143, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 144, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 145, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 145, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 145, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 145, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 146, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 146, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 146, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 146, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 147, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 147, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 147, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 148, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 362,
                column: "ItemId",
                value: 148);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 149, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 149, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 150, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 150, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 151, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 368,
                column: "ItemId",
                value: 152);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 152, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 152, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 152, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 153, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 153, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 374,
                column: "ItemId",
                value: 153);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 375,
                column: "ItemId",
                value: 153);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 376,
                column: "ItemId",
                value: 154);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 155, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 155, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 379,
                column: "ItemId",
                value: 155);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 380,
                column: "ItemId",
                value: 156);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 156, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 156, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 157, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 384,
                column: "ItemId",
                value: 158);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 385,
                column: "ItemId",
                value: 159);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 386,
                column: "ItemId",
                value: 159);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 387,
                column: "ItemId",
                value: 159);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 388,
                column: "ItemId",
                value: 160);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 389,
                column: "ItemId",
                value: 160);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 390,
                column: "ItemId",
                value: 160);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 391,
                column: "ItemId",
                value: 160);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 161, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 161, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 161, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 162, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 163, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 164, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 398,
                column: "ItemId",
                value: 165);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 165, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 165, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 165, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 166, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 166, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 167, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 167, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 168, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 407,
                column: "ItemId",
                value: 168);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 168, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 169, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 169, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 170, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 171, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 171, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 171, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 171, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 416,
                column: "ItemId",
                value: 172);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 417,
                column: "ItemId",
                value: 172);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 418,
                column: "ItemId",
                value: 173);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 419,
                column: "ItemId",
                value: 173);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 420,
                column: "ItemId",
                value: 174);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 421,
                column: "ItemId",
                value: 174);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 175, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 423,
                column: "ItemId",
                value: 175);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 175, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 176, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 176, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 177, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 177, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 429,
                column: "ItemId",
                value: 177);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 177, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 431,
                column: "ItemId",
                value: 178);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 179, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 179, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 434,
                column: "ItemId",
                value: 179);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 435,
                column: "ItemId",
                value: 180);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 180, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 180, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 180, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 181, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 182, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 183, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 442,
                column: "ItemId",
                value: 184);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 443,
                column: "ItemId",
                value: 185);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 444,
                column: "ItemId",
                value: 185);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 445,
                column: "ItemId",
                value: 185);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 186, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 186, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 186, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 187, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 187, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 187, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 188, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 188, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 188, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 455,
                column: "ItemId",
                value: 188);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 456,
                column: "ItemId",
                value: 189);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 461,
                column: "ItemId",
                value: 191);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 192, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 192, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 192, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 465,
                column: "ItemId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 466,
                column: "ItemId",
                value: 193);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 467,
                column: "ItemId",
                value: 193);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 468,
                column: "ItemId",
                value: 193);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 469,
                column: "ItemId",
                value: 193);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 470,
                column: "ItemId",
                value: 194);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 195, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 195, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 195, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 195, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 196, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 196, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 197, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 478,
                column: "ItemId",
                value: 197);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 479,
                column: "ItemId",
                value: 197);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 480,
                column: "ItemId",
                value: 198);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 199, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 199, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 199, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 200, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 485,
                column: "ItemId",
                value: 200);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 201, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 201, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 488,
                column: "ItemId",
                value: 201);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 489,
                column: "ItemId",
                value: 202);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 202, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 202, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 203, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 203, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 203, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 495,
                column: "ItemId",
                value: 203);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 204, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 205, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 205, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 205, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 206, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 207, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 207, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 503,
                column: "ItemId",
                value: 207);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 208, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 208, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 208, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 209, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 209, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 209, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 209, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 210, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 211, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 211, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 212, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 212, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 212, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 212, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 213, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 213, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 213, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 213, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 214, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 214, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 214, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 215, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 215, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 215, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 216, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 216, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 216, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 217, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 218, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 218, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 218, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 218, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 536,
                column: "ItemId",
                value: 219);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 537,
                column: "ItemId",
                value: 219);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 538,
                column: "ItemId",
                value: 219);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 539,
                column: "ItemId",
                value: 219);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 540,
                column: "ItemId",
                value: 220);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 541,
                column: "ItemId",
                value: 220);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 220, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 220, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 221, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 221, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 221, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 221, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 548,
                column: "ItemId",
                value: 222);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 222, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 223, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 223, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 224, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 224, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 224, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 555,
                column: "ItemId",
                value: 225);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 556,
                column: "ItemId",
                value: 226);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 557,
                column: "ItemId",
                value: 226);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 558,
                column: "ItemId",
                value: 226);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 559,
                column: "ItemId",
                value: 226);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 227, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 227, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 227, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 563,
                column: "ItemId",
                value: 228);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 564,
                column: "ItemId",
                value: 228);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 228, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 228, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 229, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 229, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 230, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 570,
                column: "ItemId",
                value: 231);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 232, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 232, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 233, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 574,
                column: "ItemId",
                value: 233);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 575,
                column: "ItemId",
                value: 233);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 234, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 235, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 235, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 236, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 236, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 236, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 236, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 237, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 584,
                column: "ItemId",
                value: 237);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 585,
                column: "ItemId",
                value: 238);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 586,
                column: "ItemId",
                value: 238);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 587,
                column: "ItemId",
                value: 238);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 588,
                column: "ItemId",
                value: 238);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 239, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 590,
                column: "ItemId",
                value: 240);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 240, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 241, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 241, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 241, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 242, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 242, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 242, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 242, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 243, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 243, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 243, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 602,
                column: "ItemId",
                value: 243);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 603,
                column: "ItemId",
                value: 244);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 604,
                column: "ItemId",
                value: 244);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 244, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 245, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 245, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 246, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 609,
                column: "ItemId",
                value: 247);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 248, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 248, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 248, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 249, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 249, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 250, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 616,
                column: "ItemId",
                value: 250);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 251, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 251, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 251, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 620,
                column: "ItemId",
                value: 252);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 621,
                column: "ItemId",
                value: 252);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 253, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 623,
                column: "ItemId",
                value: 253);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 624,
                column: "ItemId",
                value: 253);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 625,
                column: "ItemId",
                value: 253);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 254, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 254, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 628,
                column: "ItemId",
                value: 255);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 629,
                column: "ItemId",
                value: 255);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 630,
                column: "ItemId",
                value: 256);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 631,
                column: "ItemId",
                value: 256);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 632,
                column: "ItemId",
                value: 257);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 633,
                column: "ItemId",
                value: 257);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 634,
                column: "ItemId",
                value: 257);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 258, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 636,
                column: "ItemId",
                value: 258);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 258, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 258, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 259, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 259, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 259, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 260, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 260, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 261, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 261, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 262, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 262, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 648,
                column: "ItemId",
                value: 262);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 263, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 650,
                column: "ItemId",
                value: 263);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 263, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 652,
                column: "ItemId",
                value: 264);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 264, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 658,
                column: "ItemId",
                value: 266);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 659,
                column: "ItemId",
                value: 266);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 660,
                column: "ItemId",
                value: 266);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 267, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 268, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 268, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 268, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 269, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 270, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 270, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 270, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 270, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 271, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 272, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 272, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 272, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 272, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 273, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 676,
                column: "ItemId",
                value: 273);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 677,
                column: "ItemId",
                value: 274);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 678,
                column: "ItemId",
                value: 274);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 275, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 275, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 275, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 276, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 276, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 276, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 276, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 277, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 687,
                column: "ItemId",
                value: 278);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 688,
                column: "ItemId",
                value: 278);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 279, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 690,
                column: "ItemId",
                value: 280);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 281, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 281, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 281, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 282, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 282, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 282, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 283, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 284, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 699,
                column: "ItemId",
                value: 284);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 285, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 285, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 285, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 285, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 286, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 286, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 706,
                column: "ItemId",
                value: 287);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 287, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 287, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 709,
                column: "ItemId",
                value: 288);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 710,
                column: "ItemId",
                value: 288);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 711,
                column: "ItemId",
                value: 288);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 712,
                column: "ItemId",
                value: 288);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 713,
                column: "ItemId",
                value: 289);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 714,
                column: "ItemId",
                value: 289);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 290, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 290, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 290, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 718,
                column: "ItemId",
                value: 291);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 291, 3 });
        }
    }
}
