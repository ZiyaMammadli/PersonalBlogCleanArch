using FluentValidation;

namespace PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetAllQueries;

public class BlogGetAllResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }

}


public class BlogGetAllResponseValidator : AbstractValidator<BlogGetAllResponse>
{
    public BlogGetAllResponseValidator()
    {
        RuleFor(b => b.Id)
            .NotEmpty()
            .NotNull()
            .GreaterThan(0)
            .WithMessage("Id must be up than 0");

        RuleFor(b => b.Title)
            .NotEmpty()
            .NotNull()
            .MaximumLength(75)
            .MinimumLength(1)
            .WithMessage("Titile must be between 1 and 75");

        RuleFor(b => b.Desc)
            .NotEmpty()
            .NotNull()
            .MaximumLength(400)
            .MinimumLength(1)
            .WithMessage("Titile must be between 1 and 400");

    }
}