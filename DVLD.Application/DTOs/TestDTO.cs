using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class TestDTO
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string? Notes { get; set; }
        public int CreatedByUserID { get; set; }
    }
}
