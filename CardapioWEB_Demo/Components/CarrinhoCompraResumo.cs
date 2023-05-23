using CardapioWEB_Demo.Migrations;
using CardapioWEB_Demo.Models;
using CardapioWEB_Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CardapioWEB_Demo.Components
{
    public class CarrinhoCompraResumo:ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            var items = new List<Models.CarrinhoCompraItem>()
                                {
                                new Models.CarrinhoCompraItem(),
                                new Models.CarrinhoCompraItem()

                                };

            //var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = items;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }
    }
}
