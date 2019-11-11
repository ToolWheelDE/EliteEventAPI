using EliteEventAPI;
using EliteEventAPI.Services.Events;
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

            var eventService = ServiceController.GetService<Services.EventService>();
            var edsmService = ServiceController.InstallService<Services.EDSMJournalSync>();
            var storage = ServiceController.InstallService<Services.StorageService>();

            ServiceController.Start();

            while (true)
            {
                eventService.DispatchEvent();

                Thread.Sleep(50);
            }
        }
    }
}