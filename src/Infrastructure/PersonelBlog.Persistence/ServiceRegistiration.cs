using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonelBlog.Application.Repositories;
using PersonelBlog.Persistence.Contexts;
using PersonelBlog.Persistence.Repositories;

namespace PersonelBlog.Persistence;

public static class ServiceRegistiration
{
    public static void AddRepositories(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<PersonelBlogDb>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("default"));
        });

        services.AddScoped<IBlogRepository, BlogRepository>();
    }
}
