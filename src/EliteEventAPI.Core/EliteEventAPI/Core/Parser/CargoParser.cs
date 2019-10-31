using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Core.Parser
{
    class CargoParser
    {
        private readonly FileSystemWatcher _watcher;
        private readonly EventService _eventmanager;
        private readonly FileInfo _file;

        public CargoParser(EventService eventmanager)
        {
            _eventmanager = eventmanager;

            _file = new FileInfo(Path.Combine(eventmanager.JournalDirectory.FullName, "cargo.json"));
            if (_file.Exists)
            {
                _watcher = new FileSystemWatcher(eventmanager.JournalDirectory.FullName, "cargo.json")
                {
                    EnableRaisingEvents = true
                };
                _watcher.Changed += Watcher_Changed;

                Watcher_Changed(null, null);
            }
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            using (var reader = new StreamReader(_file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                while (!reader.EndOfStream)
                {
                    var json = reader.ReadToEnd();
                    if (String.IsNullOrEmpty(json))
                        continue;

                    _eventmanager.InsertToQueue(json);
                }
            }
        }
    }
}
