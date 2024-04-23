using Microsoft.EntityFrameworkCore;
using PersonelBlog.Domain.Entities.Common;
using System.Linq.Expressions;

namespace PersonelBlog.Application.Repositories;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity, new()
{
    DbSet<TEntity> Table { get; }
    Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes);
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes);
    Task<TEntity> GetByIdAsync(int id);
    Task AddAsync(TEntity entity);
    Task SaveChangeAsync();
}
