using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Events
{
    public sealed class MaterialsEvent : EventModelBase
    {
        public override string Eventname => "Materials";

        #region Neasted Classes

        public sealed class EncodedModel
        {
            [JsonProperty]
            public string Name { get; internal set; }

            [JsonProperty("Name_Localised")]
            public string NameLocalised { get; internal set; }

            [JsonProperty]
            public long Count { get; internal set; }
        }

        public sealed class RawModel
        {
            [JsonProperty]
            public string Name { get; internal set; }

            [JsonProperty]
            public long Count { get; internal set; }
        }

        #endregion

        [JsonProperty]
        public RawModel[] Raw { get; internal set; }

        [JsonProperty]
        public EncodedModel[] Manufactured { get; internal set; }

        [JsonProperty]
        public EncodedModel[] Encoded { get; internal set; }
    }
}
