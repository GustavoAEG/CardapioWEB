using CardapioWEB_Demo.Models;

namespace CardapioWEB_Demo.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
