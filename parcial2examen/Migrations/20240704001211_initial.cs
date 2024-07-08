using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace parcial2examen.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Cantidad", "Categoria", "Image", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 52, "Usa", "https://m.media-amazon.com/images/I/81moh0ogZCL._UF1000,1000_QL80_.jpg", "Clancy", 685m },
                    { 2, 52, "MXN", "https://shop.republicrecords.com/cdn/shop/files/SPOTIFY-THEWARNING_LP_MOCKUP_58_88_1.png?v=1711996978", "Keep Me Feed", 485m },
                    { 3, 52, "MXN", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQLkZTSGluevAlHw1F4BXwLzKo4skJnFxluWA&s", "Music Of The Sphere", 485m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
