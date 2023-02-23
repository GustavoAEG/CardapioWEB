using CardapioWEB_Demo.Repositories.Interfaces;
using CardapioWEB_Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CardapioWEB_Demo.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {

            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();

            //ViewBag.Total = "Total de lanches: ";
            //ViewBag.TotalLanches= totalLanches;

            //return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            var totalLanches = lanchesListViewModel.Lanches.Count();
            ViewBag.Total = "Total de lanches: ";
            ViewBag.TotalLanches = totalLanches;

            return View(lanchesListViewModel);




        }
    }
}
