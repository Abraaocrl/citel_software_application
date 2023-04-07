using Mapster;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitelSoftwareApplication.ProdutoAPI.Data
{
    public class ProdutoDTO
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public long CategoriaId { get; set; }

        public string? CategoriaNome { get; set; }
    }
}
