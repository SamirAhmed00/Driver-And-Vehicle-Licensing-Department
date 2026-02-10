using DVLD.Domain.Entities;
using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class DriverRepository : GenericRepository<Driver>, IDriverRepository
    {
        public DriverRepository(AppDbContext context) : base(context) { }

        public async Task<Driver?> GetByPersonIdAsync(int personId)
        {
            return await _context.Drivers.FirstOrDefaultAsync(d => d.PersonID == personId);
        }
    }
}
