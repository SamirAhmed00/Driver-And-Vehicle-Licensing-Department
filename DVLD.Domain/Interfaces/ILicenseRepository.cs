using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface ILicenseRepository : IGenericRepository<License>
    {
        Task<IEnumerable<License>> GetDriverLicensesAsync(int driverId);
        Task<bool> IsLicenseDetainedAsync(int licenseId);
    }
}
