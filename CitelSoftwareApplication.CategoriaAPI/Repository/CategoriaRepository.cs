using CitelSoftwareApplication.CategoriaAPI.Model.Domain;
using CitelSoftwareApplication.CategoriaAPI.Repository.Context;
using CitelSoftwareApplication.CategoriaAPI.Repository.Interface;

namespace CitelSoftwareApplication.CategoriaAPI.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(MySQLContext context) : base(context)
        {
        }
    }
}
