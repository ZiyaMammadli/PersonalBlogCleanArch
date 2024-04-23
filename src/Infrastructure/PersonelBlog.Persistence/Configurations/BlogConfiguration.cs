using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonelBlog.Domain.Entities;

namespace PersonelBlog.Persistence.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.Property(b => b.Title).IsRequired().HasMaxLength(75);
        builder.Property(b => b.Desc).IsRequired().HasMaxLength(400);

    }
}
 