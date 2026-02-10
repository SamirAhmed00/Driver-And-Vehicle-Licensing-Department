using DVLD.Domain.Entities;
using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;

using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User?> GetByUserNameAndPasswordAsync(string userName, string password)
        {
            // Finding user with matching credentials and ensuring they are active
            return await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == userName && u.Password == password);
        }

        public async Task<bool> ExistsByPersonIdAsync(int personId)
        {
            // Check if a person is already linked to a user account
            return await _context.Users.AnyAsync(u => u.PersonID == personId);
        }

        public async Task<bool> ExistsByUserNameAsync(string userName)
        {
            // Check if username is already taken
            return await _context.Users.AnyAsync(u => u.UserName == userName);
        }
    }
}
