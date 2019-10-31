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

            ServiceController.Start();

            eventService.Subscribe<Services.Events.StatusEvent>(StatusCallback);

            while (true)
            {
                eventService.DispatchEvent();

                Thread.Sleep(200);
            }

            
        }

        private static void StatusCallback(StatusEvent obj)
        {
            Console.WriteLine("Update Flags " + obj.Flags.ToString());
        }
    }
}