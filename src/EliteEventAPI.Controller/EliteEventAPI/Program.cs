using EliteEventAPI.Core;
using System;
using System.Diagnostics;
using System.Threading;

namespace EliteEventAPI
{
    class Program
    {
        static void Main()
        {
            Trace.Listeners.Add(new ConsoleTraceListener());

            var eventService = ServiceController.GetService<EventService>();
            var edsmService = ServiceController.InstallService<EDSM.EDSMJournalSync>();

            ServiceController.Start();

            while (true)
            {
                eventService.DispatchEvent();

                Thread.Sleep(200);
            }
        }
    }
}