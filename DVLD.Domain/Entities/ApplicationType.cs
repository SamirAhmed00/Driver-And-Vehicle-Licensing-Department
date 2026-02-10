using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Entities
{
    public class ApplicationType
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; } = string.Empty;
        public decimal ApplicationFees { get; set; }

        // Navigation Properties
        public virtual ICollection<Application> Applications { get; set; } = new HashSet<Application>();
    }
}
