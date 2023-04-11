using System.ComponentModel.DataAnnotations;

namespace CitelSoftwareApplication.Web.Models
{
    public class CategoriaViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        public string Descricao { get; set; }
    }
}
