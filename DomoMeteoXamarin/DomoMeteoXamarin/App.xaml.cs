using DomoMeteoXamarin.Configure;

using Xamarin.Forms;

namespace DomoMeteoXamarin
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();

            AutomapperConfig.Configure();

            MainPage = new NavigationPage(
                new MainPage
                {
                    Title = "DomoMeteo"
                }
            );

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
