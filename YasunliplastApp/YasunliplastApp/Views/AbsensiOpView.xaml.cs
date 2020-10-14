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
    public partial class AbsensiOpView : BaseContentPage
    {
        App _application = Application.Current as App;
        AbsensiOpViewModel viewModel;
        bool ShowDataAbsensiOP = false;
        bool ShowMachine = false;
        public AbsensiOpView()
        {
            InitializeComponent();
            BindingContext = viewModel = new AbsensiOpViewModel();

            if (AppSettings.IsMqttConnected)
            {
                string pubmsgMachine = string.Format("{0},{1}", GlobalVar.PlantID, GlobalVar.MacAddress);
                _application.mqttHelper.PublishMQTT(pubmsgMachine, "GET_MACHINE_ABSENSI_OP");
            }

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();


            if (AppSettings.IsMqttConnected)
            {
                string pubmsgMachine = string.Format("{0},{1}", GlobalVar.PlantID, GlobalVar.MacAddress);
                _application.mqttHelper.PublishMQTT(pubmsgMachine, "GET_MACHINE_ABSENSI_OP");
                _application.mqttHelper.SubscribeMQTT("DATA_MACHINE_ABSENSI_OP" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.DATA_MACHINE_ABSENSI_OP, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        try
                        {
                            if (!ShowMachine)
                            {
                                ShowMachine = true;
                                string[] strarray = { "@#$" };
                                string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                                List<string> listmachine = new List<string>();
                                foreach (var item in strsplit)
                                {
                                    listmachine.Add(item);
                                }
                                Combobox_Machine.DataSource = listmachine;
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    });
                }
            });



            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("DATA_ABSENSI_OP" + GlobalVar.MacAddress);
            }


            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("DATA_ABSENSI_OP" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, "Data_Absensi_OP", (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (!ShowDataAbsensiOP)
                        {
                            ShowDataAbsensiOP = true;
                            if (args == "WRONGDATA")
                            {
                                //GlobalVar.SetSfPopupText("Warning", "Wrong Data. Please try again.", AppearanceMode.OneButton);
                                DisplayAlert("Warning", "Wrong Data. Please try again.", "OK");
                            }
                            if (args == "OP")
                            {
                                txtOperator.Text = GlobalVar.OperatorName;
                                Save_Absensi_OP();
                            }
                            if (args == "MC")
                            {
                                txtMachine.Text = GlobalVar.MachineName;
                                Save_Absensi_OP();
                            }
                        }
                    });
                }
            });


            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("DATA_ABSENSI_OP" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, "Data_Absensi_OP", (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (!ShowDataAbsensiOP)
                        {
                            ShowDataAbsensiOP = true;
                            if (args == "WRONGDATA")
                            {
                                //GlobalVar.SetSfPopupText("Warning", "Wrong Data. Please try again.", AppearanceMode.OneButton);
                                DisplayAlert("Warning", "Wrong Data. Please try again.", "OK");
                            }
                            if (args == "OP")
                            {
                                txtOperator.Text = GlobalVar.OperatorName;
                                Save_Absensi_OP();
                            }
                            if (args == "MC")
                            {
                                txtMachine.Text = GlobalVar.MachineName;
                                Save_Absensi_OP();
                            }
                        }
                    });
                }
            });

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("SAVE_RESPOND_ABSENSI_OP" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.Save_Respon, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (args == "SUCCESS")
                        {
                            //GlobalVar.SetSfPopupText("Information", "Data Saved Successfully", AppearanceMode.OneButton);
                            DisplayAlert("Information", "Data Saved Successfully", "OK");
                            txtOperator.Text = "";
                            txtMachine.Text = "";
                        }
                        if (args == "FAILED")
                        {
                            //GlobalVar.SetSfPopupText("Warning", "Data Failed to Save. Please contact IT team Immediately", AppearanceMode.OneButton);
                            DisplayAlert("Warning", "Data Failed to Save. Please contact IT Team Immediately.","OK");
                        }
                    });
                }
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.Data_Absensi_OP);
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.Save_Respon);
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
            ShowDataAbsensiOP = false;

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("DATA_ABSENSI_OP" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("SAVE_RESPOND_ABSENSI_OP" + GlobalVar.MacAddress);
            }

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
                TopText = "Scan Barcode/QR Operator or Machine",
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
                        Process(result.Text);
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
                string pubmsg = string.Format("{0},{1},{2}", GlobalVar.PlantID, result, GlobalVar.MacAddress);
                _application.mqttHelper.PublishMQTT(pubmsg, "SCAN_ABSENSI_OP_");
            }
        }

        internal void Save_Absensi_OP()
        {
            if(!string.IsNullOrEmpty(txtMachine.Text) && !string.IsNullOrEmpty(txtOperator.Text))
            {
                if (AppSettings.IsMqttConnected)
                {
                    _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2},{3}", GlobalVar.OperatorNPK, txtMachine.Text,GlobalVar.PlantID, GlobalVar.MacAddress), "SAVE_ABSENSI_OP");

                }
            }
        }

        private void Combobox_Machine_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            try
            {
                txtMachine.Text = Combobox_Machine.Text;
                Save_Absensi_OP();
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}