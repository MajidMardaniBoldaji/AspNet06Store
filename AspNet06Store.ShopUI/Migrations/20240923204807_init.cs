using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNet06Store.ShopUI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "", "", 0 },
                    { 2, "", "", "", 0 },
                    { 3, "", "", "", 0 },
                    { 4, "", "", "", 0 },
                    { 5, "", "", "", 0 },
                    { 6, "", "", "", 0 },
                    { 7, "", "", "", 0 },
                    { 8, "", "", "", 0 },
                    { 9, "", "", "", 0 },
                    { 10, "", "", "", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
