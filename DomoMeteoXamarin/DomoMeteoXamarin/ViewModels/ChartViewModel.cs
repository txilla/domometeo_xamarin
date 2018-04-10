using DomoMeteoXamarin.Models;
using DomoMeteoXamarin.Services;
using Microcharts;
using SkiaSharp;
using System.Collections.Generic;
using System.Linq;
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
                //RaisePropertyChanged("Address");
            }
        }

        List<ChartValue> chartEntries;
        

        private List<Sensor> _sensors;

        public List<Sensor> ListDataSensors
        {
            get { return _sensors; }
            set
            {
                if (_sensors == value)
                    return;

                _sensors = value;
                RaisePropertyChanged("ListDataSensors");
            }
        }

        Chart _lineChart;
        public Chart LastRidesChart
        {
            get { return _lineChart; }
            set
            {
                if (_lineChart == value)
                    return;

                _lineChart = value;
                RaisePropertyChanged("LastRidesChart");
            }
            //get
            //{
                




                //List<Entry> entries = new List<Entry>
                //{
                //    new Entry(200)
                //    {
                //        Color=SKColor.Parse("#FF1943"),
                //        Label ="January",
                //        ValueLabel = "200"
                //    },
                //    new Entry(400)
                //    {
                //        Color = SKColor.Parse("00BFFF"),
                //        Label = "March",
                //        ValueLabel = "400"
                //    },
                //    new Entry(100)
                //    {
                //        Color =  SKColor.Parse("#00CED1"),
                //        Label = "Octobar",
                //        ValueLabel = "100"
                //    },
                //};

                //return new LineChart()
                //{
                //    Entries = entries,
                //    PointMode = PointMode.Circle,
                //    PointSize = 20
                //};

                //return lineChart;
            //}
        }

        private async Task GetEntries(Sensor sensor)
        {
            chartEntries = new List<ChartValue>();
            chartEntries = await DomoticzAPI.GetTempHumMonth(sensor.Id);

            List<Entry> entries = new List<Entry>();

            foreach (ChartValue entrie in chartEntries)
            {
                var chartEntrie = new Entry(entrie.Value)
                {
                    Color = SKColor.Parse("#3366ff"),
                    Label = entrie.Label,
                    ValueLabel = entrie.ValueLabel
                };

                entries.Add(chartEntrie);
            }

            

            LastRidesChart = new LineChart()
            {
                Entries = entries,
                MinValue = entries.Min(e => e.Value),
                Margin = 10,
                PointMode = PointMode.Circle,
                PointSize = 20
            };
        }

        public ChartViewModel(Sensor sensor)
        {
            SensorName = sensor.Name;

            Task.Run(async () => await GetEntries(sensor));
        }

        
    }
}
