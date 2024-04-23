using AutoMapper;
using MediatR;
using PersonelBlog.Application.Exceptions.Common;
using PersonelBlog.Application.Repositories;

namespace PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetByIdQueries;

public class BlogGetByIdHandler : IRequestHandler<BlogGetByIdRequest, BlogGetByIdResponse>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    public BlogGetByIdHandler(IBlogRepository blogRepository,IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<BlogGetByIdResponse> Handle(BlogGetByIdRequest request, CancellationToken cancellationToken)
    {
        var blog = await _blogRepository.GetByIdAsync(request.Id);
        if (blog is null) throw new NotFoundException(404, "Blog is not found");
       return _mapper.Map<BlogGetByIdResponse>(blog);
    }
}
