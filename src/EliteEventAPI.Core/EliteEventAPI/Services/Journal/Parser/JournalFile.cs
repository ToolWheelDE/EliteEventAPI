using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Journal.Parser
{
    sealed class JournalFile
    {
        public JournalFile(FileInfo file)
        {
            File = file;
            State = JournalFileState.Scanning;
            Open();
        }

        internal StreamReader Reader { get; private set; }

        internal FileInfo File { get; private set; }

        public JournalFileState State { get; internal set; }

        public string Name { get => File.Name; }

        public string Fullname { get => File.FullName; }

        public DateTime CreateDate { get => File.CreationTimeUtc; }

        public bool EndOfStream { get => Reader.EndOfStream; }

        internal void Open()
        {
            Reader = new StreamReader(File.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
        }

        public override int GetHashCode()
        {
            var code = Fullname.GetHashCode();
            return code;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is JournalFile journal)
                return GetHashCode() == journal.GetHashCode();
            else
                return false;
        }

        internal void ResetStream()
        {
            Reader.BaseStream.Position = 0;
        }
    }
}