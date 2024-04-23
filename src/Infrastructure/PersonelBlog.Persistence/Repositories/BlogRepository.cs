using PersonelBlog.Application.Repositories;
using PersonelBlog.Domain.Entities;
using PersonelBlog.Persistence.Contexts;

namespace PersonelBlog.Persistence.Repositories;

public class BlogRepository : GenericRepository<Blog>, IBlogRepository
{
    public BlogRepository(PersonelBlogDb context) : base(context)
    {
    }
}
