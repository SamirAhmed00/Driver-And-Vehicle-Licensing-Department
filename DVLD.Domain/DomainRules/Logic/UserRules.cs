using DVLD.Domain.Common;
using DVLD.Domain.DomainRules.Interface;
using DVLD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Logic
{
    public class UserRules : IUserRules
    {
        private readonly IUserRepository _userRepository;

        public UserRules(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> IsUserNameUnique(string userName)
        {
            bool exists = await _userRepository.ExistsByUserNameAsync(userName);
            return exists ? Result.Failure("Username is already taken.") : Result.Success();
        }

        public async Task<Result> DoesPersonAlreadyHaveUser(int personID)
        {
            bool exists = await _userRepository.ExistsByPersonIdAsync(personID);
            return exists ? Result.Failure("This person is already linked to another user account.") : Result.Success();
        }
    }
}
