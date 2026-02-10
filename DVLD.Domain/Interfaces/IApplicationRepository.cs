using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface IApplicationRepository : IGenericRepository<Application>
    {
        // Check if person has an active application of a specific type
        Task<bool> HasActiveApplicationAsync(int personId, int applicationTypeId);
    }
}
