using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartasPapaiNoelController : ControllerBase
    {
        private readonly ICartasPapaiNoelServices _cartasServices;

        public CartasPapaiNoelController(ICartasPapaiNoelServices cartasPapaiNoelServices)
        {
            _cartasServices = cartasPapaiNoelServices;
        }

        [HttpGet(Name = "ListarTodasAsCartasNoel")]
        public IActionResult ListarTodasAsCartasNoel()
        {
            try
            {
                return Ok(_cartasServices.ListarTodasAsCartasNoel());
            }
            catch
            {
                return BadRequest("Nenhum jogo salvo");
            }

        }

        [HttpPost(Name = "ReceberCartasNoel")]
        public IActionResult ReceberCartasNoel(NovaCartaPapaiNoelViewModel CartaNova)
        {
            _cartasServices.ReceberCartasNoel(CartaNova);
            return Ok("Jogo Registrado com sucesso!");
        }

    }
}
