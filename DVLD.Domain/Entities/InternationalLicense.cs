using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class InternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        // Navigation Properties
        public virtual Application Application { get; set; } = null!;
        public virtual Driver Driver { get; set; } = null!;
        public virtual License LocalLicense { get; set; } = null!;
        public virtual User CreatedByUser { get; set; } = null!;
    }
}
