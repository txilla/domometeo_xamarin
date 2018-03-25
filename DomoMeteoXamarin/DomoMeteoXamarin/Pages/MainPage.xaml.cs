using DomoMeteoXamarin.Pages;
using DomoMeteoXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DomoMeteoXamarin
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
            //InitializeComponent();
            //BindingContext = new MainViewModel();

            Children.Add(new DashboardPage());
            Children.Add(new ConfigurationPage());

        }
	}
}
