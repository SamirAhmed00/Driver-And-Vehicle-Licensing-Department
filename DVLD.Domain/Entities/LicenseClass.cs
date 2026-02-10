using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class LicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string ClassDescription { get; set; } = string.Empty;
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        // Navigation Properties
        public virtual ICollection<LocalDrivingLicenseApplication> LocalDrivingLicenseApplications { get; set; } = new HashSet<LocalDrivingLicenseApplication>();
        public virtual ICollection<License> Licenses { get; set; } = new HashSet<License>();
    }
}
