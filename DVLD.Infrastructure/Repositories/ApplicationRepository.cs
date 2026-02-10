using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class ApplicationRepository : GenericRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(AppDbContext context) : base(context) { }

        public async Task<bool> HasActiveApplicationAsync(int personId, int applicationTypeId)
        {
            // Status 1 = New (Active)
            return await _context.Applications
                .AnyAsync(a => a.ApplicantPersonID == personId &&
                               a.ApplicationTypeID == applicationTypeId &&
                               a.ApplicationStatus == 1);
        }
    }
}
