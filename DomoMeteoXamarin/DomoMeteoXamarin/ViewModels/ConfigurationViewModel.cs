using DomoMeteoXamarin.Configure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DomoMeteoXamarin.ViewModels
{
    class ConfigurationViewModel : ViewModelBase
    {


        private string _adress;
        private string _port;
        bool busy = false;
        bool enabled = true;

        public bool IsBusy
        {
            get { return busy; }
            set
            {
                if (busy == value)
                    return;

                busy = value;
                RaisePropertyChanged("IsBusy");
            }
        }

        public bool IsEnabled
        {
            get { return enabled; }
            set
            {
                if (enabled == value)
                    return;

                enabled = value;
                RaisePropertyChanged("IsEnabled");
            }
        }

        public string Address
        {
            get { return _adress; }
            set
            {
                _adress = value;
                RaisePropertyChanged("Address");
            }
        }

        public string Port
        {
            get { return _port; }
            set
            {
                _port = value;
                RaisePropertyChanged("Port");
            }
        }
        public ICommand ClickCommand { get; set; }


        public ConfigurationViewModel()
        {
            _adress = Settings.Address;

            _port = Settings.Port;

            ClickCommand = new Command(OnClick);
        }


        public void OnClick()
        {
            IsBusy = true;
            IsEnabled = false;
            Settings.Address = Address;
            Settings.Port = Port;
            IsEnabled = true;
            IsBusy = false;
            App.Current.MainPage.DisplayAlert("Message", "Saved", "OK");


        }
    }
}
