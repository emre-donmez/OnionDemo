using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CATEGORY",
                columns: new[] { "PK_CATEGORY", "DT_CREATED", "TX_DESCRIPTION", "SW_DEL", "TX_NAME" },
                values: new object[,]
                {
                    { new Guid("0de8e949-21f7-45e7-9d4e-536b30072d35"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Kategori 5 açıklaması.", false, "Kategori 5" },
                    { new Guid("3d60e3e9-da05-47a7-9cc5-6fa19995e781"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Kategori 3 açıklaması.", false, "Kategori 3" },
                    { new Guid("4a3221b5-2da5-44b0-aac4-78b6728a3717"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Kategori 4 açıklaması.", false, "Kategori 4" },
                    { new Guid("b1f04949-fb5f-4286-9f2a-2f8b0c06e7de"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Kategori 2 açıklaması.", false, "Kategori 2" },
                    { new Guid("e4f41d7d-6d47-4b24-9a4f-91e7d7741f28"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Kategori 1 açıklaması.", false, "Kategori 1" }
                });

            migrationBuilder.InsertData(
                table: "PRODUCT",
                columns: new[] { "PK_PRODUCT", "FK_CATEGORY_ID", "DT_CREATED", "TX_DESCRIPTION", "SW_DEL", "TX_NAME", "NO_PRICE" },
                values: new object[,]
                {
                    { new Guid("2efdd11b-b2c5-470e-8a7b-960e4711483d"), new Guid("3d60e3e9-da05-47a7-9cc5-6fa19995e781"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 9 açıklaması.", false, "Ürün 9", 140 },
                    { new Guid("5f7fe0f9-07b7-45d3-a3e9-4e39de2e4423"), new Guid("4a3221b5-2da5-44b0-aac4-78b6728a3717"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 10 açıklaması.", false, "Ürün 10", 75 },
                    { new Guid("5f9668b0-f70f-45ee-a9a6-cf6d845d1e25"), new Guid("e4f41d7d-6d47-4b24-9a4f-91e7d7741f28"), new DateTime(2023, 11, 3, 22, 5, 26, 0, DateTimeKind.Unspecified), "Ürün 1 açıklaması.", false, "Ürün 1", 100 },
                    { new Guid("607a4e57-4ae4-4770-9f63-cdeb1d7e9f52"), new Guid("4a3221b5-2da5-44b0-aac4-78b6728a3717"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 12 açıklaması.", false, "Ürün 12", 135 },
                    { new Guid("63b179cc-5c4e-44f2-9b9a-49a74416bb80"), new Guid("b1f04949-fb5f-4286-9f2a-2f8b0c06e7de"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 4 açıklaması.", false, "Ürün 4", 120 },
                    { new Guid("85c4848c-adfd-4e47-8afb-ce572a1b0a8a"), new Guid("3d60e3e9-da05-47a7-9cc5-6fa19995e781"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 8 açıklaması.", false, "Ürün 8", 110 },
                    { new Guid("8e6b2ec8-c5e3-47ac-8e4d-f02a00c82b2b"), new Guid("0de8e949-21f7-45e7-9d4e-536b30072d35"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 14 açıklaması.", false, "Ürün 14", 125 },
                    { new Guid("a394e328-2b8f-4d4a-8f56-a41e7c0a3c46"), new Guid("b1f04949-fb5f-4286-9f2a-2f8b0c06e7de"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 5 açıklaması.", false, "Ürün 5", 180 },
                    { new Guid("a696f00d-3a2e-48bf-88bb-1f3f416570fb"), new Guid("3d60e3e9-da05-47a7-9cc5-6fa19995e781"), new DateTime(2023, 11, 3, 22, 5, 26, 0, DateTimeKind.Unspecified), "Ürün 7 açıklaması.", false, "Ürün 7", 80 },
                    { new Guid("b542bc9f-ec79-4a2e-9180-7a4a97c74a72"), new Guid("e4f41d7d-6d47-4b24-9a4f-91e7d7741f28"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 3 açıklaması.", false, "Ürün 3", 200 },
                    { new Guid("d6661d2f-8b78-4c24-9cb3-578c62ab35a1"), new Guid("0de8e949-21f7-45e7-9d4e-536b30072d35"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 13 açıklaması.", false, "Ürün 13", 95 },
                    { new Guid("df34cc80-b98e-4af3-8eaa-b7a76aae66fc"), new Guid("4a3221b5-2da5-44b0-aac4-78b6728a3717"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 11 açıklaması.", false, "Ürün 11", 105 },
                    { new Guid("e0160c83-a45d-49da-a1ac-c8b88cdb84fb"), new Guid("0de8e949-21f7-45e7-9d4e-536b30072d35"), new DateTime(2023, 11, 3, 22, 5, 26, 0, DateTimeKind.Unspecified), "Ürün 2 açıklaması.", false, "Ürün 2", 1500 },
                    { new Guid("e824abfd-ca71-4e09-9eac-a9d590ef42d2"), new Guid("0de8e949-21f7-45e7-9d4e-536b30072d35"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 15 açıklaması.", false, "Ürün 15", 155 },
                    { new Guid("ec6cec30-ac14-4b61-a1f4-f0e7c5e69d72"), new Guid("b1f04949-fb5f-4286-9f2a-2f8b0c06e7de"), new DateTime(2023, 11, 3, 22, 5, 26, 790, DateTimeKind.Unspecified), "Ürün 6 açıklaması.", false, "Ürün 6", 220 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("2efdd11b-b2c5-470e-8a7b-960e4711483d"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("5f7fe0f9-07b7-45d3-a3e9-4e39de2e4423"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("5f9668b0-f70f-45ee-a9a6-cf6d845d1e25"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("607a4e57-4ae4-4770-9f63-cdeb1d7e9f52"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("63b179cc-5c4e-44f2-9b9a-49a74416bb80"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("85c4848c-adfd-4e47-8afb-ce572a1b0a8a"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("8e6b2ec8-c5e3-47ac-8e4d-f02a00c82b2b"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("a394e328-2b8f-4d4a-8f56-a41e7c0a3c46"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("a696f00d-3a2e-48bf-88bb-1f3f416570fb"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("b542bc9f-ec79-4a2e-9180-7a4a97c74a72"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("d6661d2f-8b78-4c24-9cb3-578c62ab35a1"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("df34cc80-b98e-4af3-8eaa-b7a76aae66fc"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("e0160c83-a45d-49da-a1ac-c8b88cdb84fb"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("e824abfd-ca71-4e09-9eac-a9d590ef42d2"));

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PK_PRODUCT",
                keyValue: new Guid("ec6cec30-ac14-4b61-a1f4-f0e7c5e69d72"));

            migrationBuilder.DeleteData(
                table: "CATEGORY",
                keyColumn: "PK_CATEGORY",
                keyValue: new Guid("0de8e949-21f7-45e7-9d4e-536b30072d35"));

            migrationBuilder.DeleteData(
                table: "CATEGORY",
                keyColumn: "PK_CATEGORY",
                keyValue: new Guid("3d60e3e9-da05-47a7-9cc5-6fa19995e781"));

            migrationBuilder.DeleteData(
                table: "CATEGORY",
                keyColumn: "PK_CATEGORY",
                keyValue: new Guid("4a3221b5-2da5-44b0-aac4-78b6728a3717"));

            migrationBuilder.DeleteData(
                table: "CATEGORY",
                keyColumn: "PK_CATEGORY",
                keyValue: new Guid("b1f04949-fb5f-4286-9f2a-2f8b0c06e7de"));

            migrationBuilder.DeleteData(
                table: "CATEGORY",
                keyColumn: "PK_CATEGORY",
                keyValue: new Guid("e4f41d7d-6d47-4b24-9a4f-91e7d7741f28"));
        }
    }
}
