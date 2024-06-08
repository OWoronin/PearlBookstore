using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInItemsTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "TypeId",
                value: 2);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 2, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 4, 2 });

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
                column: "ItemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ItemId",
                value: 8);

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
                column: "ItemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ItemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ItemId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "TypeId",
                value: 3);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 13, 2 });

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
                column: "ItemId",
                value: 18);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 18, 4 });

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
                column: "ItemId",
                value: 20);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 21, 3 });

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
                column: "ItemId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "ItemId",
                value: 23);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 28, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 28, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 61,
                column: "ItemId",
                value: 29);

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
                column: "ItemId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 66,
                column: "ItemId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 67,
                column: "ItemId",
                value: 31);

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
                column: "ItemId",
                value: 34);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 39, 3 });

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
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 43, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "TypeId",
                value: 1);

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
                column: "ItemId",
                value: 46);

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
                column: "TypeId",
                value: 3);

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
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 113,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 114,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 51, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 51, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 52, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 121,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 122,
                column: "TypeId",
                value: 2);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 55, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 55, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 126,
                column: "TypeId",
                value: 4);

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
                column: "ItemId",
                value: 57);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 131,
                column: "ItemId",
                value: 57);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 57, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 133,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 58, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 58, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 58, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 60, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 61, 1 });

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
                column: "ItemId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 64, 3 });

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
                column: "ItemId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 162,
                column: "ItemId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 70, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 70, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 71, 3 });

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
                column: "ItemId",
                value: 73);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 74, 1 });

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
                column: "ItemId",
                value: 75);

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
                column: "ItemId",
                value: 76);

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
                column: "ItemId",
                value: 77);

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
                column: "ItemId",
                value: 79);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 187,
                column: "ItemId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 80, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 80, 4 });

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
                column: "ItemId",
                value: 85);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 202,
                column: "ItemId",
                value: 85);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 203,
                column: "ItemId",
                value: 85);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 204,
                column: "ItemId",
                value: 85);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 86, 2 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 89, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 93, 2 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 94, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 222,
                column: "ItemId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 95, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 95, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 95, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 96, 1 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 1 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 99, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 100, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 100, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 101, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 105, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 106, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 107, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 107, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 107, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 108, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 109, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 110, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 266,
                column: "ItemId",
                value: 111);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 115, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 115, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 119, 4 });

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
                column: "ItemId",
                value: 121);

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
                column: "ItemId",
                value: 123);

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
                column: "ItemId",
                value: 126);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 305,
                column: "ItemId",
                value: 126);

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
                column: "ItemId",
                value: 133);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 322,
                column: "ItemId",
                value: 133);

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
                column: "ItemId",
                value: 136);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 329,
                column: "ItemId",
                value: 136);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 138, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 139, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 139, 2 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 140, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 143, 3 });

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
                column: "ItemId",
                value: 145);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 351,
                column: "ItemId",
                value: 145);

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
                column: "ItemId",
                value: 148);

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
                column: "ItemId",
                value: 151);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 368,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 369,
                column: "TypeId",
                value: 2);

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
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 373,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 153, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 153, 4 });

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
                column: "ItemId",
                value: 155);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 155, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 380,
                column: "TypeId",
                value: 1);

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
                column: "ItemId",
                value: 157);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 158, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 385,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 159, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 159, 3 });

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
                column: "ItemId",
                value: 161);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 393,
                column: "ItemId",
                value: 161);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 394,
                column: "ItemId",
                value: 161);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 395,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 397,
                column: "ItemId",
                value: 164);

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
                column: "ItemId",
                value: 165);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 400,
                column: "ItemId",
                value: 165);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 401,
                column: "TypeId",
                value: 4);

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
                column: "ItemId",
                value: 166);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 168, 3 });

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
                column: "ItemId",
                value: 171);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 413,
                column: "ItemId",
                value: 171);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 172, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 172, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 173, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 173, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 174, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 174, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 422,
                column: "ItemId",
                value: 175);

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
                column: "ItemId",
                value: 176);

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
                column: "ItemId",
                value: 177);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 428,
                column: "ItemId",
                value: 177);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 177, 3 });

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
                column: "TypeId",
                value: 4);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 184, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 185, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 185, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 185, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 188, 4 });

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
                column: "ItemId",
                value: 190);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 458,
                column: "ItemId",
                value: 190);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 459,
                column: "ItemId",
                value: 190);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 191, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 192, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 193, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 193, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 193, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 193, 4 });

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
                column: "ItemId",
                value: 196);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 476,
                column: "ItemId",
                value: 196);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 197, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 197, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 198, 2 });

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
                column: "ItemId",
                value: 200);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 200, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 201, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 202, 1 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 203, 4 });

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
                column: "ItemId",
                value: 207);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 502,
                column: "ItemId",
                value: 207);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 503,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 505,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 506,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 512,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 513,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 517,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 521,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 524,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 527,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 534,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 535,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 219, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 537,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 538,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 539,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 548,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 549,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 550,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 551,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 554,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 555,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 226, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 226, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 560,
                column: "TypeId",
                value: 1);

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
                column: "ItemId",
                value: 228);

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
                column: "ItemId",
                value: 229);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 568,
                column: "ItemId",
                value: 229);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 570,
                column: "TypeId",
                value: 3);

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
                column: "TypeId",
                value: 2);

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
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 233, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 576,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 577,
                column: "ItemId",
                value: 235);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 578,
                column: "TypeId",
                value: 4);

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
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 581,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 582,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 584,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 238, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 586,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 587,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 238, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 240, 2 });

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
                column: "ItemId",
                value: 241);

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
                column: "TypeId",
                value: 1);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 243, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 244, 2 });

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
                column: "ItemId",
                value: 245);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 607,
                column: "ItemId",
                value: 245);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 247, 3 });

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
                column: "ItemId",
                value: 249);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 250, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 252, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 252, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 622,
                column: "ItemId",
                value: 253);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 253, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 253, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 253, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 626,
                column: "ItemId",
                value: 254);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 255, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 255, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 256, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 256, 4 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 257, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 257, 3 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 258, 2 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 262, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 649,
                column: "ItemId",
                value: 263);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 263, 2 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 264, 2 });

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 266, 4 });

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
                column: "ItemId",
                value: 268);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 663,
                column: "ItemId",
                value: 268);

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
                column: "ItemId",
                value: 273);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 273, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 274, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 274, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 679,
                column: "ItemId",
                value: 275);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 680,
                column: "ItemId",
                value: 275);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 681,
                column: "ItemId",
                value: 275);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 278, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 278, 4 });

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
                column: "ItemId",
                value: 281);

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
                column: "ItemId",
                value: 282);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 695,
                column: "ItemId",
                value: 282);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 284, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 700,
                column: "ItemId",
                value: 285);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 701,
                column: "ItemId",
                value: 285);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 702,
                column: "ItemId",
                value: 285);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 703,
                column: "ItemId",
                value: 285);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 704,
                column: "ItemId",
                value: 286);

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
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 287, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 287, 2 });

            migrationBuilder.InsertData(
                table: "ItemsTypes",
                columns: new[] { "Id", "ItemId", "TypeId" },
                values: new object[,]
                {
                    { 708, 287, 3 },
                    { 709, 288, 1 },
                    { 710, 288, 2 },
                    { 711, 288, 3 },
                    { 712, 288, 4 },
                    { 713, 289, 2 },
                    { 714, 289, 3 },
                    { 715, 290, 2 },
                    { 716, 290, 3 },
                    { 717, 290, 4 },
                    { 718, 291, 2 },
                    { 719, 291, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ItemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ItemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ItemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ItemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ItemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ItemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ItemId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 11, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ItemId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 13, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 14, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 14, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 14, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 15, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ItemId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 16, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 16, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 16, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 17, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 17, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "ItemId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 18, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 18, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 18, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "ItemId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "ItemId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 23, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 23, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 24, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 25, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 25, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 25, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 61,
                column: "ItemId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 62,
                column: "ItemId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 65,
                column: "ItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 66,
                column: "ItemId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 67,
                column: "ItemId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 69,
                column: "ItemId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 31, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 32, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 32, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 32, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 74,
                column: "ItemId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 33, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 34, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 34, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 34, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 35, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 36, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 36, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 36, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 37, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 37, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 37, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 38, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 39, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 39, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 39, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 40, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 40, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 41, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 96,
                column: "ItemId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 97,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 44, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 45, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 45, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 46, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 46, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 47, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 105,
                column: "ItemId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 48, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 48, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 48, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 109,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 49, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 111,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 113,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 114,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 50, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 116,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 52, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 53, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 53, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 53, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 121,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 122,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 54, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 54, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 54, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 126,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 57, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 57, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 130,
                column: "ItemId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 131,
                column: "ItemId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 58, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 133,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 59, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 60, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 61, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 137,
                column: "ItemId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 138,
                column: "ItemId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 139,
                column: "ItemId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 63, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 63, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 63, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 64, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 64, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 64, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 64, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 65, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 148,
                column: "ItemId",
                value: 66);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 66, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 67, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 67, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 68, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 68, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 68, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 68, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 69, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 69, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 158,
                column: "ItemId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 70, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 71, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 161,
                column: "ItemId",
                value: 72);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 162,
                column: "ItemId",
                value: 72);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 73, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 73, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 73, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 73, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 74, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 74, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 169,
                column: "ItemId",
                value: 75);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 75, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 75, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 76, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 76, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 76, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 175,
                column: "ItemId",
                value: 77);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 78, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 78, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 79, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 179,
                column: "ItemId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 80, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 181,
                column: "ItemId",
                value: 81);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 182,
                column: "ItemId",
                value: 81);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 183,
                column: "ItemId",
                value: 81);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 184,
                column: "ItemId",
                value: 81);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 82, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 186,
                column: "ItemId",
                value: 82);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 187,
                column: "ItemId",
                value: 83);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 83, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 83, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 190,
                column: "ItemId",
                value: 84);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 84, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 84, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 85, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 85, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 85, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 86, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 86, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 86, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 87, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 87, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 201,
                column: "ItemId",
                value: 88);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 202,
                column: "ItemId",
                value: 88);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 203,
                column: "ItemId",
                value: 88);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 204,
                column: "ItemId",
                value: 88);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 205,
                column: "ItemId",
                value: 89);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 90, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 90, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 90, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 91, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 91, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 211,
                column: "ItemId",
                value: 92);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 93, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 213,
                column: "ItemId",
                value: 94);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 94, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 94, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 94, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 217,
                column: "ItemId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 96, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 96, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 96, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 96, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 222,
                column: "ItemId",
                value: 97);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 98, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 99, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 99, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 99, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 100, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 100, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 100, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 101, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 102, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 102, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 102, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 103, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 103, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 103, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 103, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 104, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 105, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 105, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 105, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 245,
                column: "ItemId",
                value: 105);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 246,
                column: "ItemId",
                value: 106);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 247,
                column: "ItemId",
                value: 106);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 248,
                column: "ItemId",
                value: 106);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 106, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 250,
                column: "ItemId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 251,
                column: "ItemId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 252,
                column: "ItemId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 108, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 109, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 109, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 109, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 109, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 110, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 110, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 110, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 110, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 111, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 266,
                column: "ItemId",
                value: 112);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 113, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 114, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 114, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 270,
                column: "ItemId",
                value: 115);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 115, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 115, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 116, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 116, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 116, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 116, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 117, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 117, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 117, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 118, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 118, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 119, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 120, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 120, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 120, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 121, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 122, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 123, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 123, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 290,
                column: "ItemId",
                value: 124);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 124, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 124, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 124, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 125, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 295,
                column: "ItemId",
                value: 126);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 296,
                column: "ItemId",
                value: 126);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 297,
                column: "ItemId",
                value: 126);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 298,
                column: "ItemId",
                value: 126);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 127, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 127, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 128, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 128, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 128, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 304,
                column: "ItemId",
                value: 129);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 305,
                column: "ItemId",
                value: 129);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 130, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 130, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 130, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 130, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 131, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 132, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 132, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 132, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 132, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 133, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 133, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 133, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 134, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 134, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 134, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 321,
                column: "ItemId",
                value: 135);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 322,
                column: "ItemId",
                value: 135);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 135, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 136, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 137, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 137, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 137, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 328,
                column: "ItemId",
                value: 138);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 329,
                column: "ItemId",
                value: 138);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 139, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 139, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 140, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 140, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 140, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 140, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 141, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 141, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 141, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 141, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 142, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 142, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 143, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 143, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 144, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 144, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 144, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 144, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 145, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 145, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 350,
                column: "ItemId",
                value: 146);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 351,
                column: "ItemId",
                value: 146);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 147, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 147, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 147, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 147, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 148, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 148, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 148, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 148, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 149, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 361,
                column: "ItemId",
                value: 150);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 362,
                column: "ItemId",
                value: 150);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 151, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 151, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 151, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 151, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 367,
                column: "ItemId",
                value: 152);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 368,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 369,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 153, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 153, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 372,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 373,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 154, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 155, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 376,
                column: "ItemId",
                value: 155);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 377,
                column: "ItemId",
                value: 156);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 156, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 156, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 380,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 157, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 157, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 383,
                column: "ItemId",
                value: 158);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 159, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 385,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 160, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 160, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 388,
                column: "ItemId",
                value: 161);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 389,
                column: "ItemId",
                value: 161);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 390,
                column: "ItemId",
                value: 161);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 391,
                column: "ItemId",
                value: 161);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 392,
                column: "ItemId",
                value: 162);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 393,
                column: "ItemId",
                value: 162);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 394,
                column: "ItemId",
                value: 162);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 395,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 397,
                column: "ItemId",
                value: 163);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 398,
                column: "ItemId",
                value: 164);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 399,
                column: "ItemId",
                value: 164);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 400,
                column: "ItemId",
                value: 164);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 401,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 165, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 403,
                column: "ItemId",
                value: 165);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 166, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 166, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 167, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 167, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 167, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 168, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 168, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 168, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 412,
                column: "ItemId",
                value: 169);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 413,
                column: "ItemId",
                value: 169);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 170, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 170, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 171, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 171, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 172, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 172, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 172, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 172, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 422,
                column: "ItemId",
                value: 173);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 423,
                column: "ItemId",
                value: 173);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 173, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 425,
                column: "ItemId",
                value: 174);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 174, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 427,
                column: "ItemId",
                value: 175);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 428,
                column: "ItemId",
                value: 175);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 176, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 176, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 431,
                column: "ItemId",
                value: 177);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 177, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 177, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 434,
                column: "ItemId",
                value: 177);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 435,
                column: "ItemId",
                value: 178);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 179, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 179, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 438,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 180, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 180, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 181, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 182, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 182, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 183, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 183, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 184, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 184, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 184, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 184, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 185, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 185, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 185, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 185, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 186, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 186, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 456,
                column: "ItemId",
                value: 187);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 457,
                column: "ItemId",
                value: 188);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 458,
                column: "ItemId",
                value: 188);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 459,
                column: "ItemId",
                value: 188);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 189, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 189, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 189, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 190, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 191, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 191, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 191, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 470,
                column: "ItemId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 192, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 192, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 193, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 193, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 475,
                column: "ItemId",
                value: 194);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 476,
                column: "ItemId",
                value: 194);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 194, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 195, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 195, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 196, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 196, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 196, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 196, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 484,
                column: "ItemId",
                value: 197);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 197, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 197, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 198, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 199, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 199, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 200, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 201, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 201, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 202, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 202, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 202, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 203, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 203, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 204, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 204, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 205, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 501,
                column: "ItemId",
                value: 206);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 502,
                column: "ItemId",
                value: 206);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 503,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 505,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 506,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 210, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 210, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 511,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 512,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 513,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 211, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 211, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 516,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 517,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 212, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 212, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 520,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 521,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 213, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 523,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 524,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 214, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 526,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 527,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 217, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 217, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 531,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 217, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 533,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 534,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 535,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 218, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 537,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 538,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 539,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 548,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 549,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 550,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 551,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 223, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 553,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 554,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 555,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 227, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 227, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 560,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 228, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 228, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 563,
                column: "ItemId",
                value: 229);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 564,
                column: "ItemId",
                value: 229);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 565,
                column: "ItemId",
                value: 229);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 230, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 567,
                column: "ItemId",
                value: 230);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 568,
                column: "ItemId",
                value: 230);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 570,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 231, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 572,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 232, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 574,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 234, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 576,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 577,
                column: "ItemId",
                value: 234);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 578,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 235, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 580,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 581,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 582,
                column: "TypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 584,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 237, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 586,
                column: "TypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 587,
                column: "TypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 239, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 240, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 241, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 241, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 592,
                column: "ItemId",
                value: 242);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 242, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 242, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 595,
                column: "TypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 243, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 244, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 244, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 244, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 245, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 246, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 247, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 603,
                column: "ItemId",
                value: 248);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 249, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 249, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 606,
                column: "ItemId",
                value: 250);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 607,
                column: "ItemId",
                value: 250);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 251, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 251, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 251, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 251, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 252, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 613,
                column: "ItemId",
                value: 252);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 253, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 253, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 254, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 254, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 255, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 255, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 255, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 255, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 622,
                column: "ItemId",
                value: 256);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 257, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 257, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 257, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 626,
                column: "ItemId",
                value: 258);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 259, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 259, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 259, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 260, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 260, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 632,
                column: "ItemId",
                value: 261);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 262, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 262, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 262, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 262, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 263, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 263, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 263, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 263, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 264, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 265, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 266, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 266, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 266, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 649,
                column: "ItemId",
                value: 267);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 268, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 268, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 269, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 269, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 269, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 270, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 270, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 270, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 658,
                column: "ItemId",
                value: 271);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 659,
                column: "ItemId",
                value: 271);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 271, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 272, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 662,
                column: "ItemId",
                value: 273);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 663,
                column: "ItemId",
                value: 273);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 274, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 274, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 274, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 274, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 275, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 275, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 275, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 275, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 276, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 276, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 277, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 675,
                column: "ItemId",
                value: 278);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 278, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 278, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 278, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 679,
                column: "ItemId",
                value: 279);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 680,
                column: "ItemId",
                value: 279);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 681,
                column: "ItemId",
                value: 279);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 279, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 280, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 281, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 281, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 281, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 281, 4 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 282, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 283, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 690,
                column: "ItemId",
                value: 283);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 691,
                column: "ItemId",
                value: 284);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 285, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 285, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 694,
                column: "ItemId",
                value: 286);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 695,
                column: "ItemId",
                value: 286);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 287, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 287, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 288, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 289, 1 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 700,
                column: "ItemId",
                value: 290);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 701,
                column: "ItemId",
                value: 290);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 702,
                column: "ItemId",
                value: 290);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 703,
                column: "ItemId",
                value: 290);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 704,
                column: "ItemId",
                value: 291);

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 291, 2 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 291, 3 });

            migrationBuilder.UpdateData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "ItemId", "TypeId" },
                values: new object[] { 291, 4 });
        }
    }
}
