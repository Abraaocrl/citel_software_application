using CitelSoftwareApplication.CategoriaAPI.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace CitelSoftwareApplication.CategoriaAPI.Repository.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
