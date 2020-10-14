using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public partial class RFIDPairingView : BaseContentPage
    {
        App _application = Application.Current as App;
        RFIDPairingViewModel viewModel;
        private bool First = false;
        private List<string> _listLocationGudang = new List<string>();

        public RFIDPairingView()
        {
            InitializeComponent();
            BindingContext = viewModel = new RFIDPairingViewModel();

            textboxScan.Focus();
            textboxScan.TextChanged += TextboxScan_TextChanged;


            if (AppSettings.IsMqttConnected && First == false)
            {
                _application.mqttHelper.PublishMQTT(GlobalVar.PlantID, "GET_LOCATION_GUDANG_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("RESPON_LOCATION_GUDANG_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("RESPON_SAVE_RFID_PAIRING_" + GlobalVar.MacAddress);
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


            if (AppSettings.IsMqttConnected && First == false)
            {
                _application.mqttHelper.PublishMQTT(GlobalVar.PlantID, "GET_LOCATION_GUDANG_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("RESPON_LOCATION_GUDANG_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_GUDANG, (sender, args) =>
            {
                if (args != null)
                {
                    if (!First)
                    {
                        Device.BeginInvokeOnMainThread(async () =>
                        {
                            First = true;
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
                }
            });

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_RFID_PAIRING, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        if (!args.Contains("ERROR"))
                        {
                            txtBarcode.Text = args;
                            Save_RFID_Pairing();
                        }
                        else
                        {
                            string[] strarray = { "@#$" };
                            string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                            await DisplayAlert("Alert", strsplit[1], "OK");
                        }
                    });

                }
            });

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("RESPON_SAVE_RFID_PAIRING_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_SAVE_RFID_PAIRING, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        string[] strarray = { "@#$" };
                        string[] strsplit = args.Split(strarray, StringSplitOptions.None);

                        if (!args.Contains("ERROR"))
                        {
                            string ItemDivisi = strsplit[10];
                            //GlobalVar.SetSfPopupText("Information", "Data Saved Successfully", AppearanceMode.OneButton);
                            if (args.Contains("SUCCESSFULL"))
                            {
                                if (ItemDivisi.ToUpper().Contains("GUDANG"))
                                {
                                    await DisplayAlert("Information", "Data Pairing RFID & STO Saved Successfully.", "OK");
                                }
                                else if (ItemDivisi.ToUpper().Contains("INJECTION"))
                                {
                                    await DisplayAlert("Information", "Data Pairing RFID & STO Saved Successfully. Barang Belum Warehouse IN.", "OK");
                                }
                                else
                                {
                                    await DisplayAlert("Information", string.Format("Data Pairing RFID & STO Saved Successfully. Barang Milik Divisi {0}",ItemDivisi), "OK");
                                }
                            }
                            else
                            {
                                if (ItemDivisi.ToUpper().Contains("GUDANG"))
                                {
                                    await DisplayAlert("Information", "Data STO Saved Successfully. Pairing Gagal karena Barang Bukan Milik EPSON.", "OK");
                                }
                                else if (ItemDivisi.ToUpper().Contains("INJECTION"))
                                {
                                    await DisplayAlert("Information", "Data STO Saved Successfully. Pairing Gagal karena Barang Bukan Milik EPSON. Barang Belum Warehouse IN.", "OK");
                                }
                                else
                                {
                                    await DisplayAlert("Information", string.Format("Data STO Saved Successfully. Pairing Gagal karena Barang Bukan Milik EPSON. Barang Milik Divisi {0}", ItemDivisi), "OK");
                                }
                            }

                            RFIDPairing dataRFIDPairing = new RFIDPairing();
                            dataRFIDPairing.BarcodeID = strsplit[1];
                            dataRFIDPairing.ItemID = strsplit[2];
                            dataRFIDPairing.ItemName = strsplit[3];
                            dataRFIDPairing.Qty = strsplit[4];
                            dataRFIDPairing.RFID = strsplit[5];
                            dataRFIDPairing.BoxType = strsplit[6];
                            dataRFIDPairing.DivOwner = strsplit[10];

                            if (args.Contains("SUCCESSFULL"))
                            {
                                dataRFIDPairing.Color = Color.White;
                            }
                            else
                            {
                                dataRFIDPairing.Color = Color.Red;
                            }


                            foreach (var item in GlobalVar._listQRCodeDeliveryEPSON)
                            {
                                if (item.BarcodeID == dataRFIDPairing.BarcodeID)
                                {
                                    ///Return if find same BarcodeID
                                    return;
                                }
                            }

                            List<QRCodeDeliveryEPSON> x = new List<QRCodeDeliveryEPSON>();
                            sfListView.ItemsSource = x;

                            GlobalVar._listRFIDPairing.Add(dataRFIDPairing);
                            viewModel.listDataBarcode = GlobalVar._listRFIDPairing;
                            sfListView.ItemsSource = viewModel.listDataBarcode;

                            labeltotal.Text = string.Format("Total = {0}", Convert.ToString(viewModel.listdatabarcode.Count()));
                            labelItemName.Text = string.Format("Item Name : {0}", dataRFIDPairing.ItemName);
                            labelItemID.Text = string.Format("Item ID : {0}", dataRFIDPairing.ItemID);
                            labelQty.Text = string.Format("Qty : {0}", dataRFIDPairing.Qty);
                            labelBox.Text = string.Format("Box Type : {0}", dataRFIDPairing.BoxType);
                            labelRFID.Text = string.Format("RFID : {0}", dataRFIDPairing.RFID);
                            labelDivOwner.Text = string.Format("Milik Divisi : {0}", dataRFIDPairing.DivOwner);
                            if (args.Contains("SUCCESSFULL"))
                                remark.Text = "OK";
                            else
                                remark.Text = "Barang Bukan Milik EPSON";

                            txtBarcode.Text = "";
                            txtRFID.Text = "";
                            textboxScan.Focus();
                        }
                        else
                        {
                            await DisplayAlert("Alert", strsplit[1], "OK");
                        }
                    });
                }
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_SAVE_RFID_PAIRING);
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_RFID_PAIRING);
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_GUDANG);
        }


        private async void Process(string result)
        {
            if (AppSettings.IsMqttConnected && !string.IsNullOrEmpty(result))
            {
                if(result.Length == 11 && !string.IsNullOrEmpty(Combobox_Location.Text))
                {
                    result = result.Remove(0, 1);
                    txtRFID.Text = result;
                    Save_RFID_Pairing();
                }
                else if(result.Length > 11 && result.Length <= 50 && !string.IsNullOrEmpty(Combobox_Location.Text))
                {
                    string pubmsg = string.Format("{0},{1}", GlobalVar.PlantID, result);
                    _application.mqttHelper.PublishMQTT(pubmsg, "SCAN_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress);
                    _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress);
                    _application.mqttHelper.SubscribeMQTT("RESPON_SAVE_RFID_PAIRING_" + GlobalVar.MacAddress);
                }
                else if (result.Length > 50 && !string.IsNullOrEmpty(Combobox_Location.Text))
                {
                    if (result.Contains("Z1") && result.Contains("Z2") && result.Contains("Z3") && result.Contains("Z4") && result.Contains("Z5") && result.Contains("Z6") && result.Contains("Z7"))
                    {
                        int index1 = result.IndexOf("Z5");
                        int index2 = result.IndexOf("|", index1);
                        string customerbarcode = result.Substring(index1 + 2, index2 - index1 - 2);
                        string pubmsg = string.Format("{0},{1}", GlobalVar.PlantID, customerbarcode);
                        _application.mqttHelper.PublishMQTT(pubmsg, "SCAN_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress);
                        _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress);
                        _application.mqttHelper.SubscribeMQTT("RESPON_SAVE_RFID_PAIRING_" + GlobalVar.MacAddress);
                    }

                }
                else if(result.Length >= 3 && result.Length <= 4)
                {
                    try
                    {
                        int a = Convert.ToInt32(result);
                    }
                    catch
                    {
                        Combobox_Location.Text = result;
                        Save_RFID_Pairing();
                    }
                }
                else if (string.IsNullOrEmpty(Combobox_Location.Text))
                {
                    await DisplayAlert("Warning", "Harap isi Lokasi Terlebih Dahulu.", "OK");
                }

            }
            else if(!AppSettings.IsMqttConnected)
            {
                await DisplayAlert("Warning", "MQTT Not Connected. Please Restart Application", "OK");
            }
        }


        internal async void Save_RFID_Pairing()
        {
            if(!string.IsNullOrEmpty(txtRFID.Text) && !string.IsNullOrEmpty(txtBarcode.Text) && !string.IsNullOrEmpty(Combobox_Location.Text))
            {
                if (AppSettings.IsMqttConnected)
                {
                    string barcode = txtBarcode.Text;
                    string RFID = txtRFID.Text;
                    string Location = Combobox_Location.Text;
                    _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2},{3},{4}", GlobalVar.Username, barcode, RFID, Location, GlobalVar.PlantID), "SAVE_RFID_PAIRING_" + GlobalVar.MacAddress);
                    _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress);
                    _application.mqttHelper.SubscribeMQTT("RESPON_SAVE_RFID_PAIRING_" + GlobalVar.MacAddress);
                }
            }
        }

        private void Combobox_Location_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {

        }

        private void sfListView_SelectionChanged(object sender, Syncfusion.ListView.XForms.ItemSelectionChangedEventArgs e)
        {
            if (sfListView.SelectedItem != null)
            {
                var item_selected = sfListView.SelectedItem as RFIDPairing;
                //barcode.Text = item_selected.ItemID;

                labelItemName.Text = string.Format("Item Name : {0}", item_selected.ItemName);
                labelItemID.Text = string.Format("Item ID : {0}", item_selected.ItemID);
                labelQty.Text = string.Format("Qty : {0}", item_selected.Qty);
                labelBox.Text = string.Format("Box Type : {0}", item_selected.BoxType);
                labelRFID.Text = string.Format("RFID : {0}", item_selected.RFID);
                labelDivOwner.Text = string.Format("Milik Divisi : {0}", item_selected.DivOwner);
                string color = Convert.ToString(item_selected.Color);
                if (color == "Color [A=255, R=0, G=0, B=0]") ///RED
                {

                    labelItemName.TextColor = Color.Red;
                    labelItemID.TextColor = Color.Red;
                    labelQty.TextColor = Color.Red;
                    labelBox.TextColor = Color.Red;
                    labelRFID.TextColor = Color.Red;
                    labelDivOwner.TextColor = Color.Red;
                    remark.TextColor = Color.Red;
                    remark.Text = "Barang Bukan Milik EPSON";
                }

                else
                {

                    labelItemName.TextColor = Color.Black;
                    labelItemID.TextColor = Color.Black;
                    labelQty.TextColor = Color.Black;
                    labelBox.TextColor = Color.Black;
                    labelRFID.TextColor = Color.Black;
                    labelDivOwner.TextColor = Color.Black;
                    remark.TextColor = Color.Black;
                    remark.Text = "OK";

                }

            }
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