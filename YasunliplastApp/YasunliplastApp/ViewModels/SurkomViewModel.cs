using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;
using System.Threading.Tasks;
using Syncfusion.ListView.XForms;
using YasunliplastApp.Views;

namespace YasunliplastApp.ViewModels
{
    public class SurkomViewModel : ViewModelBase
    {
        App _application;
        public ObservableCollection<SurKom> ListSurk { get; set; }
        public ICommand OnViewSelection { get; set; }
        public Command<object> APP { get; set; }
        public Command<object> RJT { get; set; }
        public SurkomViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;
            surkoms = new List<SurKom>();
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));
            //ListSurk = new ObservableCollection<SurKom>();
            APP = new Command<object>(ApproveClicked);
            RJT = new Command<object>(RejectClicked);
        }

        public double ResWidth = 0;

        public List<SurKom> surkoms
        {
            get;
            set;
        }
        async Task NavigateOnViewSelection(string viewType)
        {


        }
        public void ApproveClicked(object obj)
        {
            var surk = obj as SurKom;
            DateTime datsurk = Convert.ToDateTime(surk.SurkomDate);
            string pubmsg = string.Format("{0},{1},{2},{3},{4}", surk.Nama, datsurk.ToString("yyyy-MM-dd"), surk.Reason,GlobalVar.Username,GlobalVar.PlantID);
            _application.mqttHelper.PublishMQTT(pubmsg, "SEND_APPROVED_DATA_SURKOM" + GlobalVar.MacAddress);
            //surkoms.Remove(surk);
            SuratKonfirmasi.Appv = true;
        }
        public void RejectClicked(object obj)
        {
            var surk = obj as SurKom;
            string pubmsg = string.Format("{0},{1},{2},{3},{4}", surk.Nama, surk.SurkomDate, surk.Reason,GlobalVar.Username, GlobalVar.PlantID);
            _application.mqttHelper.PublishMQTT(pubmsg, "SEND_REJECTED_DATA_SURKOM" + GlobalVar.MacAddress);
            //surkoms.Remove(surk);
            SuratKonfirmasi.Rjct = true; 
        }
    }
}
