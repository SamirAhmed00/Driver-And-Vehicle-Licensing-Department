using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class PersonRules : IPersonRules
    {
        private readonly IPersonRepository _personRepository;

        // Specialized injection, not the whole UOW
        public PersonRules(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Result> IsNationalNoUnique(string nationalNo)
        {
            // Now the logic is "Aware" of the DB through the interface
            bool exists = await _personRepository.ExistsByNationalNoAsync(nationalNo);
            return exists ? Result.Failure("National Number is already registered.") : Result.Success();
        }

        public Result IsAgeValidForLicense(DateTime dateOfBirth, int minimumAge)
        {
            // This is a pure calculation, doesn't need DB
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;

            return age >= minimumAge ? Result.Success() : Result.Failure($"Age is too young.");
        }

    }
}
