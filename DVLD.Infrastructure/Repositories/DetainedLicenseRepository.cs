using DVLD.Domain.Entities;
using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class DetainedLicenseRepository : GenericRepository<DetainedLicense>, IDetainedLicenseRepository
    {
        public DetainedLicenseRepository(AppDbContext context) : base(context) { }

        public async Task<DetainedLicense?> GetCurrentDetainedInfoByLicenseIdAsync(int licenseId)
        {
            return await _context.DetainedLicenses
                .FirstOrDefaultAsync(d => d.LicenseID == licenseId && !d.IsReleased);
        }
    }
}
