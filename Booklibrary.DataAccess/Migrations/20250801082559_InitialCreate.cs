using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booklibrary.DataAccess.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Categories",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                DisplayOrder = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Categories", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Products",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                ListPrice = table.Column<double>(type: "float", nullable: false),
                Price = table.Column<double>(type: "float", nullable: false),
                Price50 = table.Column<double>(type: "float", nullable: false),
                Price100 = table.Column<double>(type: "float", nullable: false),
                ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Products", x => x.Id);
            });

        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "Id", "DisplayOrder", "Name" },
            values: new object[,]
            {
                { 1, 1, "Action" },
                { 2, 2, "SciFi" },
                { 3, 3, "History" }
            });

        migrationBuilder.InsertData(
            table: "Products",
            columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price50", "Price100", "Title" },
            values: new object[,]
            {
                { 1, "Billy Spark", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", "SWD9999001", 99.0, 90.0, 85.0, 80.0, "Fortune of Time" },
                { 2, "Nancy Hoover", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", "CAW777777701", 40.0, 30.0, 25.0, 20.0, "Dark Skies" },
                { 3, "Julian Button", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", "RITO5555501", 55.0, 50.0, 40.0, 35.0, "Vanish in the Sunset" },
                { 4, "John Doe", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.", "JD1234567890", 75.0, 70.0, 65.0, 60.0, "Mystery of the Lost City" }
            });



    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Categories");

        migrationBuilder.DropTable(
            name: "Products");
    }
}
