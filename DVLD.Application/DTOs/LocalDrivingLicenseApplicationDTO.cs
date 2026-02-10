using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class LocalDrivingLicenseApplicationDTO
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string ApplicantFullName { get; set; } = string.Empty;
    }
}
