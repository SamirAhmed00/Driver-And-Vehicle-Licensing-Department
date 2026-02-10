using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class ApplicationTypeDTO
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; } = string.Empty;
        public decimal ApplicationFees { get; set; }
    }
}
