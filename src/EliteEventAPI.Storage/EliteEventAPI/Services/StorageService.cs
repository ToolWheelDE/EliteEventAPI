using EliteEventAPI.Configuration;
using EliteEventAPI.Services;
using EliteEventAPI.Services.Events;
using EliteEventAPI.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services
{
    public sealed class StorageService : ServiceBase
    {
        public StorageService()
        {
            EventService = ServiceController.GetService<EventService>();

            Commander = new CommanderModel(EventService);
            Navigation = new NavigationModel(EventService);
            StarSystem = new StarSystemModel(EventService);
        }

        public override string Name => "Storage";

        public EventService EventService { get; }

        public CommanderModel Commander { get; }

        public NavigationModel Navigation { get; }

        internal StarSystemModel StarSystem { get; }
    }
}
