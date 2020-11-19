using EliteEventAPI;
using EliteEventAPI.Diagnostics.Logging;
using EliteEventAPI.Diagnostics.Logging.Targets;
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
            LoggerManager.IsEnabled = true;
            LoggerManager.MaxLevel = LoggerMessageType.Error;
            LoggerManager.MinLevel = LoggerMessageType.Trace;
            LoggerManager.Add("console", new ConsoleLoggerTarget());

            var eventService = ServiceController.GetService<EventService>();

            var eventslist = string.Join(Environment.NewLine, eventService.GetEventNames());

            // var edsmService = ServiceController.InstallService<EDSMJournalSync>();
            var storage = ServiceController.InstallService<StorageService>();
            var starsystem = ServiceController.InstallService<StarsystemMapService>();

            ServiceController.Start();

            while (true)
            {
                eventService.DispatchEvent();

                Thread.Sleep(10);
            }
        }
    }
}