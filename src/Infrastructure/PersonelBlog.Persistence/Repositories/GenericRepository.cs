using Microsoft.EntityFrameworkCore;
using PersonelBlog.Application.Repositories;
using PersonelBlog.Domain.Entities.Common;
using PersonelBlog.Persistence.Contexts;
using System.Linq.Expressions;

namespace PersonelBlog.Persistence.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
{
    private readonly PersonelBlogDb _context;
    public GenericRepository(PersonelBlogDb context)
    {
        _context = context;
    }
    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task AddAsync(TEntity entity)
    {
        await Table.AddAsync(entity);
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes)
    {
        var query = Table.AsQueryable();
        if (includes is not null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        return expression is not null
              ? await query.Where(expression).ToListAsync()
              : await query.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await Table.FindAsync(id);
    }

    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes)
    {
        var query = Table.AsQueryable();
        if (includes is not null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        return expression is not null
              ? await query.Where(expression).FirstOrDefaultAsync()
              : await query.FirstOrDefaultAsync();
    }

    public async Task SaveChangeAsync()
    {
        await _context.SaveChangesAsync();
    }
}
