using MediatR;

namespace PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetByIdQueries;

public class BlogGetByIdRequest : IRequest<BlogGetByIdResponse>
{
    public int Id { get; set; }
}
