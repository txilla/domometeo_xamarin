using DomoMeteoXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DomoMeteoXamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigurationPage : ContentPage
	{
		public ConfigurationPage ()
		{
			InitializeComponent ();
            BindingContext = new ConfigurationViewModel();
        }
	}
}