using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface IInternationalLicenseRepository : IGenericRepository<InternationalLicense>
    {
        Task<bool> HasActiveInternationalLicenseAsync(int driverId);
    }
}
