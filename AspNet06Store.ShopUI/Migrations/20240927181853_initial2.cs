using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNet06Store.ShopUI.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Iphone", "Apple 16", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Samsung", "A70", 6000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Iphone", "Iphone 12", 47000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Iphone", "Iphone13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Samsung", "Samsung A20", 43000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Samsung", "Samsung A18", 56000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Iphone", "Iphone11", 340000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Nokia", "Nokia SS2", 34000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Iphone", "Iphone14", 50000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Nokia", "Nokia500", 30000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Category", "Name" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "", "", 0 });
        }
    }
}
