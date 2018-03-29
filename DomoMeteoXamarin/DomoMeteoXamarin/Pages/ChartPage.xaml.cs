using DomoMeteoXamarin.Models;
using DomoMeteoXamarin.ViewModels;
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
	public partial class ChartPage : ContentPage
	{
		public ChartPage (Sensor sensor)
		{
			InitializeComponent ();
            BindingContext = new ChartViewModel(sensor);
		}
	}
}