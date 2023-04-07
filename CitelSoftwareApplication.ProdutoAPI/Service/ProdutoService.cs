using CitelSoftwareApplication.ProdutoAPI.Data;
using CitelSoftwareApplication.ProdutoAPI.Model.Domain;
using CitelSoftwareApplication.ProdutoAPI.Repository.Interface;
using CitelSoftwareApplication.ProdutoAPI.Service.Interface;
using Mapster;

namespace CitelSoftwareApplication.ProdutoAPI.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProdutoDTO> Create(ProdutoDTO produtoDto)
        {
            return (await _repository.CreateAsync(produtoDto.Adapt<Produto>())).Adapt<ProdutoDTO>();
        }

        public async Task<bool> DeleteByIdAsync(long id)
        {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null) return false;

            return await _repository.DeleteAsync(produto);
        }

        public async Task<IEnumerable<ProdutoDTO>> GetAllAsync()
        {
            return (await _repository.GetAllAsync()).Adapt<IEnumerable<ProdutoDTO>>();
        }

        public async Task<ProdutoDTO> GetByIdAsync(long id)
        {
            var produtoDb = await _repository.GetByIdAsync(id);
            if (produtoDb == null)
            {
                throw new NotFoundException("Produto não encontrado");
            }

            return produtoDb.Adapt<ProdutoDTO>();
        }

        public async Task<ProdutoDTO> Update(ProdutoDTO produtoDto)
        {
            var produtoDb = await _repository.GetByIdAsync(produtoDto.Id);
            if (produtoDb == null)
            {
                throw new NotFoundException("Produto não encontrado");
            }

            return (await _repository.UpdateAsync(produtoDto.Adapt<Produto>())).Adapt<ProdutoDTO>();
        }
    }
}
