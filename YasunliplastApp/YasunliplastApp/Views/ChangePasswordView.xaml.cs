using YasunliplastApp.Utils;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePasswordView : Rg.Plugins.Popup.Pages.PopupPage
    {
        App _application = Application.Current as App;
        public ChangePasswordView()
        {
            InitializeComponent();
        }

        private void ChangePasswordClick(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNewPassword.Text) || (!string.IsNullOrEmpty(txtRepeatNewPassword.Text)))
            {
                if (txtNewPassword.Text == txtRepeatNewPassword.Text)
                {
                    if(AppSettings.IsMqttConnected)
                    {
                        GlobalVar.Password = txtNewPassword.Text;
                        _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2},{3}", GlobalVar.Username, txtNewPassword.Text,GlobalVar.PlantID, GlobalVar.MacAddress), "CHANGE_PASS_");
                        PopupNavigation.Instance.PopAsync();
                        MessagingCenter.Send<LoginView>(new LoginView(), MessagingCenterKeys.ShowHomeview);
                    }
                }
            }
        }

        private void NewPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                Img1.Source = "Wrong.png";
            }
            else
            {
                Img1.Source = "Correct.png";
            }

            if (string.IsNullOrEmpty(txtRepeatNewPassword.Text))
            {
                Img2.Source = "Wrong.png";
            }
            else if (txtRepeatNewPassword.Text == txtNewPassword.Text)
            {
                Img2.Source = "Correct.png";
            }
            else if (txtRepeatNewPassword.Text != txtNewPassword.Text)
            {
                Img2.Source = "Wrong.png";
            }
        }
    }
}