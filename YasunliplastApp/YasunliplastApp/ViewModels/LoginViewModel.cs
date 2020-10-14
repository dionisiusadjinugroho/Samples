using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels.Base;
using YasunliplastApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace YasunliplastApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        App _application;

        public ICommand OnViewSelection { get; set; }

        public LoginViewModel()
        {
            _application = Application.Current as App;
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));


            PlantID = new List<string>();
            PlantID.Add("P1");
            PlantID.Add("P2");
            PlantID.Add("P3");
            PlantID.Add("LEGOK");
        }

        async Task NavigateOnViewSelection(string viewType)
        {
            if (viewType == "LoginUser")
            {
                if(VariableGlobal.LoginUSER == false)
                {
                    if (AppSettings.IsMqttConnected)
                    {
                        MessagingCenter.Send<MqttHelper, bool>(_application.mqttHelper, MessagingCenterKeys.OpenLoginScannerPage, true);
                    }
                }
                else
                {
                    await _application.MainPage.Navigation.PushAsync(new SelectPlantView(), true);
                }

            }
            if (viewType == "SelectPlant")
            {
                VariableGlobal.LoginUSER = false;
                await _application.MainPage.Navigation.PushAsync(new SelectPlantView(), true);
            }

            if (viewType == "homeview")
            {
                await _application.MainPage.Navigation.PopAsync();
                await _application.MainPage.Navigation.PushAsync(new HomeView());
            }
        }

        public List<string> PlantID
        {
            get;
            set;
        }
    }
}
