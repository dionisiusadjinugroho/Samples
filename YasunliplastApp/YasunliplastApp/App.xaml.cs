using YasunliplastApp.Utils;
using YasunliplastApp.Views;
using YasunliplastApp.Views.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YasunliplastApp
{
    public partial class App : Application
    {
        public static double ScreenHeight;
        public static double ScreenWidth;

        public MqttHelper mqttHelper = new MqttHelper();

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDg0MzdAMzEzNzJlMzIyZTMwb052b1AyaXZiVWJQaHBvcGhOQlMzNDF3N3RUOXFwdElCVVFremhpeHpzMD0=");
            InitializeComponent();

            MainPage = new CustomNavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
