using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface ITestAppointmentRepository : IGenericRepository<TestAppointment>
    {
        Task<IEnumerable<TestAppointment>> GetApplicationAppointmentsPerTestTypeAsync(int localApplicationId, int testTypeId);
        Task<bool> HasActiveAppointmentAsync(int localApplicationId, int testTypeId);
    }
}
