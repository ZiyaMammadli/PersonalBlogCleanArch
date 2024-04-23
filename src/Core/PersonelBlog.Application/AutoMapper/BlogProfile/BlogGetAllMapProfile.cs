using AutoMapper;
using PersonelBlog.Application.Features.Commands.BlogCommands.BlogCreateResponse;
using PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetAllQueries;
using PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetByIdQueries;
using PersonelBlog.Domain.Entities;

namespace PersonelBlog.Application.AutoMapper.BlogProfile;

public class BlogGetAllMapProfile:Profile
{
    public BlogGetAllMapProfile()
    {
        CreateMap<Blog, BlogGetAllResponse>().ReverseMap();
        CreateMap<Blog, BlogGetByIdResponse>().ReverseMap();
        CreateMap<Blog, BlogCreateResponse>().ReverseMap();
        CreateMap<BlogCreateRequest,Blog>().ReverseMap();
        
    }
}
