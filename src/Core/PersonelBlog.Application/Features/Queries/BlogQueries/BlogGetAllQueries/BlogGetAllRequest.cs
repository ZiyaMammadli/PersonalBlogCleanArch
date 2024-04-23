using MediatR;

namespace PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetAllQueries;

public class BlogGetAllRequest : IRequest<List<BlogGetAllResponse>>
{

}
