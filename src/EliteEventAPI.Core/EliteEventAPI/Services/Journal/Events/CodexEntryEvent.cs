using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Journal.Events
{
    public sealed class CodexEntryEvent : EventModelBase
    {
        [JsonProperty]
        public long EntryId { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; internal set; }

        [JsonProperty]
        public string SubCategory { get; internal set; }

        [JsonProperty("SubCategory_Localised")]
        public string SubCategoryLocalised { get; internal set; }

        [JsonProperty]
        public string Category { get; internal set; }

        [JsonProperty("Category_Localised")]
        public string CategoryLocalised { get; internal set; }

        [JsonProperty]
        public string Region { get; internal set; }

        [JsonProperty("Region_Localised")]
        public string RegionLocalised { get; internal set; }

        [JsonProperty]
        public string System { get; internal set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; internal set; }

        [JsonProperty]
        public bool IsNewEntry { get; internal set; }

        [JsonProperty]
        public long VoucherAmount { get; internal set; }
    }
}
