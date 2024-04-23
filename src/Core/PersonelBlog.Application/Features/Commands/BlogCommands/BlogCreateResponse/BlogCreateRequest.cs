using MediatR;

namespace PersonelBlog.Application.Features.Commands.BlogCommands.BlogCreateResponse;

public class BlogCreateRequest:IRequest<BlogCreateResponse>
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public bool IsDeleted { get; set; }
}
