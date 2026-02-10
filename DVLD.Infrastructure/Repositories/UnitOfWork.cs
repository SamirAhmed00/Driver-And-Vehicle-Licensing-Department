using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IPersonRepository People { get; }
        public IUserRepository Users { get; }
        public IApplicationRepository Applications { get; }
        public IDriverRepository Drivers { get; }
        public ILicenseRepository Licenses { get; }
        public ITestAppointmentRepository TestAppointments { get; }
        public IDetainedLicenseRepository DetainedLicenses { get; }
        public IInternationalLicenseRepository InternationalLicenses { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            People = new PersonRepository(_context);
            Users = new UserRepository(_context);
            Applications = new ApplicationRepository(_context);
            Drivers = new DriverRepository(_context);
            Licenses = new LicenseRepository(_context);
            TestAppointments = new TestAppointmentRepository(_context);
            DetainedLicenses = new DetainedLicenseRepository(_context);
            InternationalLicenses = new InternationalLicenseRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
