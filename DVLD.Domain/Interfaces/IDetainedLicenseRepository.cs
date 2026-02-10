using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface IDetainedLicenseRepository : IGenericRepository<DetainedLicense>
    {
        Task<DetainedLicense?> GetCurrentDetainedInfoByLicenseIdAsync(int licenseId);
    }
}
