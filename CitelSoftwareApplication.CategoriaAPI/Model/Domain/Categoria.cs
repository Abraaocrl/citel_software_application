using System.ComponentModel.DataAnnotations.Schema;

namespace CitelSoftwareApplication.CategoriaAPI.Model.Domain
{
    public class Categoria : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }
    }
}
