namespace CategoryTestApi.Infrastructure.Repositories;

public class SubjectRepository : ISubjectRepository
{
    private readonly DataContext _context;

    public SubjectRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Subject>> GetByCategoryIdAsync(long categoryId)
    {
        var subjects = await _context.Subjects
            .Where(o => o.CategoryId == categoryId)
            .ToListAsync();

        return subjects;
    }
}