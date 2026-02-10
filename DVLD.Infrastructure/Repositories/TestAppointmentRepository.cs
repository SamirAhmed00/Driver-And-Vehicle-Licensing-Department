using DVLD.Domain.Entities;
using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class TestAppointmentRepository : GenericRepository<TestAppointment>, ITestAppointmentRepository
    {
        public TestAppointmentRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<TestAppointment>> GetApplicationAppointmentsPerTestTypeAsync(int localApplicationId, int testTypeId)
        {
            return await _context.TestAppointments
                .Where(ta => ta.LocalDrivingLicenseApplicationID == localApplicationId && ta.TestTypeID == testTypeId)
                .ToListAsync();
        }

        public async Task<bool> HasActiveAppointmentAsync(int localApplicationId, int testTypeId)
        {
            return await _context.TestAppointments
                .AnyAsync(ta => ta.LocalDrivingLicenseApplicationID == localApplicationId &&
                               ta.TestTypeID == testTypeId && !ta.IsLocked);
        }
    }
}
