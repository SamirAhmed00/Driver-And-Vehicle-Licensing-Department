using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class DetentionRules : IDetentionRules
    {
        private readonly ILicenseRepository _licenseRepository;

        public DetentionRules(ILicenseRepository licenseRepository)
        {
            _licenseRepository = licenseRepository;
        }

        public async Task<Result> IsAlreadyDetained(int licenseID)
        {
            bool isDetained = await _licenseRepository.IsLicenseDetainedAsync(licenseID);
            return isDetained ? Result.Failure("License is already detained.") : Result.Success();
        }

        public Result CanBeReleased(bool isReleased)
        {
            return !isReleased ? Result.Success() : Result.Failure("License is already released.");
        }
    }
}
