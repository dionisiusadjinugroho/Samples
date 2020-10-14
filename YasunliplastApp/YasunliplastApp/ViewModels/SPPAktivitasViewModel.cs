using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using YasunliplastApp.Utils;

namespace YasunliplastApp.ViewModels
{
    public class SPPAktivitasViewModel : ViewModelBase
    {
        App _application;
        public ICommand OnViewSelection { get; set; }

        public SPPAktivitasViewModel()
        {
            _application = Application.Current as App;
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));

            sppaktivitas = new List<ListSPPAktivitas>();

            itemTappedCommand = new Command(OnItemTapped);
        }

        async Task NavigateOnViewSelection(string viewType)
        {

        }

        public List<ListSPPAktivitas> sppaktivitas
        {
            get;
            set;
        }

        private Command itemTappedCommand;
        public Command ItemTappedCommand
        {
            get { return itemTappedCommand; }
            protected set { itemTappedCommand = value; }
        }

        public async void OnItemTapped(object obj)
        {
            if (!string.IsNullOrEmpty(GlobalVar.aktivitas))
            {
                List<string> _listcb = new List<string>();
                _listcb.Add("GANTI MOLD");
                _listcb.Add("TRIAL MOLD REGULAR");
                _listcb.Add("GANTI WARNA");
                _listcb.Add("GANTI SERIE (INSERT)");
                _listcb.Add("TURUN REPAIR MOLD");
                _listcb.Add("TRIAL MOLD AFTER O/H (OVERHOUL)");
                _listcb.Add("SUSULAN LABEL (PADA SAAT TRIAL LABEL TIDAK DISIAPKAN)");

                bool valid = false;
                foreach(var item in _listcb)
                {
                    if(item == GlobalVar.aktivitas)
                    {
                        valid = true;
                        break;
                    }
                }

                if(valid)
                {
                    await PopUpYesNo(obj);
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Warning", "Please choose correct Activity", "OK");
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Warning", "Please choose Activity First", "OK");
            }
        }

        public async Task PopUpYesNo(object obj)
        {
            var itemData = obj as ListSPPAktivitas;
            var action = App.Current.MainPage.DisplayAlert("Information", string.Format("Are you sure want to save {0} with Activity {1} ?", itemData.SPPNo, GlobalVar.aktivitas), "Yes", "No");
            if (await action)
            {
                if (AppSettings.IsMqttConnected)
                {
                    _application.mqttHelper.SubscribeMQTT("SAVE_RESPOND_SPP_AKTIVITAS_" + GlobalVar.MacAddress);
                    _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2},{3}",GlobalVar.PlantID,itemData.SPPNo,GlobalVar.Username,GlobalVar.aktivitas),"SAVE_SPP_AKTIVITAS_" + GlobalVar.MacAddress);
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Warning", "MQTT Disconnected. Please restart this application.", "OK");
                }
            }
        }

    }
}
