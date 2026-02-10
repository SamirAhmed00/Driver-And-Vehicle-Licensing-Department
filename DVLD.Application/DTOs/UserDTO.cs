using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.DTOs
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public bool IsActive { get; set; }

    }
}
