using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class LicenseRepository : GenericRepository<License>, ILicenseRepository
    {
        public LicenseRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<License>> GetDriverLicensesAsync(int driverId)
        {
            return await _context.Licenses.Where(l => l.DriverID == driverId).ToListAsync();
        }

        public async Task<bool> IsLicenseDetainedAsync(int licenseId)
        {
            return await _context.DetainedLicenses.AnyAsync(d => d.LicenseID == licenseId && !d.IsReleased);
        }
    }
}
