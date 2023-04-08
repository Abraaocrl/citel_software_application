using CitelSoftwareApplication.CategoriaAPI.Data;
using CitelSoftwareApplication.CategoriaAPI.Model.Domain;

namespace CitelSoftwareApplication.CategoriaAPI.Service.Interface
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> GetAllAsync();

        Task<CategoriaDTO> GetByIdAsync(long id);

        Task<CategoriaDTO> Create(CategoriaDTO produto);

        Task<CategoriaDTO> Update(CategoriaDTO produto);

        Task<bool> DeleteByIdAsync(long id);

        Task<int> GetContagemAsync();
    }
}
