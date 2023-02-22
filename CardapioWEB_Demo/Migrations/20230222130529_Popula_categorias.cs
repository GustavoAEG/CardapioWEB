using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardapioWEB_Demo.Migrations
{
    /// <inheritdoc />
    public partial class Popula_categorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao)" +
           "VALUES('NORMAL','Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao)" +
             "VALUES('NATURAL','Lanche feito com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
