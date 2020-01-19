using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class version4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Stores_StoreId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_StoreId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Category");

            migrationBuilder.CreateTable(
                name: "StoreCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreCategory_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreCategory_CategoryId",
                table: "StoreCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCategory_StoreId",
                table: "StoreCategory",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreCategory");

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_StoreId",
                table: "Category",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Stores_StoreId",
                table: "Category",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
