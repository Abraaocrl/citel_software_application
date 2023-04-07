using System.ComponentModel.DataAnnotations.Schema;

namespace CitelSoftwareApplication.CategoriaAPI.Data
{
    public class CategoriaDTO
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
