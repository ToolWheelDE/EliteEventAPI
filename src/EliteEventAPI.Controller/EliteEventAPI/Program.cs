using EliteEventAPI;
using EliteEventAPI.Services;
using EliteEventAPI.Services.EDSM;
using EliteEventAPI.Services.Events;
using EliteEventAPI.Services.StarsystemMap;
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

            var eventslist = string.Join(Environment.NewLine, eventService.GetEventNames());
                        
           // var edsmService = ServiceController.InstallService<EDSMJournalSync>();
            var storage = ServiceController.InstallService<StorageService>();
            var starsystem = ServiceController.InstallService<StarsystemMapService>();

            ServiceController.Start();

            while (true)
            {
                eventService.DispatchEvent();

                Thread.Sleep(100);
            }
        }
    }
}