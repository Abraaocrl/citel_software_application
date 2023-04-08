using CitelSoftwareApplication.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CitelSoftwareApplication.Web.Services.Interface
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaViewModel>> GetAllCategorias();

        Task<IEnumerable<SelectListItem>> GetOpcaoCategorias();

        Task<CategoriaViewModel> GetCategoriaById(long id);

        Task<CategoriaViewModel> CreateCategoria(CategoriaViewModel model);

        Task<CategoriaViewModel> UpdateCategoria(CategoriaViewModel model);

        Task<bool> DeleteCategoria(long id);

        Task<int> GetContagemCategoria();
    }
}
