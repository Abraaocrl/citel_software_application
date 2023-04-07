using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitelSoftwareApplication.Web.Models
{
    public class ProdutoViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo de preço é obrigatório")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "O campo de categoria é obrigatório")]
        public long? CategoriaId { get; set; }

        public string? CategoriaNome { get; set; }
    }
}
