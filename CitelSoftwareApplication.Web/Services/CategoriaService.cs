using CitelSoftwareApplication.Web.Models;
using CitelSoftwareApplication.Web.Services.Interface;
using CitelSoftwareApplication.Web.Util;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Headers;
using System.Reflection;

namespace CitelSoftwareApplication.Web.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/categoria";

        public CategoriaService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<CategoriaViewModel> CreateCategoria(CategoriaViewModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CategoriaViewModel>();
            else throw new Exception(await response.ReadContentAs<string>());
        }

        public async Task<bool> DeleteCategoria(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return true;
            else throw new Exception(await response.ReadContentAs<string>());
        }

        public async Task<IEnumerable<CategoriaViewModel>> GetAllCategorias()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<CategoriaViewModel>>();
        }

        public async Task<CategoriaViewModel> GetCategoriaById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<CategoriaViewModel>();
        }

        public async Task<CategoriaViewModel> UpdateCategoria(CategoriaViewModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CategoriaViewModel>();
            else throw new Exception(await response.ReadContentAs<string>());
        }

        public async Task<IEnumerable<SelectListItem>> GetOpcaoCategorias()
        {
            var categorias = await GetAllCategorias();

            return categorias.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nome
            });
        }

        public async Task<int> GetContagemCategoria()
        {
            var response = await _client.GetAsync($"{BasePath}/contagem");
            return await response.ReadContentAs<int>();
        }
    }
}
