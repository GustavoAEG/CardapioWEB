using CardapioWEB_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioWEB_Demo.Context
{
    public class AppDbContext:DbContext  //herda da classe dbcontext entityfraework
    {
        //contrutor

        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)// esta base e passada pra classe dbcontext
        {

        }
        public DbSet<Categoria> Categorias { get; set; }//Sera Criado no Banco de Dados Apos Migration
        public DbSet<Lanche> lanches { get; set; }
    }
}
