using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface IPersonRules
    {
        // Validates that the national number is not already assigned to another person
        Task<Result> IsNationalNoUnique(string nationalNo);

        // Validates that the person's age meets the minimum age requirement for a license class
        Result IsAgeValidForLicense(DateTime dateOfBirth, int minimumAge);
    }
}
