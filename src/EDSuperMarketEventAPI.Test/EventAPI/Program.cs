using System.Threading;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.StarsystemMap;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage;

namespace EliteEventAPI
{
    class Program
    {
        static void Main()
        {
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