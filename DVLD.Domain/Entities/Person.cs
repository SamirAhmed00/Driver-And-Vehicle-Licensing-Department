using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class Person
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string? ThirdName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public enGender Gendor { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int NationalityCountryID { get; set; }
        public string? ImagePath { get; set; }

        // Navigation Properties
        public virtual Country NationalityCountry { get; set; } = null!;
        public virtual User? User { get; set; }
        public virtual Driver? Driver { get; set; }
    }
}
