using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Constants
{
    public static class ValidationConstants
    {
        // Person Constants
        public const int MaxNameLength = 100;
        public const int MinDrivingAge = 18;

        // User Constants
        public const int MinPasswordLength = 8;

        // License Constants
        public const int DefaultLicenseValidityYears = 10;
    }
}
