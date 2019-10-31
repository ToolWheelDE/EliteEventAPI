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

            var manager = ServiceController.GetModule<EventService>();
            var edsm = ServiceController.CreateInstance<EDSM.EDSMJournalSync>();

            ServiceController.Start();

            while (true)
            {
                manager.DispatchEvent();

                Thread.Sleep(200);
            }
        }
    }
}