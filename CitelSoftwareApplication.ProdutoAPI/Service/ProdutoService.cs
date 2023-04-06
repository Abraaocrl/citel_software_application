using CitelSoftwareApplication.ProdutoAPI.Model.Domain;
using CitelSoftwareApplication.ProdutoAPI.Repository.Interface;
using CitelSoftwareApplication.ProdutoAPI.Service.Interface;

namespace CitelSoftwareApplication.ProdutoAPI.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Produto> Create(Produto produto)
        {
            return await _repository.CreateAsync(produto);
        }

        public async Task<bool> DeleteByIdAsync(long id)
        {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null) return false;

            return await _repository.DeleteAsync(produto);
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Produto> GetByIdAsync(long id)
        {
            var produtoDb = await _repository.GetByIdAsync(id);
            if (produtoDb == null)
            {
                throw new NotFoundException("Produto não encontrado");
            }

            return produtoDb;
        }

        public async Task<Produto> Update(Produto produto)
        {
            var produtoDb = await _repository.GetByIdAsync(produto.Id);
            if(produtoDb == null)
            {
                throw new NotFoundException("Produto não encontrado");
            }

            return await _repository.UpdateAsync(produto);
        }
    }
}
