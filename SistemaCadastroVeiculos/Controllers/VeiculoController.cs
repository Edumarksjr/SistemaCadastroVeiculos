using Microsoft.AspNetCore.Mvc;
using SistemaCadastroVeiculos.Models;
using SistemaCadastroVeiculos.Repositorio;
using System.Collections.Generic;

namespace SistemaCadastroVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculosRepositorio _veiculoRepositorio;
        public VeiculoController(IVeiculosRepositorio veiculorepositorio)
        {
            _veiculoRepositorio = veiculorepositorio;  
        }
        public IActionResult Index()
        {
            List<VeiculoModel> veiculos = _veiculoRepositorio.BuscarTodos();
            return View(veiculos);
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
        [HttpPost]
         public IActionResult criar(VeiculoModel veiculo)
        {
            _veiculoRepositorio.Adicionar(veiculo);
            return RedirectToAction("Index");

        }

    }

}
