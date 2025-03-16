namespace CategoryTestApi.Web.Controllers;

[ApiController]
[Route("api/subjects")]
public class SubjectController : ControllerBase
{
    private readonly ISubjectRepository _repository;

    public SubjectController(ISubjectRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("by-category/{categoryId}")]
    
    public async Task<IActionResult> GetByCategoryAsync(long categoryId)
    {
        var subjects = await _repository.GetByCategoryIdAsync(categoryId);
        
        return Ok(subjects);
    }
    
}