using EliteEventAPI;
using EliteEventAPI.Diagnostics.Logging;
using EliteEventAPI.Diagnostics.Logging.Targets;
using EliteEventAPI.Services;
using EliteEventAPI.Services.Journal;
using EliteEventAPI.Services.StarsystemMap;
using EliteEventAPI.Services.Storage;
using Ionic.Zlib;
using NetMQ;
using NetMQ.Sockets;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
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

            var journalReader = ServiceController.InstallService<GameJournalReaderService>();

            // var edsmService = ServiceController.InstallService<EDSMJournalSync>();
            var storage = ServiceController.InstallService<StorageService>();
            var starsystem = ServiceController.InstallService<StarsystemMapService>();

            ServiceController.Start();

            while (true)
            {
                journalReader.DispatchEvent();

                Thread.Sleep(10);
            }
        }
    }
}