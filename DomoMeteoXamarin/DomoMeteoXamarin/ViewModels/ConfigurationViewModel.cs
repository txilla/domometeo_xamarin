using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DomoMeteoXamarin.ViewModels
{
    class ConfigurationViewModel : INotifyPropertyChanged
    {


        private string _adress;
        private string _port;
        public ICommand ClickCommand { get; set; }

        public ConfigurationViewModel()
        {

            if ((Xamarin.Forms.Application.Current.Properties).Count > 0)
            {
                var address = Xamarin.Forms.Application.Current.Properties["adress"].ToString();
                if (!string.IsNullOrWhiteSpace(address))
                {
                    _adress = address;
                }

                var port = Xamarin.Forms.Application.Current.Properties["port"].ToString();
                if (!string.IsNullOrWhiteSpace(address))
                {
                    _port = port;
                }

            }

            ClickCommand = new Command(OnClick);
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnClick ()
        {
            Xamarin.Forms.Application.Current.Properties.Remove("address");
            Xamarin.Forms.Application.Current.Properties.Remove("port");
            Xamarin.Forms.Application.Current.Properties.Add("address", Address);
            Xamarin.Forms.Application.Current.Properties.Add("port", Port);
            App.Current.SavePropertiesAsync();
            App.Current.MainPage.DisplayAlert("Message", "Saved", "OK");
            

        }

        private void RaisePropertyChanged(string propertyName)
        {
            var handle = PropertyChanged;
            if (handle != null)
                handle(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
