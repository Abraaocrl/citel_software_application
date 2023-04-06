using CitelSoftwareApplication.Web.Models;

namespace CitelSoftwareApplication.Web.Services.Interface
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoViewModel>> GetAllProduto();

        Task<ProdutoViewModel> GetProdutoById(long id);

        Task<ProdutoViewModel> CreateProduto(ProdutoViewModel model);

        Task<ProdutoViewModel> UpdateProduto(ProdutoViewModel model);

        Task<bool> DeleteProduto(long id);
    }
}
