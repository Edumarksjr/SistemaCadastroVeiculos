using Microsoft.AspNetCore.Mvc;

namespace SistemaCadastroVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Visualizar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }

    }

}
