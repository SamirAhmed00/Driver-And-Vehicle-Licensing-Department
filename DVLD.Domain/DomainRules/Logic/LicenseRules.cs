using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class LicenseRules : ILicenseRules
    {
        private readonly ILicenseRepository _licenseRepository;

        public LicenseRules(ILicenseRepository licenseRepository)
        {
            _licenseRepository = licenseRepository;
        }

        public async Task<Result> IsLicenseDetained(int licenseID)
        {
            bool isDetained = await _licenseRepository.IsLicenseDetainedAsync(licenseID);
            return isDetained ? Result.Failure("License is currently detained.") : Result.Success();
        }

        public Result IsLicenseActive(bool isActive, DateTime expirationDate)
        {
            if (!isActive) return Result.Failure("License is not active.");
            if (expirationDate < DateTime.Now) return Result.Failure("License has expired.");
            return Result.Success();
        }

        public Result CanBeRenewed(DateTime expirationDate)
        {
            return expirationDate <= DateTime.Now
                ? Result.Success()
                : Result.Failure("License is still valid and cannot be renewed yet.");
        }
    }
}
