using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class PersonDTO
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string? ThirdName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {SecondName} {ThirdName} {LastName}".Replace("  ", " ");
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int NationalityCountryID { get; set; }
        public string? ImagePath { get; set; }
    }
}
