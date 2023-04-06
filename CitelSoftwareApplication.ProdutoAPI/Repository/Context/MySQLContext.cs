using CitelSoftwareApplication.ProdutoAPI.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace CitelSoftwareApplication.ProdutoAPI.Repository.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
