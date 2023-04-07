using CitelSoftwareApplication.Web.Models;
using CitelSoftwareApplication.Web.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CitelSoftwareApplication.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ICategoriaService _categoriaService;

        public ProdutoController(IProdutoService produtoService, ICategoriaService categoriaService)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
        }

        public async Task<IActionResult> ProdutoIndex()
        {
            var response = await _produtoService.GetAllProduto();

            return View(response);
        }

        public IActionResult ProdutoCreate()
        {
            return View();
        }

        [HttpPost]
        [ActionName("ProdutoCreate")]
        public async Task<IActionResult> Create(ProdutoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var categoria = await _categoriaService.GetCategoriaById(model.CategoriaId ?? 0);
                    if (categoria == null)
                    {
                        throw new Exception("Categoria não existe, verifique na tela de categorias.");
                    }

                    model.CategoriaNome = categoria.Nome;
                    var response = await _produtoService.CreateProduto(model);
                    return RedirectToAction(nameof(ProdutoIndex));
                }

                return View(model);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message.ToString();
                return View(model);
            }
        }

        public async Task<IActionResult> ProdutoUpdate(long id)
        {
            var response = await _produtoService.GetProdutoById(id);

            return View(response);
        }

        [HttpPost]
        [ActionName("ProdutoUpdate")]
        public async Task<IActionResult> Update(ProdutoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var categoria = await _categoriaService.GetCategoriaById(model.CategoriaId ?? 0);
                    if (categoria == null)
                    {
                        throw new Exception("Categoria não existe, verifique na tela de categorias.");
                    }

                    model.CategoriaNome = categoria.Nome;
                    var response = await _produtoService.UpdateProduto(model);
                    return RedirectToAction(nameof(ProdutoIndex));
                }

                return View(model);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message.ToString();
                return View(model);
            }
        }

        public async Task<IActionResult> ProdutoDelete(long id)
        {
            var response = await _produtoService.DeleteProduto(id);

            return RedirectToAction(nameof(ProdutoIndex));
        }
    }
}
