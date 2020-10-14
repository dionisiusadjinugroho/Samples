using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;

namespace YasunliplastApp.ViewModels
{
    public class DEMOScannerZebraRFID_CheckerItemDeliveryViewModel : ViewModelBase
    {
        App _application;

        public DEMOScannerZebraRFID_CheckerItemDeliveryViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            listdatabarcode = new List<CheckerDeliveryEPSONGudang>();
        }

        public double ResWidth = 0;

        public List<CheckerDeliveryEPSONGudang> listdatabarcode;
        public List<CheckerDeliveryEPSONGudang> listDataBarcode
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
