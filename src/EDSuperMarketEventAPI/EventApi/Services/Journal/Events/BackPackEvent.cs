using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class BackPackEvent : EventModelBase
    {
        protected internal override string Eventname => "*BackPack";

        [JsonProperty]
        public BackPackItem[] Items { get; internal set; }

        [JsonProperty]
        public BackPackItem[] Components { get; internal set; }

        [JsonProperty]
        public BackPackItem[] Consumables { get; internal set; }

        [JsonProperty]
        public BackPackItem[] Data { get; internal set; }
    }
}
