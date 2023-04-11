using CitelSoftwareApplication.ProdutoAPI.Data;
using CitelSoftwareApplication.ProdutoAPI.Model.Domain;

namespace CitelSoftwareApplication.ProdutoAPI.Service.Interface
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDTO>> GetAllAsync();

        Task<ProdutoDTO> GetByIdAsync(long id);

        Task<ProdutoDTO> Create(ProdutoDTO produtoDto);

        Task<ProdutoDTO> Update(ProdutoDTO produtoDto);

        Task<bool> DeleteByIdAsync(long id);

        Task<int> GetContagemAsync();
    }
}
