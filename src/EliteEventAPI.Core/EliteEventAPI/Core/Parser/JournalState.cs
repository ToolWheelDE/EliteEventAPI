using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Core.Parser
{
    enum JournalState
    {
        New = 0,
        ClosedShutdown,
        ClosedContinue,
        Scanning
    }
}
