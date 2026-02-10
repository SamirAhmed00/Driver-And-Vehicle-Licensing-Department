using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Domain.Enums
{
    public enum enIssueReason : byte
    {
        FirstTime = 1,
        Renew = 2,
        ReplacementLost = 3,
        ReplacementDamaged = 4
    }
}
