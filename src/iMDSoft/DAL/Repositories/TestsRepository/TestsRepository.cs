using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.TestsRepository
{
    public class TestsRepository : BaseRepository<Test>
    {
        public TestsRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await _context.Tests.Include(t => t.Patient).ToListAsync();
        }
    }
}
