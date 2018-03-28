using AutoMapper;
using DomoMeteoXamarin.DTO;
using DomoMeteoXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomoMeteoXamarin.Services
{
    public class DomoticzAPI
    {
        // Get new data rows
        public static async Task<List<Sensor>> GetAllDevices()
        {
            var sensorsList = new List<Sensor>();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("http://laislalost2.ddns.net:8080/json.htm?type=devices&filter=all&used=true&order=Name");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                var sensorsDTOList = JsonConvert.DeserializeObject<SensorsDTO>(json);
                sensorsList = Mapper.Map<List<Sensor>>(sensorsDTOList.Items);
                
            }

            return sensorsList;

        }
    }
}
