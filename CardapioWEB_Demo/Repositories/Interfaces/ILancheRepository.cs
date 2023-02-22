using CardapioWEB_Demo.Models;

namespace CardapioWEB_Demo.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }

        Lanche GetLancheByID(int lancheId);

    }
}
