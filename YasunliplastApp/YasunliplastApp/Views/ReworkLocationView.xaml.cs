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
using ZXing.Net.Mobile.Forms;
using ZXing.Mobile;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReworkLocationView : BaseContentPage
    {

        App _application = Application.Current as App;
        ReworkLocationViewModel viewModel;
        List<string> _listLocationRework = new List<string>();
        bool First = false;
        public ReworkLocationView()
        {
            InitializeComponent();
            BindingContext = viewModel = new ReworkLocationViewModel();

            textboxScan.Focus();
            textboxScan.TextChanged += TextboxScan_TextChanged;

            textboxScan.Focus();

            GlobalVar._listReworkLocations = new List<ReworkLocation>();

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(GlobalVar.PlantID, "GET_LOCATION_REWORK_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("RESPON_LOCATION_REWORK_" + GlobalVar.MacAddress);

            }
        }


        private async void Process(string result)
        {

            if (AppSettings.IsMqttConnected)
            {

                if (result.Length > 11 && result.Length <= 50)
                {
                    if (Combobox_Location.SelectedItem != null)
                    {
                        if (AppSettings.IsMqttConnected)
                        {
                            _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2}", result, GlobalVar.PlantID, Combobox_Location.SelectedItem), "SCAN_BARCODE_REWORK_LOCATION_" + GlobalVar.MacAddress);
                            _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_LOCATION_REWORK_" + GlobalVar.MacAddress);
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
                        if (AppSettings.IsMqttConnected)
                        {
                            _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2}", customerbarcode, GlobalVar.PlantID, Combobox_Location.SelectedItem), "SCAN_BARCODE_REWORK_LOCATION_" + GlobalVar.MacAddress);
                            _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_LOCATION_REWORK_" + GlobalVar.MacAddress);
                        }
                    }
                    else
                    {
                        await DisplayAlert("Warning", "Barcode yang terscan salah. Silakan coba lagi.", "OK");
                    }

                }
                else
                {
                    bool val = false;
                    foreach (var item in _listLocationRework)
                    {
                        if (item == result.ToUpper())
                        {
                            val = true;
                            break;
                        }
                    }
                    if (val)
                    {
                        Combobox_Location.SelectedItem = result;
                    }
                    else
                    {
                        await DisplayAlert("Warning", "Barcode yang terscan salah. Silakan coba lagi.", "OK");
                    }

                }
            }
        }


        private void TextboxScan_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string a = textboxScan.Text;
                string LastString = a.Substring(a.Length - 1);

                if (LastString == "\n" )
                {
                    a = a.Remove(a.Length - 1);

                    Process(a);
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




            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(GlobalVar.PlantID, "GET_LOCATION_REWORK_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("RESPON_LOCATION_REWORK_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_REWORK, (sender, args) =>
            {
                if (args != null)
                {
                    if (!First)
                    {
                        First = true;
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            _listLocationRework = new List<string>();

                            string[] strarray = { "@#$" };
                            string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                            foreach (var item in strsplit)
                            {
                                _listLocationRework.Add(item);
                            }
                            Combobox_Location.DataSource = _listLocationRework;
                        });
                    }
                }
            });




            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_LOCATION_REWORK_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_LOCATION_REWORK, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (args.Contains("SUCCESS,"))
                        {
                            args = args.Replace("SUCCESS,", "");
                            string[] strarray = { "@#$" };
                            string[] strsplit = args.Split(strarray, StringSplitOptions.None);

                            ReworkLocation rwkloc = new ReworkLocation();
                            rwkloc.BarcodeID = strsplit[0];
                            rwkloc.ItemID = strsplit[1];
                            rwkloc.ItemName = strsplit[2];
                            rwkloc.Model = strsplit[3];
                            rwkloc.Qty = "Qty : " + strsplit[4];
                            rwkloc.Location = "Loc : " + strsplit[5];



                            List<ReworkLocation> x = new List<ReworkLocation>();
                            sfListView.ItemsSource = x;

                            GlobalVar._listReworkLocations.Add(rwkloc);
                            viewModel.listReworkLocation = GlobalVar._listReworkLocations;
                            sfListView.ItemsSource = viewModel.listReworkLocation;
                            labeltotal.Text = string.Format("Total = {0}", Convert.ToString(viewModel.listReworkLocation.Count()));

                            //DisplayAlert("Information", "Data Rework Saved Successfully", "OK");
                        }
                        else
                        {
                            string errormessage = args.Replace("ERROR,", "");
                            DisplayAlert("Warning", errormessage, "OK");
                        }
                    });

                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_REWORK);
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_LOCATION_REWORK);
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

        List<ReworkLocation> demo = new List<ReworkLocation>();
        int i = 0;
        private void buttonadd_Clicked(object sender, EventArgs e)
        {
            List<ReworkLocation> x = new List<ReworkLocation>();
            sfListView.ItemsSource = x;


            ReworkLocation dataDEMO = new ReworkLocation();
            dataDEMO.BarcodeID = "BARCODE DUMMY" + i.ToString();
            dataDEMO.ItemID = "ITEM ID DUMMY" + i.ToString();
            dataDEMO.ItemName = "ITEM NAME DUMMY" + i.ToString();




            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            GlobalVar._listReworkLocations = demo;
            sfListView.RefreshView();
            viewModel.listReworkLocation = GlobalVar._listReworkLocations;
            sfListView.ItemsSource = viewModel.listReworkLocation;

        }

        private bool FilterContacts(object obj)
        {
            if (filterText == null || filterText.Text == null)
                return true;

            var classInfo = obj as ReworkLocation;
            return (classInfo.BarcodeID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.ItemID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.ItemName.ToLower().Contains(filterText.Text.ToLower())
                );
        }

        private void Combobox_Location_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {

        }

        private async void Button_ScanBarcodeRework_Clicked(object sender, EventArgs e)
        {
            if (AppSettings.IsMqttConnected)
            {
                await NavigateToScannerpage();
            }
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
            overlay.FlashButtonClicked += async (sender, e) => {
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



    }


}