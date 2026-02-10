using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface IDrivingLicenseRules
    {
        // Checks if the person is legally eligible to hold a driving license (not banned/suspended)
        Task<Result> IsPersonEligibleToDrive(int personID);

        // Validates if the requested license class is compatible with the person's current qualifications
        Result IsLicenseClassCompatible(int currentClass, int requiredClass);

        // Validates if a driver is allowed to hold multiple license classes simultaneously
        Result CanHoldMultipleLicenseClasses(int driverID, int newLicenseClassID);
    }
}
