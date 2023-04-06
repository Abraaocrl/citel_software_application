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

        public decimal Preco { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Por favor, selecione uma categoria.")]
        public long CategoriaId { get; set; }

        public string? CategoriaNome { get; set; }
    }
}
