using CardapioWEB_Demo.Context;
using CardapioWEB_Demo.Models;
using CardapioWEB_Demo.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CardapioWEB_Demo.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _contexto;

        public LancheRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Lanche> Lanches => _contexto.lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _contexto.lanches.
            Where(l => l.IsLanchePreferido).
            Include(c => c.Categoria);

        public Lanche GetLancheByID(int lancheId)
        {
            return _contexto.lanches.FirstOrDefault(l => l.lancheID == lancheId); //lanchdeID(MODEL) == lancheID(Parametro)
        }
    }
}
