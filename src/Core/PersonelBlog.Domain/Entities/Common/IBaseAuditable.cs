namespace PersonelBlog.Domain.Entities.Common;

public interface IBaseAuditable
{
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
