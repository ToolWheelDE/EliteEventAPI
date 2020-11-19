using EliteEventAPI.Diagnostics.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.JournalParser
{
    sealed class JournalReader
    {
        private readonly HashSet<JournalFile> _files = new HashSet<JournalFile>();
        private ClassLogger logger;
        private readonly EventService _master;

        public JournalReader(EventService master)
        {
            logger = new ClassLogger(this);

            _master = master;
        }

        public JournalFile CurrentJournal { get; private set; }

        public void ScanFiles()
        {
            CurrentJournal = _files.Where(m => m.State != JournalState.Closed).FirstOrDefault();

            if (CurrentJournal == null)
            {
                var foundfiles = _master.JournalDirectory.GetFiles("Journal.*.*.log").OrderBy(m => m.CreationTime).Select(m => new JournalFile(m));

                foreach (var file in foundfiles)
                {
                    var forcenext = false;
                    CurrentJournal = file;
                    file.State = JournalState.Scanning;

                    if (_files.Add(file))
                    {
                        // Datei vorab untersuchen
                        while (!file.EndOfStream)
                        {
                            var line = file.Reader.ReadLine();
                            if (line.IndexOf("Shutdown", StringComparison.InvariantCultureIgnoreCase) >= 0)
                            {
                                file.State = JournalState.Closed;
                                forcenext = true;
                                logger.Warning($"Journal {file.Name} -> Shutdown");
                            }
                        }

                        if (forcenext)
                            continue;

                        file.State = JournalState.Progress;
                        file.ResetStream();
                        logger.Normal($"Journal {file.Name} -> Ok");
                        return;
                    }
                }
            }
        }

        public bool HasNextChuck()
        {
            return CurrentJournal != null && !CurrentJournal.Reader.EndOfStream;
        }

        public string NextChuck()
        {
            if (!HasNextChuck()) return string.Empty;

            return CurrentJournal.Reader.ReadLine();
        }
    }
}
