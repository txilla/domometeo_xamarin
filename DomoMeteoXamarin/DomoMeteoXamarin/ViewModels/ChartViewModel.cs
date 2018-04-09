using DomoMeteoXamarin.Models;
using DomoMeteoXamarin.Services;
using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace DomoMeteoXamarin.ViewModels
{
    class ChartViewModel : ViewModelBase
    {
        string _sensorName;

        public string SensorName
        {
            get { return _sensorName; }
            set
            {
                _sensorName = value;
                RaisePropertyChanged("Address");
            }
        }

        //List<Entry> entries;


        public Chart LastRidesChart
        {
            get
            {
                //Task.Run(async () => await GetEntries());


                List<Entry> entries = new List<Entry>
                {
                    new Entry(200)
                    {
                        Color=SKColor.Parse("#FF1943"),
                        Label ="January",
                        ValueLabel = "200"
                    },
                    new Entry(400)
                    {
                        Color = SKColor.Parse("00BFFF"),
                        Label = "March",
                        ValueLabel = "400"
                    },
                    new Entry(100)
                    {
                        Color =  SKColor.Parse("#00CED1"),
                        Label = "Octobar",
                        ValueLabel = "100"
                    },
                };

                return new LineChart()
                {
                    Entries = entries,
                    PointMode = PointMode.Circle,
                    PointSize = 20
                };
            }
        }

        //private async Task GetEntries()
        //{
        //    entries = await DomoticzAPI.GetTempHumMonth();
        //}

        public ChartViewModel(Sensor sensor)
        {
            SensorName = sensor.Name;
        }

        
    }
}
