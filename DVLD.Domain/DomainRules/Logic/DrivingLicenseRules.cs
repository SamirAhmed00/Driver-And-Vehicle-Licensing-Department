using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class DrivingLicenseRules : IDrivingLicenseRules
    {
        private readonly ILicenseRepository _licenseRepository;

        public DrivingLicenseRules(ILicenseRepository licenseRepository)
        {
            _licenseRepository = licenseRepository;
        }

        public async Task<Result> IsPersonEligibleToDrive(int personID)
        {
            // Business: Check if the person has any active licenses or legal bans
            // This can be expanded to check for suspensions in the DB
            return Result.Success();
        }

        public Result IsLicenseClassCompatible(int currentClass, int requiredClass)
        {
            // Logic for moving from Class 1 to Class 2 etc.
            return Result.Success();
        }

        public Result CanHoldMultipleLicenseClasses(int driverID, int newLicenseClassID)
        {
            return Result.Success();
        }
    }
}
