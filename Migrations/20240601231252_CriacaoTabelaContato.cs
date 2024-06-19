using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuloAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelaContato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)   //Apica as mudancas no BD
        {
            migrationBuilder.CreateTable(
                name: "Contatos", // Ele cria automaticamente no BD no pluras
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) // Remove uma tabela, ou seja 
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
