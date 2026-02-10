using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class DriverDTO
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
