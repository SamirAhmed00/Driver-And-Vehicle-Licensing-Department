using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface IDetentionRules
    {
        // Prevents detaining a license that is already currently detained
        Task<Result> IsAlreadyDetained(int licenseID);

        // Checks if a detained license is in a valid state to be released
        Result CanBeReleased(bool isReleased);
    }
}
