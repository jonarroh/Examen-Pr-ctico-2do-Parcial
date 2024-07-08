using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace parcial2examen.Migrations
{
    /// <inheritdoc />
    public partial class descripcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descripcion",
                value: "Clancy el nuevo album de Twenty one pilots");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descripcion",
                value: "Keep Me Fed es el nuevo album de The Warning");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descripcion",
                value: "“Music of the Spheres” es una colección de 12 canciones con oleadas de sintetizadores y melodías etéreas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Productos");
        }
    }
}
