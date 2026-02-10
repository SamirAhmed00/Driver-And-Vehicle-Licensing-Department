using DVLD.Domain.Entities;
using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class InternationalLicenseRepository : GenericRepository<InternationalLicense>, IInternationalLicenseRepository
    {
        public InternationalLicenseRepository(AppDbContext context) : base(context) { }

        public async Task<bool> HasActiveInternationalLicenseAsync(int driverId)
        {
            return await _context.InternationalLicenses
                .AnyAsync(il => il.DriverID == driverId && il.IsActive);
        }
    }
}
