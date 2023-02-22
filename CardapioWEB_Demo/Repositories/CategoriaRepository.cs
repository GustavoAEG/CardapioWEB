using CardapioWEB_Demo.Context;
using CardapioWEB_Demo.Models;
using CardapioWEB_Demo.Repositories.Interfaces;

namespace CardapioWEB_Demo.Repositories
{//AQUI IREI Implementar à Interface herdandno ICategoriaRepository
    public class CategoriaRepository : ICategoriaRepository
    {
        //épreciso acessarbanco de dados
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
