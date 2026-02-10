using DVLD.Domain.Enums;

using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class Application
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; } // 1:New, 2:Cancelled, 3:Completed
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        // Navigation Properties
        public virtual Person Applicant { get; set; } = null!;
        public virtual ApplicationType ApplicationType { get; set; } = null!;
        public virtual User CreatedByUser { get; set; } = null!;
        public virtual LocalDrivingLicenseApplication? LocalDrivingLicenseApplication { get; set; }
    }
}
