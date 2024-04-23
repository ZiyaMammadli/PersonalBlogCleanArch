using AutoMapper;
using MediatR;
using PersonelBlog.Application.Repositories;
using PersonelBlog.Domain.Entities;

namespace PersonelBlog.Application.Features.Commands.BlogCommands.BlogCreateResponse;

public class BlogCreateHandler : IRequestHandler<BlogCreateRequest, BlogCreateResponse>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    public BlogCreateHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<BlogCreateResponse> Handle(BlogCreateRequest request, CancellationToken cancellationToken)
    {
        var blog=_mapper.Map<Blog>(request);
        blog.CreatedDate = DateTime.UtcNow;
        blog.UpdatedDate = DateTime.UtcNow;
        await _blogRepository.AddAsync(blog);
        await _blogRepository.SaveChangeAsync();
        return _mapper.Map<BlogCreateResponse>(blog);
    }
}
