using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaCrud.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrutor",
                columns: table => new
                {
                    idInstrutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrutor", x => x.idInstrutor);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instrutor");
        }
    }
}
