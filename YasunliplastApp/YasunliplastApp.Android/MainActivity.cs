using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;

namespace YasunliplastApp.Droid
{
    /// <summary>
    /// MainLauncher = false in MainActivity to use LoadingScreen
    /// </summary>
    [Activity(Label = "YasunliplastApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //allowing the device to change the screen orientation based on the rotation
            MessagingCenter.Subscribe<Views.SchedulingView>(this, "OnlyLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Landscape;
            });

            //during page close setting back to portrait
            MessagingCenter.Subscribe<Views.SchedulingView>(this, "AllowBoth", sender =>
            {
                RequestedOrientation = ScreenOrientation.Unspecified;
            });

            MessagingCenter.Subscribe<Views.SuratKonfirmasi>(this, "OnlyLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Landscape;
            });

            //during page close setting back to portrait
            MessagingCenter.Subscribe<Views.SuratKonfirmasi>(this, "AllowBoth", sender =>
            {
                RequestedOrientation = ScreenOrientation.Unspecified;
            });

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            this.Window.SetFlags(WindowManagerFlags.Secure, WindowManagerFlags.Secure);


            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            #region For screen Height & Width
            var pixels = Resources.DisplayMetrics.WidthPixels;
            var scale = Resources.DisplayMetrics.Density;
            var dps = (double)((pixels - 0.5f) / scale);
            App.ScreenWidth = (int)dps;
            pixels = Resources.DisplayMetrics.HeightPixels;
            dps = (double)((pixels - 0.5f) / scale);
            App.ScreenHeight = (int)dps;
            #endregion

            FormsMaterial.Init(this, savedInstanceState);
            ZXing.Net.Mobile.Forms.Android.Platform.Init();
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(false);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}