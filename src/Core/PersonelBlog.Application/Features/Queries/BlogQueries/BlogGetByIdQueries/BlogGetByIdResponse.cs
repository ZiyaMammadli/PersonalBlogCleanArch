using FluentValidation;

namespace PersonelBlog.Application.Features.Queries.BlogQueries.BlogGetByIdQueries;

public class BlogGetByIdResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
}

public class BlogGetByIdResponseValidator : AbstractValidator<BlogGetByIdResponse>
{
    public BlogGetByIdResponseValidator()
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