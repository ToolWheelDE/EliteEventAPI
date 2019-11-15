using EliteEventAPI;
using EliteEventAPI.Services;
using EliteEventAPI.Services.EDSM;
using EliteEventAPI.Services.Events;
using EliteEventAPI.Services.Storage;
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
            var edsmService = ServiceController.InstallService<EDSMJournalSync>();
            var storage = ServiceController.InstallService<StorageService>();

            ServiceController.Start();

            eventService.Subscribe<CargoEvent>(TestCall);

            while (true)
            {
                eventService.DispatchEvent();

                Thread.Sleep(50);
            }
        }

        private static void TestCall(CargoEvent obj)
        {
           
        }
    }
}