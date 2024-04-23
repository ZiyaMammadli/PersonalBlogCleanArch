using Microsoft.EntityFrameworkCore;
using PersonelBlog.Domain.Entities;
using PersonelBlog.Persistence.Configurations;

namespace PersonelBlog.Persistence.Contexts;

public class PersonelBlogDb:DbContext
{
    public PersonelBlogDb(DbContextOptions<PersonelBlogDb> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Blog> blogs { get; set; }
}
