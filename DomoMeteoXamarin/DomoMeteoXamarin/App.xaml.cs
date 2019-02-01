using System;
using Autofac;
using DomoMeteoXamarin.Configure;
using DomoMeteoXamarin.IoC;
using Xamarin.Forms;

namespace DomoMeteoXamarin
{
    public partial class App : Application
    {
        public static double ScreenWidth { get;  set; }
        public static double ScreenHeight { get;  set; }

        public App()
        {
            InitializeComponent();

            AutomapperConfig.Configure();

            setupAutofac();

            MainPage = new NavigationPage(
                new MainPage
                {
                    Title = "DomoMeteo"
                }
            );
        }

        private void setupAutofac()
        {
            var builder = new ContainerBuilder();

            // Register services
            // builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            // TODO add your services or load modules
            builder.RegisterModule<IoCModule>();

            // Setup Autofac 
            var container = builder.Build();
            AppContainer.Container = container;
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
