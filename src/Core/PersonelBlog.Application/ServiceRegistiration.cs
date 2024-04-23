using Microsoft.Extensions.DependencyInjection;
using PersonelBlog.Application.AutoMapper.BlogProfile;
using PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetAllQueries;
using System.Reflection;

namespace PersonelBlog.Application;

public static class ServiceRegistiration
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(BlogGetAllMapProfile).Assembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(BlogGetAllRequest).Assembly));
    }
}
