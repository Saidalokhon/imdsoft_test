using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.PatientsRepository
{
    public class PatientsRepository : BaseRepository<Patient>
    {
        public PatientsRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await _context.Patients.Include(p => p.Tests).ToListAsync();
        }
    }
}
