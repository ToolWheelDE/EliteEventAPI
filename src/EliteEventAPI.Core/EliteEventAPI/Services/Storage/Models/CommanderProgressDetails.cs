namespace EliteEventAPI.Services.Storage.Models
{
    public sealed class CommanderProgressDetails
    {
        public long Combat { get; internal set; }

        public long Trade { get; internal set; }

        public long Explore { get; internal set; }

        public long Soldier { get; internal set; }

        public long Exobiologist { get; internal set; }

        public long Empire { get; internal set; }

        public long Federation { get; internal set; }

        public long Cqc { get; internal set; }
    }
}