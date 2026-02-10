using System;
using System.Collections.Generic;
using System.Text;
using DVLD.Domain.Enums;

namespace DVLD.Domain.Entities
{
    public class License
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte enIssueReason { get; set; } // 1:FirstTime, 2:Renew, 3:ReplacementLost, 4:ReplacementDamaged
        public int CreatedByUserID { get; set; }

        // Navigation Properties
        public virtual Application Application { get; set; } = null!;
        public virtual Driver Driver { get; set; } = null!;
        public virtual LicenseClass LicenseClass { get; set; } = null!;
        public virtual User CreatedByUser { get; set; } = null!;
        public virtual DetainedLicense? DetainedLicense { get; set; }
    }
}
