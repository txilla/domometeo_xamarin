using DomoMeteoXamarin.Pages;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace DomoMeteoXamarin
{
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            //InitializeComponent();
            //BindingContext = new MainViewModel();
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            Children.Add(new DashboardPage() { Icon = "ic_dashboard.png" });
            Children.Add(new ConfigurationPage() { Icon = "ic_build.png" });

        }
    }
}
