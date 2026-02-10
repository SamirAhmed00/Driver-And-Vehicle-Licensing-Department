using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface ITestRules
    {
        // Ensures the applicant has passed the required preceding tests (e.g., Vision before Written)
        Task<Result> HasPassedPrerequisiteTest(int localApplicationID, int currentTestTypeID);

        // Ensures there is no currently active or unlocked appointment for the same test type
        Task<Result> HasActiveAppointment(int localApplicationID, int testTypeID);

        // Checks if the applicant is required to pay retake fees based on previous failed attempts
        Task<Result> NeedsRetakeFees(int localApplicationID, int testTypeID);
    }
}
