namespace CategoryTestApi.Application.Interfaces;

public interface ISubjectService
{
    public Task<IEnumerable<Subject>> GetByCategoryAsync(long id);
}