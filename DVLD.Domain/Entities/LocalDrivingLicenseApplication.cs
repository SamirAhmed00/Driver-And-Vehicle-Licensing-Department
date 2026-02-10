using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class LocalDrivingLicenseApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        // Navigation Properties
        public virtual Application Application { get; set; } = null!;
        public virtual LicenseClass LicenseClass { get; set; } = null!;
        public virtual ICollection<TestAppointment> TestAppointments { get; set; } = new HashSet<TestAppointment>();
    }
}
