using Microsoft.EntityFrameworkCore;

namespace CardapioWEB_Demo.Context
{
    public class AppDbContext:DbContext  //herda da classe dbcontext entityfraework
    {
        //contrutor

        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)// esta base pe passada pra classe dbcontext
        {

        }
    }
}
