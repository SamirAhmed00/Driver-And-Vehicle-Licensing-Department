using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface IApplicationRules
    {
        // Validates that a person does not have an active application of the same type/class
        Task<Result> HasActiveApplication(int personID, int applicationTypeID, int? licenseClassID = null);

        // Checks if the current status of an application allows it to be cancelled
        Result CanBeCancelled(int applicationStatus);
    }
}
