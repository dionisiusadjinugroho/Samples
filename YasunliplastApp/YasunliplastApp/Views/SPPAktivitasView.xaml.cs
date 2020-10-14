using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using System.Collections.Generic;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SPPAktivitasView : BaseContentPage
    {
        App _application = Application.Current as App;
        SPPAktivitasViewModel viewModel;
        bool ShowDataSPPAktivitas = false;
        bool SaveSPPAktivitas = false;

        public SPPAktivitasView()
        {
            InitializeComponent();
            BindingContext = viewModel = new SPPAktivitasViewModel();



            #region Add ListCombobox

            List<string> _listcb = new List<string>();
            _listcb.Add("GANTI MOLD");
            _listcb.Add("TRIAL MOLD REGULAR");
            _listcb.Add("GANTI WARNA");
            _listcb.Add("GANTI SERIE (INSERT)");
            _listcb.Add("TURUN REPAIR MOLD");
            _listcb.Add("TRIAL MOLD AFTER O/H (OVERHOUL)");
            _listcb.Add("SUSULAN LABEL (PADA SAAT TRIAL LABEL TIDAK DISIAPKAN)");

            Combobox_Activity.DataSource = _listcb;
            #endregion
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("SEND_LIST_SPP_AKTIVITAS_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.SEND_LIST_SPP_AKTIVITAS, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (!ShowDataSPPAktivitas)
                        {
                            ShowDataSPPAktivitas = true;
                            if (args == "EMPTY")
                            {
                                DisplayAlert("Warning", "Wrong Scanning Data or None found active SPP for this machine. Please try again.", "OK");
                            }
                            else
                            {
                                GlobalVar._listSPPAktivitas = new List<ListSPPAktivitas>();
                                string[] strarray = { "@#$" };
                                string[] strsplit = args.Split(strarray, StringSplitOptions.None);

                                //string dummytesttt = @"SPPP300061329@#$0@#$@#$PT.EPSON INDONESIA@#$COVER FRONT@#$EPIC M@#$SPPP300061395@#$0@#$@#$PT.EPSON INDONESIA@#$COVER R F1@#$GAGA2@#$SPPP300061316@#$0@#$GALUH PERMANA@#$PT.EPSON INDONESIA@#$COVER RIGHT MP@#$GAGA@#$SPPP300061329@#$0@#$@#$PT.EPSON INDONESIA@#$COVER FRONT@#$EPIC M@#$SPPP300061395@#$0@#$@#$PT.EPSON INDONESIA@#$COVER R F1@#$GAGA2@#$SPPP300061316@#$0@#$GALUH PERMANA@#$PT.EPSON INDONESIA@#$COVER RIGHT MP@#$GAGA@#$SPPP300061329@#$0@#$@#$PT.EPSON INDONESIA@#$COVER FRONT@#$EPIC M@#$SPPP300061395@#$0@#$@#$PT.EPSON INDONESIA@#$COVER R F1@#$GAGA2@#$SPPP300061316@#$0@#$GALUH PERMANA@#$PT.EPSON INDONESIA@#$COVER RIGHT MP@#$GAGA@#$";
                                //string[] strsplit = dummytesttt.Split(strarray, StringSplitOptions.None);

                                ListSPPAktivitas sppactivity = new ListSPPAktivitas();
                                int i = 0;
                                foreach (string newstr in strsplit)
                                {
                                    if (i == 0)
                                    {
                                        sppactivity = new ListSPPAktivitas();
                                        sppactivity.SPPNo = newstr;
                                        i++;
                                    }
                                    else if (i == 1)
                                    {
                                        sppactivity.Status = newstr;
                                        if(sppactivity.Status == "0")
                                        {
                                            sppactivity.Color = Color.Black;
                                        }
                                        else
                                        {
                                            sppactivity.Color = Color.Red;
                                        }
                                        i++;
                                    }
                                    else if (i == 2)
                                    {
                                        sppactivity.TechnisiName = "Tech = " + newstr;
                                        i++;
                                    }
                                    else if (i == 3)
                                    {
                                        sppactivity.CustomerName = newstr;
                                        i++;
                                    }
                                    else if (i == 4)
                                    {
                                        sppactivity.MouldName = "Mould = " + newstr;
                                        i++;
                                    }
                                    else if (i == 5)
                                    {
                                        sppactivity.Model = "Model = " + newstr;
                                        GlobalVar._listSPPAktivitas.Add(sppactivity);
                                        i = 0;
                                    }

                                }
                                viewModel.sppaktivitas = GlobalVar._listSPPAktivitas;
                                sfListView.ItemsSource = viewModel.sppaktivitas;

                            }
                        }
                    });
                }
            });

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("SAVE_RESPOND_SPP_AKTIVITAS_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.SAVE_RESPOND_SPP_AKTIVITAS, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (!SaveSPPAktivitas)
                        {
                            SaveSPPAktivitas = true;
                            if (args == "ERROR")
                            {
                                DisplayAlert("Error", "Error Save SPP Activity. Please contact IT Team Immediately.", "OK");
                            }
                            else
                            {
                                DisplayAlert("Information", "Data Saved Successfully", "OK");
                                Combobox_Activity.Text = "";
                                GlobalVar._listSPPAktivitas = new List<ListSPPAktivitas>();
                                sfListView.ItemsSource = GlobalVar._listSPPAktivitas;
                            }
                        }
                    });
                }
            });

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.SEND_LIST_SPP_AKTIVITAS);
        }

        internal void SetSfPopupText(string HeaderText, string BodyText, AppearanceMode appearanceMode = AppearanceMode.OneButton, string AcceptText = "ACCEPT", string DeclineText = "DECLINE")
        {
            Label popupContent;
            DataTemplate dataTemplate = new DataTemplate(() =>
            {
                popupContent = new Label();
                popupContent.Text = BodyText;
                popupContent.FontFamily = "Poppins";
                popupContent.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
                popupContent.FontAttributes = FontAttributes.Bold;
                popupContent.BackgroundColor = Color.White;
                return popupContent;
            });
            SfPopupLayout sfPopup = new SfPopupLayout();
            sfPopup.PopupView.AppearanceMode = appearanceMode;
            sfPopup.PopupView.AcceptButtonText = "ACCEPT";
            sfPopup.PopupView.DeclineButtonText = "DECLINE";
            sfPopup.PopupView.HeaderTitle = HeaderText;
            sfPopup.PopupView.ContentTemplate = dataTemplate;
            sfPopup.PopupView.AnimationMode = AnimationMode.SlideOnTop;
            sfPopup.Show();
        }

        private async void ScanQRClick(object sender, EventArgs e)
        {
            ShowDataSPPAktivitas = false;
            SaveSPPAktivitas = false;

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("SEND_LIST_SPP_AKTIVITAS_" + GlobalVar.MacAddress);

            }

            if (AppSettings.IsMqttConnected)
            {
                await NavigateToScannerpage();
                //MessagingCenter.Send<MqttHelper, string>(_application.mqttHelper, MessagingCenterKeys.SEND_LIST_SPP_AKTIVITAS, "asdfsadf");
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
                TopText = "Scan Barcode/QR Machine",
                BottomText = "Scanning will happen automatically",
            };
            overlay.BindingContext = overlay;
            ZXingScannerPage scanPage = new ZXingScannerPage(options, overlay)
            {
                HasTorch = true,
                IsTorchOn = false
            };

            overlay.FlashButtonClicked += async (sender, e) =>
            {
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
                        Process(string.Format("{0},{1}",result.Text,GlobalVar.PlantID));
                    }

                });
            };
            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);
        }

        private void Process(string result)
        {
            if (AppSettings.IsMqttConnected && !string.IsNullOrEmpty(result))
            {
                _application.mqttHelper.PublishMQTT(result, "SCAN_SPP_AKTIVITAS_" + GlobalVar.MacAddress);
            }
        }


        private void Combobox_Activity_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            GlobalVar.aktivitas = Combobox_Activity.Text;
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

        private bool FilterContacts(object obj)
        {
            if (filterText == null || filterText.Text == null)
                return true;

            var classInfo = obj as ListSPPAktivitas;
            return (classInfo.SPPNo.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.Status.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.TechnisiName.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.CustomerName.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.MouldName.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.Model.ToLower().Contains(filterText.Text.ToLower()));
        }
    }
}