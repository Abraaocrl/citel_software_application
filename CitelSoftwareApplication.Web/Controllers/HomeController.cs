using CitelSoftwareApplication.Web.Models;
using CitelSoftwareApplication.Web.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CitelSoftwareApplication.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoriaService _categoriaService;
        private readonly IProdutoService _produtoService;

        public HomeController(ILogger<HomeController> logger, ICategoriaService categoriaService, IProdutoService produtoService)
        {
            _logger = logger;
            _categoriaService = categoriaService;
            _produtoService = produtoService;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new()
            {
                ContagemCategorias = await _categoriaService.GetContagemCategoria(),
                ContagemProdutos = await _produtoService.GetContagemProduto()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}