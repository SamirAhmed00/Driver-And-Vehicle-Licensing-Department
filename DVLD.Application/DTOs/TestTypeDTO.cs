using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class TestTypeDTO
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; } = string.Empty;
        public string TestTypeDescription { get; set; } = string.Empty;
        public decimal TestTypeFees { get; set; }
    }
}
