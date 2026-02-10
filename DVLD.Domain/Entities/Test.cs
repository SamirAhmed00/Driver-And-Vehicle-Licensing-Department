using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class Test
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string? Notes { get; set; }
        public int CreatedByUserID { get; set; }

        // Navigation Properties
        public virtual TestAppointment TestAppointment { get; set; } = null!;
        public virtual User CreatedByUser { get; set; } = null!;
    }
}
