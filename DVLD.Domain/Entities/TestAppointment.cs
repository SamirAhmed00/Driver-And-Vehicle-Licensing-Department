using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class TestAppointment
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        // Navigation Properties
        public virtual TestType TestType { get; set; } = null!;
        public virtual LocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; } = null!;
        public virtual User CreatedByUser { get; set; } = null!;
        public virtual Test? Test { get; set; }
    }
}
