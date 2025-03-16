namespace CategoryTestApi.Application.Services;

public class SubjectService : ISubjectService
{
    private readonly ISubjectRepository _repository;

    public SubjectService(ISubjectRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Subject>> GetByCategoryAsync(long id)
    {
        var subjects = await _repository.GetByCategoryIdAsync(id);
        
        return subjects;
    }
}