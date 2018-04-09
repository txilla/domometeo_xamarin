using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomoMeteoXamarin.DTO
{
    public class SensorsDTO
    {
        [JsonProperty("result")]
        public List<SensorDTO> Items { get; set; }
    }

    public class SensorDTO
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Data")]
        public string Data { get; set; }

        [JsonProperty("LastUpdate")]
        public string LastUpdate { get; set; }

        [JsonProperty("idx")]
        public string Id { get; set; }
    }
}
