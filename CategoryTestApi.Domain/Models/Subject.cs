namespace CategoryTestApi.Domain.Models;

public class Subject : BaseModel
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }
    
    public long CategoryId { get; set; }
    
    public Category Category { get; set; }
}