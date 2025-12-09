using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class PatientsRepository : BaseRepository<Patient>
    {
        public PatientsRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Patient>> GetAll()
        {
            return await _context.Patients.Include(p => p.Tests).ToListAsync();
        }
    }
}
