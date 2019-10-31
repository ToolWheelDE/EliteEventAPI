using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Core.Parser
{
    class StatusParser
    {
        private readonly EventService _eventmanager;
        private readonly FileSystemWatcher _watcher;
        private readonly FileInfo _file;

        public StatusParser(EventService api)
        {
            _eventmanager = api;
            _file = new FileInfo(Path.Combine(_eventmanager.JournalDirectory.FullName, "Status.json"));
            if (_file.Exists)
            {
                _watcher = new FileSystemWatcher(_eventmanager.JournalDirectory.FullName, "Status.json")
                {
                    EnableRaisingEvents = true
                };
                _watcher.Changed += Watcher_Changed;
            }

            Watcher_Changed(null, null);
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
