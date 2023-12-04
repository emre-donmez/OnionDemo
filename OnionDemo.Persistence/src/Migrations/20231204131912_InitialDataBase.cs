using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    PK_CATEGORY = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TX_NAME = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: false),
                    TX_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DT_CREATED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SW_DEL = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORY", x => x.PK_CATEGORY);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    PK_PRODUCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_CATEGORY_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TX_NAME = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: false),
                    NO_PRICE = table.Column<int>(type: "int", nullable: false),
                    TX_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DT_CREATED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SW_DEL = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.PK_PRODUCT);
                    table.ForeignKey(
                        name: "FK_Product_Category",
                        column: x => x.FK_CATEGORY_ID,
                        principalTable: "CATEGORY",
                        principalColumn: "PK_CATEGORY",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_FK_CATEGORY_ID",
                table: "PRODUCT",
                column: "FK_CATEGORY_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "CATEGORY");
        }
    }
}
