﻿using DomoMeteoXamarin.Models;
using DomoMeteoXamarin.Services;
using Plugin.Share;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.Share.Abstractions;
using DomoMeteoXamarin.Pages;

namespace DomoMeteoXamarin.ViewModels
{
    class DashboardViewModel : ViewModelBase
    {


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

        Sensor _yourSelectedItem;
        public Sensor YourSelectedItem
        {
            get
            {
                return _yourSelectedItem;
            }

            set
            {
                _yourSelectedItem = value;

                if (_yourSelectedItem == null)
                    return;

                Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new ChartPage(_yourSelectedItem));

                YourSelectedItem = null;
            }
        }

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                RaisePropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand ShareCommand { get; set; }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;

                    await GetSensors();

                    IsRefreshing = false;
                });
            }
        }

        public DashboardViewModel()
        {
            _sensors = new List<Sensor>();
            ShareCommand = new Command<Sensor>(obj =>
            {

                OnShare(obj);
            });

            Task.Run(async () => await GetSensors());
        }

        public void OnShare(Sensor sensor)
        {
            CrossShare.Current.Share(new ShareMessage { Title = "hola", Text = string.Format("Sensor: {0} Valor: {1}", sensor.Name, sensor.Data) });
        }

        private async Task GetSensors()
        {
            ListDataSensors = await DomoticzAPI.GetAllDevices();
        }
    }
}
