using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class LicenseClassDTO
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string ClassDescription { get; set; } = string.Empty;
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }
    }
}
