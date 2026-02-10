using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class TestRules : ITestRules
    {
        private readonly ITestAppointmentRepository _appointmentRepository;

        public TestRules(ITestAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<Result> HasActiveAppointment(int localApplicationID, int testTypeID)
        {
            bool hasActive = await _appointmentRepository.HasActiveAppointmentAsync(localApplicationID, testTypeID);
            return hasActive ? Result.Failure("An active appointment for this test already exists.") : Result.Success();
        }

        public async Task<Result> HasPassedPrerequisiteTest(int localApplicationID, int currentTestTypeID)
        {
            // This will be implemented using specific repository logic to check previous test results
            return Result.Success(); // Placeholder for now
        }

        public async Task<Result> NeedsRetakeFees(int localApplicationID, int testTypeID)
        {
            // Retake fees are needed if the person failed this test before
            return Result.Success();
        }
    }
}
