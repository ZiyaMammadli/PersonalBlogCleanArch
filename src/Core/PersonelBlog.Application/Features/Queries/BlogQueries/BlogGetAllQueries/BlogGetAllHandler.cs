using AutoMapper;
using MediatR;
using PersonelBlog.Application.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetAllQueries;

public class BlogGetAllHandler : IRequestHandler<BlogGetAllRequest, List<BlogGetAllResponse>>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    public BlogGetAllHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<List<BlogGetAllResponse>> Handle(BlogGetAllRequest request, CancellationToken cancellationToken)
    {
        var blogs = await _blogRepository.GetAllAsync();

        List<BlogGetAllResponse> blogGetAllResponses = new List<BlogGetAllResponse>();
        foreach (var blog in blogs)
        {
            var blogGetAllResponse = _mapper.Map<BlogGetAllResponse>(blog);
            blogGetAllResponses.Add(blogGetAllResponse);
        }
        return blogGetAllResponses;
    }
}
