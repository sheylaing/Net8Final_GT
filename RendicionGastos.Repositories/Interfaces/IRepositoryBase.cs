using RendicionGastos.Entities;
using System.Linq.Expressions;

namespace RendicionGastos.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : EntidadBase
    {
        Task<ICollection<TEntity>> ListAsync();

        Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicado);

        Task<ICollection<TInfo>> ListAsync<TInfo>(Expression<Func<TEntity, bool>> predicado,
            Expression<Func<TEntity, TInfo>> selector,
            string? relaciones = null);

        Task<(ICollection<TInfo> Collection, int Total)> ListAsync<TInfo, TKey>(
            Expression<Func<TEntity, bool>> predicado,
            Expression<Func<TEntity, TInfo>> selector,
            Expression<Func<TEntity, TKey>> orderBy,
            string? relaciones = null,
            int pagina = 1,
            int filas = 5);

        Task<TEntity?> FindByIdAsync(int id);

        Task AddAsync(TEntity entity);

        Task UpdateAsync();

        Task DeleteAsync(int id);
    }
}
