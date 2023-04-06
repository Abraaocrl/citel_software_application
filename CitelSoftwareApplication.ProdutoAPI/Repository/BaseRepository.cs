using CitelSoftwareApplication.ProdutoAPI.Model.Domain;
using CitelSoftwareApplication.ProdutoAPI.Repository.Context;
using CitelSoftwareApplication.ProdutoAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CitelSoftwareApplication.ProdutoAPI.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly MySQLContext _context;

        public BaseRepository(MySQLContext context)
        {
            _context = context;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
            => await _context.Set<T>().ToListAsync();

        public virtual async Task<T> GetByIdAsync(long id)
            => await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
