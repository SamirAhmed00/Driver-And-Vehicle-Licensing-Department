using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        // Specific check for Domain Rules
        Task<bool> ExistsByNationalNoAsync(string nationalNo);
        Task<Person?> GetByNationalNoAsync(string nationalNo);
    }
}
