using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class STOGudangReadyView : BaseContentPage
    {
        App _application = Application.Current as App;
        STOGudangReadyViewModel viewModel;
        private List<string> _listLocationGudang = new List<string>();

        List<string> _listBarcode = new List<string>();
        public STOGudangReadyView()
        {
            InitializeComponent();
            BindingContext = viewModel = new STOGudangReadyViewModel();

            textboxScan.Focus();
            textboxScan.TextChanged += TextboxScan_TextChanged;

            if (AppSettings.IsMqttConnected )
            {
                _application.mqttHelper.PublishMQTT(string.Format("{0},{1}", GlobalVar.PlantID, string.Format("STO_LOC_GUDANG{0}", GlobalVar.MacAddress)), "GET_STOGDR_LOCATION_GUDANG");
                _application.mqttHelper.SubscribeMQTT(string.Format("STO_LOC_GUDANG{0}", GlobalVar.MacAddress));
            }
        }

        private void TextboxScan_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string a = textboxScan.Text;
                string LastString = a.Substring(a.Length - 1);

                if (LastString == "\n" || LastString == "\r")
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


            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(string.Format("{0},{1}", GlobalVar.PlantID, string.Format("STO_LOC_GUDANG{0}", GlobalVar.MacAddress)), "GET_STOGDR_LOCATION_GUDANG");
                _application.mqttHelper.SubscribeMQTT(string.Format("STO_LOC_GUDANG{0}", GlobalVar.MacAddress));
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_GUDANG, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        _listLocationGudang = new List<string>();

                        string[] strarray = { "@#$" };
                        string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                        foreach (var item in strsplit)
                        {
                            _listLocationGudang.Add(item);
                        }
                        Combobox_Location.DataSource = _listLocationGudang;
                    });

                }
            });

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("RESPON_SCAN_STO" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_SCAN_STO, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        if (args.Contains("ERROR"))
                        {
                            await DisplayAlert("Warning", "Barcode yg terscan salah. Mohon ulangi kembali.", "OK");

                        }
                        else if(args.Contains("ALREADYSTO"))
                        {
                            string[] strarray = { "@#$" };
                            string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                            labelSTOtotal.Text = string.Format("Total = {0}", strsplit[0]);
                            labelSTOtotGudang.Text = string.Format("GUDANG = {0}", strsplit[1]);
                            labelSTOtotDelivery.Text = string.Format("DELIVERY = {0}", strsplit[2]);
                            labelSTOtotInjection.Text = string.Format("INJECTION = {0}", strsplit[3]);
                            labelSTOtotFinishing.Text = string.Format("FINISHING = {0}", strsplit[4]);
                            labelSTOtotPrinting.Text = string.Format("PRINTING = {0}", strsplit[5]);
                            labelSTOtotOTHER.Text = string.Format("OTHER = {0}", strsplit[6]);


                            labelNontotal.Text = string.Format("Total = {0}", strsplit[7]);
                            labelNontotGudang.Text = string.Format("GUDANG = {0}", strsplit[8]);
                            labelNontotDelivery.Text = string.Format("DELIVERY = {0}", strsplit[9]);
                            labelNontotInjection.Text = string.Format("INJECTION = {0}", strsplit[10]);
                            labelNontotFinishing.Text = string.Format("FINISHING = {0}", strsplit[11]);
                            labelNontotPrinting.Text = string.Format("PRINTING = {0}", strsplit[12]);
                            labelNontotOTHER.Text = string.Format("OTHER = {0}", strsplit[13]);

                            labelBarcodeID.Text = string.Format("Label : {0}", strsplit[14]);
                            labelPackageID.Text = string.Format("Package : {0}", strsplit[15]);

                            if(strsplit[1] == strsplit[8])
                            {
                                labelSTOtotGudang.TextColor = Color.GreenYellow;
                                labelNontotGudang.TextColor = Color.GreenYellow;
                            }
                            else
                            {
                                labelSTOtotGudang.TextColor = Color.Red;
                                labelNontotGudang.TextColor = Color.Red;
                            }

                            await DisplayAlert("Information", "Sudah di STO.", "OK");

                            Vibration.Vibrate();
                        }
                        else
                        {
                            string[] strarray = { "@#$" };
                            string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                            labelSTOtotal.Text = string.Format("Total = {0}", strsplit[0]);
                            labelSTOtotGudang.Text = string.Format("GUDANG = {0}", strsplit[1]);
                            labelSTOtotDelivery.Text = string.Format("DELIVERY = {0}", strsplit[2]);
                            labelSTOtotInjection.Text = string.Format("INJECTION = {0}", strsplit[3]);
                            labelSTOtotFinishing.Text = string.Format("FINISHING = {0}", strsplit[4]);
                            labelSTOtotPrinting.Text = string.Format("PRINTING = {0}", strsplit[5]);
                            labelSTOtotOTHER.Text = string.Format("OTHER = {0}", strsplit[6]);


                            labelNontotal.Text = string.Format("Total = {0}", strsplit[7]);
                            labelNontotGudang.Text = string.Format("GUDANG = {0}", strsplit[8]);
                            labelNontotDelivery.Text = string.Format("DELIVERY = {0}", strsplit[9]);
                            labelNontotInjection.Text = string.Format("INJECTION = {0}", strsplit[10]);
                            labelNontotFinishing.Text = string.Format("FINISHING = {0}", strsplit[11]);
                            labelNontotPrinting.Text = string.Format("PRINTING = {0}", strsplit[12]);
                            labelNontotOTHER.Text = string.Format("OTHER = {0}", strsplit[13]);


                            if (strsplit[1] == strsplit[8])
                            {
                                labelSTOtotGudang.TextColor = Color.GreenYellow;
                                labelNontotGudang.TextColor = Color.GreenYellow;
                            }
                            else
                            {
                                labelSTOtotGudang.TextColor = Color.Red;
                                labelNontotGudang.TextColor = Color.Red;
                            }

                            labelBarcodeID.Text = string.Format("Label : {0}", strsplit[14]);
                            labelPackageID.Text = string.Format("Package : {0}", strsplit[15]);
                            Vibration.Vibrate();
                        }
                    });

                }
            });

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_GUDANG);
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_SCAN_STO);
        }


        private async void Process(string result)
        {
            if (AppSettings.IsMqttConnected && !string.IsNullOrEmpty(result))
            {

                if (result.Length > 11 && result.Length <= 50 && !string.IsNullOrEmpty(Combobox_Location.Text))
                {
                    string pubmsg = string.Format("{0},{1},{2},{3},{4}", GlobalVar.PlantID, GlobalVar.Username, Combobox_Location.Text.ToUpper(), result, "RESPON_SCAN_STO" + GlobalVar.MacAddress);

                    _application.mqttHelper.PublishMQTT(pubmsg, "SCAN_BARCODE_STO_GDRTESTING");
                    _application.mqttHelper.SubscribeMQTT("RESPON_SCAN_STO" + GlobalVar.MacAddress);


                }
                else if (result.Length > 50 && !string.IsNullOrEmpty(Combobox_Location.Text))
                {
                    if (result.Contains("Z1") && result.Contains("Z2") && result.Contains("Z3") && result.Contains("Z4") && result.Contains("Z5") && result.Contains("Z6") && result.Contains("Z7"))
                    {
                        int index1 = result.IndexOf("Z5");
                        int index2 = result.IndexOf("|", index1);
                        string customerbarcode = result.Substring(index1 + 2, index2 - index1 - 2);
                        string pubmsg = string.Format("{0},{1},{2},{3},{4}", GlobalVar.PlantID, GlobalVar.Username, Combobox_Location.Text.ToUpper(), customerbarcode, "RESPON_SCAN_STO" + GlobalVar.MacAddress);


                        _application.mqttHelper.PublishMQTT(pubmsg, "SCAN_BARCODE_STO_GDRTESTING");
                        _application.mqttHelper.SubscribeMQTT("RESPON_SCAN_STO" + GlobalVar.MacAddress);




                    }

                }
                else if (result.Length >= 3 && result.Length <= 4)
                {
                    try
                    {
                        int a = Convert.ToInt32(result);
                    }
                    catch
                    {
                        Combobox_Location.Text = result;
                    }
                }
                else if (string.IsNullOrEmpty(Combobox_Location.Text))
                {
                    await DisplayAlert("Warning", "Harap isi Lokasi Terlebih Dahulu.", "OK");
                }

            }

        }



        private void Combobox_Location_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {

        }


        private async void Button_ScanRFID_UsingCamera_Clicked(object sender, EventArgs e)
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

    }
}