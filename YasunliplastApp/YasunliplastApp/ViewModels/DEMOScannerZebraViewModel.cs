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
    public class DEMOScannerZebraViewModel : ViewModelBase
    {
        App _application;

        public DEMOScannerZebraViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            listdatabarcode = new List<DEMODataBarcode>();
        }

        public double ResWidth = 0;

        public List<DEMODataBarcode> listdatabarcode;
        public List<DEMODataBarcode> listDataBarcode
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
