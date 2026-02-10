using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class TestType
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; } = string.Empty;
        public string TestTypeDescription { get; set; } = string.Empty;
        public decimal TestTypeFees { get; set; }

        // Navigation Properties
        public virtual ICollection<TestAppointment> TestAppointments { get; set; } = new HashSet<TestAppointment>();
    }
}
