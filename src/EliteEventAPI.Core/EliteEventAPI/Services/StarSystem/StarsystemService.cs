using EliteEventAPI.Configuration;
using EliteEventAPI.Services;
using EliteEventAPI.Services.Events;
using EliteEventAPI.Services.Models.StarSystem;
using EliteEventAPI.Services.Storage.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Starsystem
{
    public sealed class StarsystemService : ServiceBase
    {
        private List<SystemObject> _elements = new List<SystemObject>();

        public StarsystemService()
        {
            var events = ServiceController.GetService<EventService>();

            events.Subscribe<ScanEvent>(ScanCallback);
        }

        public override string Name => "Starsystem viewer";

        private void ScanCallback(ScanEvent obj)
        {
            var systemobject = SystemObject.GetObject(obj);

            _elements.Add(systemobject);
        }
    }
}