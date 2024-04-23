using PersonelBlog.Domain.Entities.Common;

namespace PersonelBlog.Domain.Entities;

public class Blog:BaseEntity,IBaseAuditable
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
