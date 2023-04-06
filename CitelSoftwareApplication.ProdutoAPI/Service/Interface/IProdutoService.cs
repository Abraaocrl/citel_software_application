using CitelSoftwareApplication.ProdutoAPI.Model.Domain;

namespace CitelSoftwareApplication.ProdutoAPI.Service.Interface
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAllAsync();

        Task<Produto> GetByIdAsync(long id);

        Task<Produto> Create(Produto produto);

        Task<Produto> Update(Produto produto);

        Task<bool> DeleteByIdAsync(long id);
    }
}
