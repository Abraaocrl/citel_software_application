using CitelSoftwareApplication.CategoriaAPI.Model.Domain;

namespace CitelSoftwareApplication.CategoriaAPI.Service.Interface
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAllAsync();

        Task<Categoria> GetByIdAsync(long id);

        Task<Categoria> Create(Categoria produto);

        Task<Categoria> Update(Categoria produto);

        Task<bool> DeleteByIdAsync(long id);
    }
}
