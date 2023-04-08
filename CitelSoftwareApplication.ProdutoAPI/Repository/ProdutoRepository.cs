using CitelSoftwareApplication.ProdutoAPI.Model.Domain;
using CitelSoftwareApplication.ProdutoAPI.Repository.Context;
using CitelSoftwareApplication.ProdutoAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CitelSoftwareApplication.ProdutoAPI.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MySQLContext context) : base(context)
        {
        }
    }
}
