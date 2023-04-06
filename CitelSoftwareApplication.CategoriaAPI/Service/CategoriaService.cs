using CitelSoftwareApplication.CategoriaAPI.Model.Domain;
using CitelSoftwareApplication.CategoriaAPI.Repository.Interface;
using CitelSoftwareApplication.CategoriaAPI.Service.Interface;

namespace CitelSoftwareApplication.CategoriaAPI.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<Categoria> Create(Categoria categoria)
        {
            return await _repository.CreateAsync(categoria);
        }

        public async Task<bool> DeleteByIdAsync(long id)
        {
            var categoria = await _repository.GetByIdAsync(id);
            if (categoria == null) return false;

            return await _repository.DeleteAsync(categoria);
        }

        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Categoria> GetByIdAsync(long id)
        {
            var categoriaDb = await _repository.GetByIdAsync(id);
            if (categoriaDb == null)
            {
                throw new NotFoundException("Categoria não encontrada");
            }

            return categoriaDb;
        }

        public async Task<Categoria> Update(Categoria categoria)
        {
            var categoriaDb = await _repository.GetByIdAsync(categoria.Id);
            if(categoriaDb == null)
            {
                throw new NotFoundException("Categoria não encontrada");
            }

            return await _repository.UpdateAsync(categoria);
        }
    }
}
