using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User?> GetByUserNameAndPasswordAsync(string userName, string password);
        Task<bool> ExistsByPersonIdAsync(int personId);
        Task<bool> ExistsByUserNameAsync(string userName);
    }
}
