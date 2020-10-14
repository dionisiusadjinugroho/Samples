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
    public partial class TRIALCounterReworkINView : BaseContentPage
    {

        App _application = Application.Current as App;
        TRIALCounterReworkINViewModel viewModel;
        List<string> _listLocationRework = new List<string>();
        bool First = false;
        public TRIALCounterReworkINView()
        {
            InitializeComponent();
            BindingContext = viewModel = new TRIALCounterReworkINViewModel();

            textboxScan.Focus();
            textboxScan.TextChanged += TextboxScan_TextChanged;

            GlobalVar._listreworkINs = new List<ReworkIN>();


            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(GlobalVar.PlantID, "GET_LOCATION_REWORK_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_REWORK_ABCD" + GlobalVar.MacAddress);
            }
            textboxScan.Focus();
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
                _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_REWORK_ABCD" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_REWORK_IN, (sender, args) =>
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

                            ReworkIN rwkin = new ReworkIN();
                            rwkin.BarcodeID = strsplit[0];
                            rwkin.BoxType = strsplit[1];
                            rwkin.CavityNo = "Cavity : " + strsplit[2];
                            rwkin.ItemID = strsplit[3];
                            rwkin.ItemName = strsplit[4];
                            rwkin.Model = strsplit[5];
                            rwkin.SPPNo = "No SPP : " + strsplit[6];
                            rwkin.ScanTime = strsplit[7];
                            rwkin.Qty = "Qty : " + strsplit[8];
                            rwkin.Location = "Location : " + strsplit[9];

                            List<ReworkIN> x = new List<ReworkIN>();
                            sfListView.ItemsSource = x;

                            GlobalVar._listreworkINs.Add(rwkin);
                            viewModel.listReworkIN = GlobalVar._listreworkINs;
                            sfListView.ItemsSource = viewModel.listReworkIN;
                            labeltotal.Text = string.Format("Total = {0}", Convert.ToString(viewModel.listreworkin.Count()));

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

            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_REWORK_IN);
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

        List<ReworkIN> demo = new List<ReworkIN>();
        int i = 0;
        private void buttonadd_Clicked(object sender, EventArgs e)
        {
            List<ReworkIN> x = new List<ReworkIN>();
            sfListView.ItemsSource = x;


            ReworkIN dataDEMO = new ReworkIN();
            dataDEMO.BarcodeID = "BARCODE DUMMY" + i.ToString();
            dataDEMO.ItemID = "ITEM ID DUMMY" + i.ToString();
            dataDEMO.ItemName = "ITEM NAME DUMMY" + i.ToString();




            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            GlobalVar._listreworkINs = demo;
            sfListView.RefreshView();
            viewModel.listReworkIN = GlobalVar._listreworkINs;
            sfListView.ItemsSource = viewModel.listReworkIN;

        }

        private bool FilterContacts(object obj)
        {
            if (filterText == null || filterText.Text == null)
                return true;

            var classInfo = obj as ReworkIN;
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

        private async void Process(string result)
        {

            if (AppSettings.IsMqttConnected)
            {

                if (result.Length > 11 && result.Length <= 50)
                {
                    string location = null;
                    if (Combobox_Location.SelectedItem != null)
                    {
                        location = Convert.ToString(Combobox_Location.SelectedItem);
                    }
                    else
                    {
                        location = "NULL";
                    }

                    if (AppSettings.IsMqttConnected)
                    {
                        _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2},{3}", result, GlobalVar.PlantID, GlobalVar.Username, location), "SCAN_BARCODE_REWORK_ABCD" + GlobalVar.MacAddress);
                        _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_REWORK_ABCD" + GlobalVar.MacAddress);
                    }
                }
                else if (result.Length > 50)
                {
                    if (result.Contains("Z1") && result.Contains("Z2") && result.Contains("Z3") && result.Contains("Z4") && result.Contains("Z5") && result.Contains("Z6") && result.Contains("Z7"))
                    {
                        int index1 = result.IndexOf("Z5");
                        int index2 = result.IndexOf("|", index1);
                        string customerbarcode = result.Substring(index1 + 2, index2 - index1 - 2);

                        string location = null;
                        if (Combobox_Location.SelectedItem != null)
                        {
                            location = Convert.ToString(Combobox_Location.SelectedItem);
                        }
                        else
                        {
                            location = "NULL";
                        }

                        if (AppSettings.IsMqttConnected)
                        {
                            _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2},{3}", customerbarcode, GlobalVar.PlantID, GlobalVar.Username, location), "SCAN_BARCODE_REWORK_ABCD" + GlobalVar.MacAddress);
                            _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_REWORK_ABCD" + GlobalVar.MacAddress);
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