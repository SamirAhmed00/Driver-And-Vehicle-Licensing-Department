using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface ILicenseRules
    {
        // Checks if the license is currently active and has not exceeded its expiration date
        Result IsLicenseActive(bool isActive, DateTime expirationDate);

        // Validates if a license is eligible for renewal (usually when expired or near expiration)
        Result CanBeRenewed(DateTime expirationDate);

        // Checks if the license is currently under detention, which blocks further operations
        Task<Result> IsLicenseDetained(int licenseID);
    }
}
