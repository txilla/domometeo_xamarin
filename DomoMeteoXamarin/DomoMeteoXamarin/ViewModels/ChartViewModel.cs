using DomoMeteoXamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DomoMeteoXamarin.ViewModels
{
    class ChartViewModel : ViewModelBase
    {
        string _address;

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                RaisePropertyChanged("Address");
            }
        }

        public ChartViewModel(Sensor sensor)
        {
            Address = sensor.Name;
        }

        
    }
}
