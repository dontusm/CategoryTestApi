namespace CategoryTestApi.Domain.Models;

public class Category : BaseModel
{
    public string Name { get; set; }
    
    public IEnumerable<Subject> Objects { get; set; }
}