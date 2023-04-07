using Mapster;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitelSoftwareApplication.ProdutoAPI.Model.Domain
{
    public class Produto : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("preco")]
        public decimal Preco { get; set; }

        [Column("categoria_id")]
        public long CategoriaId { get; set; }

        [Column("categoria_nome")]
        public string CategoriaNome { get; set; }
    }
}
