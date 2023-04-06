using CitelSoftwareApplication.Web.Models;
using CitelSoftwareApplication.Web.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CitelSoftwareApplication.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _service;

        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> CategoriaIndex()
        {
            var response = await _service.GetAllCategorias();

            return View(response);
        }

        public async Task<IActionResult> CategoriaCreate()
        {
            return View();
        }

        [HttpPost]
        [ActionName("CategoriaCreate")]
        public async Task<IActionResult> Create(CategoriaViewModel model)
        {
            try
            {
                var response = await _service.CreateCategoria(model);

                return RedirectToAction(nameof(CategoriaIndex));
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message.ToString();
                return View(model);
            }
        }

        public async Task<IActionResult> CategoriaUpdate(long id)
        {
            var response = await _service.GetCategoriaById(id);

            return View(response);
        }

        [HttpPost]
        [ActionName("CategoriaUpdate")]
        public async Task<IActionResult> Update(CategoriaViewModel model)
        {
            try
            {
                var response = await _service.UpdateCategoria(model);

                return RedirectToAction(nameof(CategoriaIndex));
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message.ToString();
                return View(model);
            }
        }

        public async Task<IActionResult> CategoriaDelete(long id)
        {
            var response = await _service.DeleteCategoria(id);

            return RedirectToAction(nameof(CategoriaIndex));
        }
    }
}
