using DVLD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.DomainRules.Interface
{
    public interface IUserRules
    {
        // Validates that the username is unique and not taken by another user
        Task<Result> IsUserNameUnique(string userName);

        // Ensures that a single person cannot have more than one user account in the system
        Task<Result> DoesPersonAlreadyHaveUser(int personID);
    }
}
