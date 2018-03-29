using DomoMeteoXamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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

        public ChartViewModel(Sensor sensor)
        {
            SensorName = sensor.Name;
        }

        
    }
}
