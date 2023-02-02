using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receta",
                columns: table => new
                {
                    IdReceta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Categoria = table.Column<string>(nullable: false),
                    Ingredientes = table.Column<string>(nullable: false),
                    Instrucciones = table.Column<string>(nullable: false),
                    NombreAutor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ApellidoAutor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    EdadAutor = table.Column<int>(nullable: false),
                    EmailAutor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receta", x => x.IdReceta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receta");
        }
    }
}
