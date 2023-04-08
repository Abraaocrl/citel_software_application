using CitelSoftwareApplication.CategoriaAPI.Model.Domain;

namespace CitelSoftwareApplication.CategoriaAPI.Repository.Interface
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<T> GetByIdAsync(long id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<int> GetCountAsync();
    }
}
