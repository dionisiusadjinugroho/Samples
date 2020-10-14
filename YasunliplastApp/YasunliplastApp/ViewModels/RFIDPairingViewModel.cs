using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using YasunliplastApp.Utils;

namespace YasunliplastApp.ViewModels
{
    public class RFIDPairingViewModel : ViewModelBase
    {
        App _application;
        public ICommand OnViewSelection { get; set; }

        public RFIDPairingViewModel()
        {
            _application = Application.Current as App;
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));

            listdatabarcode = new List<RFIDPairing>();
        }

        async Task NavigateOnViewSelection(string viewType)
        {

        }


        public List<RFIDPairing> listdatabarcode;
        public List<RFIDPairing> listDataBarcode
        {
            get { return listdatabarcode; }
            set
            {
                listdatabarcode = value;
                RaisedOnPropertyChanged("listDataBarcode");
            }
        }

        #region INotifyPropertyChanged Interface

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion

    }
}
