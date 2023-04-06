using CitelSoftwareApplication.Web.Models;
using CitelSoftwareApplication.Web.Services.Interface;
using CitelSoftwareApplication.Web.Util;
using System.Reflection;

namespace CitelSoftwareApplication.Web.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/produto";

        public ProdutoService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<ProdutoViewModel> CreateProduto(ProdutoViewModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProdutoViewModel>();
            else throw new Exception(await response.ReadContentAs<string>());
        }

        public async Task<bool> DeleteProduto(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return true;
            else throw new Exception(await response.ReadContentAs<string>());
        }

        public async Task<IEnumerable<ProdutoViewModel>> GetAllProduto()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProdutoViewModel>>();
        }

        public async Task<ProdutoViewModel> GetProdutoById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProdutoViewModel>();
        }

        public async Task<ProdutoViewModel> UpdateProduto(ProdutoViewModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProdutoViewModel>();
            else throw new Exception(await response.ReadContentAs<string>());
        }
    }
}
