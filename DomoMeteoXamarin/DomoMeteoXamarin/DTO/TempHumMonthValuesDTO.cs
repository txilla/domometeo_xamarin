using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomoMeteoXamarin.DTO
{
    public class TempHumMonthValuesDTO
    {
        [JsonProperty("result")]
        public List<SensorDTO> Items { get; set; }
    }

    public class TempHumMonthValueDTO
    {
        [JsonProperty("d")]
        public string Date { get; set; }

        [JsonProperty("hu")]
        public string Humidity { get; set; }

        [JsonProperty("tm")]
        public string Temperature { get; set; }
        
    }
}
