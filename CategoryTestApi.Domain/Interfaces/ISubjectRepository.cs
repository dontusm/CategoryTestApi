namespace CategoryTestApi.Domain.Interfaces;

public interface ISubjectRepository
{
    public Task<IEnumerable<Subject>> GetByCategoryIdAsync(long categoryId);
}