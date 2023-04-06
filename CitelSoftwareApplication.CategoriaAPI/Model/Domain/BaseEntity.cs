using System.ComponentModel.DataAnnotations.Schema;

namespace CitelSoftwareApplication.CategoriaAPI.Model.Domain
{
    public abstract class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
