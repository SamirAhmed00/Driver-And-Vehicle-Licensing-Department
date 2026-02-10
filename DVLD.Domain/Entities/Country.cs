using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; } = string.Empty;

        // Navigation Properties
        public virtual ICollection<Person> People { get; set; } = new HashSet<Person>();
    }
}
