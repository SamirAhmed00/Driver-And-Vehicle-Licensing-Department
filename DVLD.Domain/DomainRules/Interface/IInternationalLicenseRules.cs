using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface IInternationalLicenseRules
    {
        // Ensures the driver has a valid and active local license (usually Class 3) to get an international one
        Result HasValidLocalLicense(bool isActive, int licenseClassID);

        // Prevents issuing a new international license if the driver already has an active one
        Task<Result> HasActiveInternationalLicense(int driverID);
    }
}
