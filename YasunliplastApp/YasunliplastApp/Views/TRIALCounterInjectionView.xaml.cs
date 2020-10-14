using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using Syncfusion.SfPullToRefresh.XForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using System.Net;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TRIALCounterInjectionView : BaseContentPage
    {

        App _application = Application.Current as App;
        TRIALCounterInjectionViewModel viewModel;
        bool First = false;
        List<CounterInjection> _listCounterInjections = new List<CounterInjection>();
        public TRIALCounterInjectionView()
        {
            InitializeComponent();
            BindingContext = viewModel = new TRIALCounterInjectionViewModel();

            textboxScan.Focus();
            textboxScan.TextChanged += TextboxScan_TextChanged;


        }


        private void TextboxScan_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string a = textboxScan.Text;
                string LastString = a.Substring(a.Length - 1);


                if (LastString == "\n")
                {
                    string b = a.Remove(a.Length - 1);

                    Process(b);


                    textboxScan.Text = "";

                }
            }
            catch (Exception)
            {

            }

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_TRIAL_INJECTION_" + GlobalVar.MacAddress);
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_TRIAL_INJECTION, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {


                        if (args.Contains("ERROR"))
                        {
                            DisplayAlert("Warning", "Barcode yang terscan salah silahkan ulangi kembali.", "OK");
                        }
                        else if(args.Contains("ALREADY"))
                        {
                            DisplayAlert("Information", "Sudah di input ", "OK");
                        }
                        else
                        {
                            CounterInjection cinj = new CounterInjection();
                            cinj.BarcodeID = args;

                            List<CounterInjection> x = new List<CounterInjection>();
                            sfListView.ItemsSource = x;

                            _listCounterInjections.Add(cinj);
                            sfListView.ItemsSource = _listCounterInjections;
                            labeltotal.Text = string.Format("Total = {0}", Convert.ToString(_listCounterInjections.Count()));
                            Vibration.Vibrate();
                        }

                    });
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_TRIAL_INJECTION);
        }

        private void filterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sfListView.DataSource != null)
            {
                sfListView.DataSource.Filter = FilterContacts;
                sfListView.DataSource.RefreshFilter();
            }
            sfListView.RefreshView();
        }

        List<DEMODataBarcode> demo = new List<DEMODataBarcode>();
        int i = 0;
        private List<string> _listLocationRework;


        private bool FilterContacts(object obj)
        {
            if (filterText == null || filterText.Text == null)
                return true;

            var classInfo = obj as DEMODataBarcode;
            return (classInfo.BarcodeID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.ItemID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.ItemName.ToLower().Contains(filterText.Text.ToLower())
                );
        }

        private async void Button_ScanRFID_UsingCamera_Clicked(object sender, EventArgs e)
        {
            await NavigateToScannerpage();
        }

        async Task NavigateToScannerpage()
        {
            //setup Scanner options
            MobileBarcodeScanningOptions options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                UseFrontCameraIfAvailable = false,
                TryHarder = true,
                DelayBetweenContinuousScans = 10000,
                DisableAutofocus = false
            };

            var overlay = new ZXingDefaultOverlay
            {
                ShowFlashButton = true,
                TopText = "Hold your phone up to the barcode",
                BottomText = "Scanning will happen automatically"
            };

            overlay.BindingContext = overlay;
            ZXingScannerPage scanPage = new ZXingScannerPage(options, overlay)
            {
                HasTorch = true,
                IsTorchOn = false
            };

#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
            overlay.FlashButtonClicked += async (sender, e) =>
            {
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
                scanPage.ToggleTorch();
            };

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;
                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();

                    if (result != null && !string.IsNullOrWhiteSpace(result.Text))
                    {
                        Process(result.Text);
                        //_application.mqttHelper.PublishMQTT(result.Text, "BarcodeDEMOXacti");
                    }
                });
            };
            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);
        }

        private async void Process(string result)
        {
            if (AppSettings.IsMqttConnected && !string.IsNullOrEmpty(result))
            {

                if (result.Length > 11 && result.Length <= 50)
                {
                    string pubmsg = string.Format("{0},{1},{2},{3}", result, GlobalVar.PlantID, GlobalVar.Username, "RESPON_BARCODE_TRIAL_INJECTION_" + GlobalVar.MacAddress);

                    if (!SwitchMqttOrWebAPI.IsToggled)
                    {

                        _application.mqttHelper.PublishMQTT(pubmsg, "SCAN_BARCODE_TRIAL_INJECTION");
                        _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_TRIAL_INJECTION_" + GlobalVar.MacAddress);


                    }
                    else
                    {
                        try
                        {
                            WebClient wc = new WebClient();
                            wc.Proxy = null;

                            pubmsg = string.Format("{0}@$@{1}@$@{2}", result, GlobalVar.PlantID, GlobalVar.Username);

                            string link = "http://192.168.77.174/WebAPITest/api/values/" + pubmsg;

                            string downloadedstring = wc.DownloadString(link);
                            if (downloadedstring.Contains("ERROR"))
                            {
                                await DisplayAlert("Warning", "Barcode yang terscan salah silahkan ulangi kembali.", "OK");

                            }
                            else if (downloadedstring.Contains("ALREADY"))
                            {
                                await DisplayAlert("Information", "Sudah di input ", "OK");
                            }
                            else
                            {
                                CounterInjection cinj = new CounterInjection();
                                cinj.BarcodeID = downloadedstring;

                                List<CounterInjection> x = new List<CounterInjection>();
                                sfListView.ItemsSource = x;

                                _listCounterInjections.Add(cinj);
                                sfListView.ItemsSource = _listCounterInjections;
                                labeltotal.Text = string.Format("Total = {0}", Convert.ToString(_listCounterInjections.Count()));
                                Vibration.Vibrate();
                            }
                        }
                        catch (Exception)
                        {

                        }

                    }


                }
                else if (result.Length > 50)
                {
                    if (result.Contains("Z1") && result.Contains("Z2") && result.Contains("Z3") && result.Contains("Z4") && result.Contains("Z5") && result.Contains("Z6") && result.Contains("Z7"))
                    {

                        int index1 = result.IndexOf("Z5");
                        int index2 = result.IndexOf("|", index1);
                        string customerbarcode = result.Substring(index1 + 2, index2 - index1 - 2);
                        string pubmsg = string.Format("{0},{1},{2},{3}", customerbarcode, GlobalVar.PlantID, GlobalVar.Username, "RESPON_BARCODE_TRIAL_INJECTION_" + GlobalVar.MacAddress);

                        if (!SwitchMqttOrWebAPI.IsToggled)
                        {

                            _application.mqttHelper.PublishMQTT(pubmsg, "SCAN_BARCODE_TRIAL_INJECTION");
                            _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_TRIAL_INJECTION_" + GlobalVar.MacAddress);

                        }
                        else
                        {
                            try
                            {
                                WebClient wc = new WebClient();
                                wc.Proxy = null;

                                pubmsg = string.Format("{0}@$@{1}@$@{2}", customerbarcode, GlobalVar.PlantID, GlobalVar.Username);

                                string link = "http://192.168.77.174/WebAPITest/api/values/" + pubmsg;

                                string downloadedstring = wc.DownloadString(link);
                                if (downloadedstring.Contains("ERROR"))
                                {
                                    await DisplayAlert("Warning", "Barcode yang terscan salah silahkan ulangi kembali.", "OK");

                                }
                                else if (downloadedstring.Contains("ALREADY"))
                                {
                                    await DisplayAlert("Information", "Sudah di input ", "OK");
                                }
                                else
                                {
                                    CounterInjection cinj = new CounterInjection();
                                    cinj.BarcodeID = downloadedstring;

                                    List<CounterInjection> x = new List<CounterInjection>();
                                    sfListView.ItemsSource = x;

                                    _listCounterInjections.Add(cinj);
                                    sfListView.ItemsSource = _listCounterInjections;
                                    labeltotal.Text = string.Format("Total = {0}", Convert.ToString(_listCounterInjections.Count()));
                                    Vibration.Vibrate();
                                }
                            }
                            catch (Exception)
                            {

                            }

                        }





                    }

                }
                else
                {
                    await DisplayAlert("Warning", "Barcode yang terscan salah silahkan ulangi kembali.", "OK");
                }

            }

        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }


}