using DVLD.Domain.Entities;
using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context) : base(context) { }

        public async Task<bool> ExistsByNationalNoAsync(string nationalNo)
        {
            return await _context.People.AnyAsync(p => p.NationalNo == nationalNo);
        }

        public async Task<Person?> GetByNationalNoAsync(string nationalNo)
        {
            return await _context.People.FirstOrDefaultAsync(p => p.NationalNo == nationalNo);
        }
    }
}
