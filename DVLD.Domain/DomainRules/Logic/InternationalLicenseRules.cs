using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class InternationalLicenseRules : IInternationalLicenseRules
    {
        private readonly IInternationalLicenseRepository _internationalLicenseRepository;

        public InternationalLicenseRules(IInternationalLicenseRepository internationalLicenseRepository)
        {
            _internationalLicenseRepository = internationalLicenseRepository;
        }

        public Result HasValidLocalLicense(bool isActive, int licenseClassID)
        {
            if (!isActive) return Result.Failure("Local license is not active.");

            // In DVLD, International License usually requires Class 3 (Ordinary Driving License)
            if (licenseClassID != 3)
                return Result.Failure("International license requires a Class 3 Ordinary Driving License.");

            return Result.Success();
        }

        public async Task<Result> HasActiveInternationalLicense(int driverID)
        {
            bool exists = await _internationalLicenseRepository.HasActiveInternationalLicenseAsync(driverID);
            return exists
                ? Result.Failure("Driver already has an active international license.")
                : Result.Success();
        }
    }
}
