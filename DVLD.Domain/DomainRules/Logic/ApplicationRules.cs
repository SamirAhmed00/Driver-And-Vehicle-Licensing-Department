using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class ApplicationRules : IApplicationRules
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationRules(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<Result> HasActiveApplication(int personID, int applicationTypeID, int? licenseClassID = null)
        {
            // Business Rule: A person cannot have two active applications of the same type
            bool hasActive = await _applicationRepository.HasActiveApplicationAsync(personID, applicationTypeID);
            return hasActive ? Result.Failure("Person already has an active application of this type.") : Result.Success();
        }

        public Result CanBeCancelled(int applicationStatus)
        {
            // (1 = New) based on enApplicationStatus
            return applicationStatus == 1 ? Result.Success() : Result.Failure("Only 'New' applications can be cancelled.");
        }
    }
}
