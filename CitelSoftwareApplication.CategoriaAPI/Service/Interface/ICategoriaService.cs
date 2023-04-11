using CitelSoftwareApplication.CategoriaAPI.Data;
using CitelSoftwareApplication.CategoriaAPI.Model.Domain;

namespace CitelSoftwareApplication.CategoriaAPI.Service.Interface
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> GetAllAsync();

        Task<CategoriaDTO> GetByIdAsync(long id);

        Task<CategoriaDTO> Create(CategoriaDTO categoriaDto);

        Task<CategoriaDTO> Update(CategoriaDTO categoriaDto);

        Task<bool> DeleteByIdAsync(long id);

        Task<int> GetContagemAsync();
    }
}
