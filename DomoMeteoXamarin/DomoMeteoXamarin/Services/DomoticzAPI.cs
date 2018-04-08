using AutoMapper;
using DomoMeteoXamarin.Configure;
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
    //private 

    public class DomoticzAPI
    {
        // Get new data rows
        public static async Task<List<Sensor>> GetAllDevices()
        {
            var sensorsList = new List<Sensor>();
            HttpClient httpClient = new HttpClient();
            var address = Settings.Address;
            var port = Settings.Port;

            if (!String.IsNullOrEmpty(address) && !String.IsNullOrEmpty(port))
            {
                HttpResponseMessage response = await httpClient.GetAsync(String.Format("http://{0}:{1}/json.htm?type=devices&filter=all&used=true&order=Name", address, port));

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var sensorsDTOList = JsonConvert.DeserializeObject<SensorsDTO>(json);
                    sensorsList = Mapper.Map<List<Sensor>>(sensorsDTOList.Items);
                
                }
                else
                {
                    return sensorsList;
                }
            }

            return sensorsList;

        }
    }
}
