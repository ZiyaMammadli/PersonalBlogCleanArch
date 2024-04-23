using FluentValidation;
using PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetByIdQueries;

namespace PersonelBlog.Application.Features.Commands.BlogCommands.BlogCreateResponse;

public class BlogCreateResponse
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Desc { get; set; }
    public bool IsDeleted { get; set; }
}


//public class BlogCreateResponseValidator : AbstractValidator<BlogGetByIdResponse>
//{
//    public BlogGetByIdResponseValidator()
//    {
//        RuleFor(b => b.Id)
//            .NotEmpty()
//            .NotNull()
//            .GreaterThan(0)
//            .WithMessage("Id must be up than 0");

//        RuleFor(b => b.Title)
//            .NotEmpty()
//            .NotNull()
//            .MaximumLength(75)
//            .MinimumLength(1)
//            .WithMessage("Titile must be between 1 and 75");

//        RuleFor(b => b.Desc)
//            .NotEmpty()
//            .NotNull()
//            .MaximumLength(400)
//            .MinimumLength(1)
//            .WithMessage("Titile must be between 1 and 400");

//    }
//}