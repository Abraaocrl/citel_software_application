using System.ComponentModel.DataAnnotations;

namespace CitelSoftwareApplication.Web.Models
{
    public class CategoriaViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de descrição é obrigatório")]
        public string Descricao { get; set; }
    }
}
