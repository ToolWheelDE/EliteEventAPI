using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Parser
{
    sealed class JournalReader
    {
        private readonly HashSet<JournalFile> _files = new HashSet<JournalFile>();
        private readonly DirectoryInfo journalDirectory;
        private readonly FileSystemWatcher fileSystemWatcher;

        public JournalReader(DirectoryInfo directory)
        {
            journalDirectory = directory;
            fileSystemWatcher = new FileSystemWatcher(directory.FullName);
            fileSystemWatcher.EnableRaisingEvents = true;
            fileSystemWatcher.Created += FileSystemWatcher_Created;
        }
                
        public JournalFile CurrentJournal { get; private set; }

        public string JournalDirectory { get => journalDirectory.FullName; }

        public void ScanFiles()
        {
            CurrentJournal = _files.Where(m => m.State != JournalFileState.Closed).FirstOrDefault();

            if (CurrentJournal == null)
            {
                var foundfiles = journalDirectory.GetFiles("Journal.*.*.log").OrderBy(m => m.CreationTime).Select(m => new JournalFile(m));

                foreach (var file in foundfiles)
                {
                    var forcenext = false;
                    CurrentJournal = file;
                    file.State = JournalFileState.Scanning;

                    if (_files.Add(file))
                    {
                        // Scan file and search for Shutdown event
                        while (!file.EndOfStream)
                        {
                            var line = file.Reader.ReadLine();
                            if (line.IndexOf("Shutdown", StringComparison.InvariantCultureIgnoreCase) >= 0)
                            {
                                file.State = JournalFileState.Closed;
                                forcenext = true;
                                Debug.WriteLine($"Journal {file.Name} -> Shutdown");
                            }
                        }

                        if (forcenext)
                            continue;

                        file.State = JournalFileState.Progress;
                        file.ResetStream();
                        Debug.WriteLine($"Journal {file.Name} -> Ok");
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

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            ScanFiles();
        }
    }
}
