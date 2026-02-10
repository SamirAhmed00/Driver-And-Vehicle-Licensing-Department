using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository People { get; }
        IUserRepository Users { get; }
        IApplicationRepository Applications { get; }
        IDriverRepository Drivers { get; }
        ILicenseRepository Licenses { get; }
        ITestAppointmentRepository TestAppointments { get; }
        IDetainedLicenseRepository DetainedLicenses { get; }
        IInternationalLicenseRepository InternationalLicenses { get; }

        // This will commit all changes in one transaction
        Task<int> CompleteAsync();
    }
}
