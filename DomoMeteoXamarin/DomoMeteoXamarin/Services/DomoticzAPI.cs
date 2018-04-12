using AutoMapper;
using DomoMeteoXamarin.Configure;
using DomoMeteoXamarin.DTO;
using DomoMeteoXamarin.Models;
using Microcharts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomoMeteoXamarin.Services
{
    //private 

    public class DomoticzAPI : IDomoticzAPI
    {
        public DomoticzAPI()
        {
        }

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

            //http://laislalost2.ddns.net:8080/json.htm?type=graph&sensor=temp&idx=22&range=day temp
            //http://laislalost2.ddns.net:8080/json.htm?type=graph&sensor=counter&idx=20&range=month lux

        }

        public static async Task<List<ChartValue>> GetTempHumMonth(string id)
        {
            var valuesList = new List<ChartValue>();
            HttpClient httpClient = new HttpClient();
            var address = Settings.Address;
            var port = Settings.Port;

            if (!String.IsNullOrEmpty(address) && !String.IsNullOrEmpty(port))
            {
                HttpResponseMessage response = await httpClient.GetAsync(String.Format("http://{0}:{1}/json.htm?type=graph&sensor=temp&idx={2}&range=month", address, port, id));

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var valuesDTOList = JsonConvert.DeserializeObject<TempHumMonthValuesDTO>(json);
                    valuesList = Mapper.Map<List<ChartValue>>(valuesDTOList.Items);

                }
                else
                {
                    return valuesList;
                }
            }

            return valuesList;


            //http://laislalost2.ddns.net:8080/json.htm?type=graph&sensor=temp&idx=22&range=day temp
            //http://laislalost2.ddns.net:8080/json.htm?type=graph&sensor=counter&idx=20&range=month lux

        }

        public async Task<List<T>> GetAsync<T>(string url)
        {
            var valuesList = new List<T>();
            HttpClient httpClient = new HttpClient();
            var address = Settings.Address;
            var port = Settings.Port;

            if (!String.IsNullOrEmpty(address) && !String.IsNullOrEmpty(port))
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var valuesDTOList = JsonConvert.DeserializeObject<TempHumMonthValuesDTO>(json);
                    //valuesList = Mapper.Map<List<ChartValue>>(valuesDTOList.Items);

                }
                else
                {
                    return valuesList;
                }
            }

            return valuesList;
        }
    }
}
