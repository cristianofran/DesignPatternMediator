using DesignPatternMediator.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternMediator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingMediator _shoppingMediator;

        public ShoppingController(IShoppingMediator shoppingMediator)
        {
            _shoppingMediator = shoppingMediator;
        }

        [HttpPost]
        public IActionResult AdicionarAoCarrinho(int id)
        {
            _shoppingMediator.Handle(id);
            return Ok();
        }
    }
}
