using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.XForms.PopupLayout;
using Rg.Plugins.Popup.Services;
using System.Net.NetworkInformation;
using Android.App;
using Android.Content;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : BaseContentPage
    {
        string DeviceID = null;
        App _application = Xamarin.Forms.Application.Current as App;
        LoginViewModel viewModel;
        bool ShowLogin = false;
        bool ShowAuth = false;
        public LoginView()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginViewModel();


            #region GET MAC ADDRESS WIFI OR LAN XAMARIN FORMS
            foreach (var netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    var address = netInterface.GetPhysicalAddress();
                    GlobalVar.MacAddress = BitConverter.ToString(address.GetAddressBytes());
                }
            }
            #endregion
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<LoginView>(this, MessagingCenterKeys.ShowHomeview, async (sender) =>
            {
                if (!ShowLogin)
                {
                    ShowLogin = true;
                    viewModel.OnViewSelection.Execute("homeview");
                }
            });


            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("LOGIN_AUTH_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("LOGIN_INFO_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("LOGIN_DIV_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.Login_Authorization, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        if (!ShowAuth)
                        {
                            ShowAuth = true;
                            if (args == "WRONGUSERPASS")
                            {
                                //GlobalVar.SetSfPopupText("Alert", "Login not correct. Please try again.", AppearanceMode.OneButton);
                                await DisplayAlert("Alert", "Login not correct. Please try again.", "OK");
                            }
                            if (args == "AUTHORIZED")
                            {
                                GlobalVar.Username = txtUsername.Text;
                                GlobalVar.Password = txtPassword.Text;
                                MessagingCenter.Send<LoginView>(this, MessagingCenterKeys.ShowHomeview);
                            }
                            if (args == "REQUESTCHANGE")
                            {
                                GlobalVar.Username = txtUsername.Text;
                                GlobalVar.Password = txtPassword.Text;
                                //SetSfPopupText("Information", "First time Login. Please change your password.", AppearanceMode.TwoButton);
                                var answer = await DisplayAlert("Information", "First time Login. Please change your password.", "ACCEPT", "DECLINE");
                                if (answer)
                                {
                                    ShowChangePassword();
                                }
                                else
                                {
                                    DirectShowHomeview();
                                }
                            }
                        }
                    });
                }
            });


            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(GlobalVar.MacAddress, "SEND_MAC_ADDRESS_YSL");
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<LoginView>(this, MessagingCenterKeys.ShowHomeview);
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.Login_Authorization);
        }


        private async void LoginClick(object sender, EventArgs e)
        {
            if (txtPlant.Text == "Select Plant")
            {
                await DisplayAlert("Warning", "Please Select Plant First !", "OK");
                return;
            }


            ShowAuth = false;
            ShowLogin = false;
            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("LOGIN_AUTH_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("LOGIN_INFO_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("LOGIN_DIV_" + GlobalVar.MacAddress);
            }

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2},{3}", txtUsername.Text, txtPassword.Text, txtPlant.Text, GlobalVar.MacAddress), "LOGIN_YSL_");
            }


            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(GlobalVar.MacAddress, "SEND_MAC_ADDRESS_YSL");
            }

            if (!AppSettings.IsMqttConnected)
            {
                //GlobalVar.SetSfPopupText("Information", "MQTT Not Connected");
                DisplayAlert("Information", "Koneksi Terputus.", "OK");
            }


        }


        void SetSfPopupText(string HeaderText, string BodyText, AppearanceMode appearanceMode = AppearanceMode.OneButton, string AcceptText = "ACCEPT", string DeclineText = "DECLINE")
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
            sfPopup.PopupView.AcceptButtonText = AcceptText;
            sfPopup.PopupView.DeclineButtonText = DeclineText;
            sfPopup.PopupView.HeaderTitle = HeaderText;
            sfPopup.PopupView.ContentTemplate = dataTemplate;
            sfPopup.PopupView.AnimationMode = AnimationMode.SlideOnTop;
            sfPopup.PopupView.AcceptCommand = new Command(() => ShowChangePassword());
            sfPopup.PopupView.DeclineCommand = new Command(() => DirectShowHomeview());
            sfPopup.Show();
        }

        void ShowChangePassword()
        {
            PopupNavigation.Instance.PushAsync(new ChangePasswordView());
        }

        void DirectShowHomeview()
        {
            MessagingCenter.Send<LoginView>(this, MessagingCenterKeys.ShowHomeview);


        }


        private void SelectPlantClick(object sender, EventArgs e)
        {
            picker.IsOpen = true;
        }



        private void picker_OkButtonClicked(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            txtPlant.Text = picker.SelectedItem.ToString();
            GlobalVar.PlantID = txtPlant.Text;
        }


    }
}