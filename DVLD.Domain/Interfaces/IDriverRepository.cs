using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Interfaces
{
    public interface IDriverRepository : IGenericRepository<Driver>
    {
        Task<Driver?> GetByPersonIdAsync(int personId);
    }
}
