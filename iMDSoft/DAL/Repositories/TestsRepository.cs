using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class TestsRepository : BaseRepository<Test>
    {
        public TestsRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Test>> GetAll()
        {
            return await _context.Tests.Include(t => t.Patient).ToListAsync();
        }
    }
}
