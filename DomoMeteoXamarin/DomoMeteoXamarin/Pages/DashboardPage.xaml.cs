﻿using DomoMeteoXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DomoMeteoXamarin.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashboardPage : ContentPage
	{
		public DashboardPage ()
		{
			InitializeComponent ();
            BindingContext = new DashboardViewModel();
        }

        public void ClickShare()
        {
            App.Current.MainPage.DisplayAlert("Message", "share", "OK");
        }
	}
}