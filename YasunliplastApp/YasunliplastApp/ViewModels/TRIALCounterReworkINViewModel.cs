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
    public class TRIALCounterReworkINViewModel : ViewModelBase
    {
        App _application;

        public TRIALCounterReworkINViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            listreworkin = new List<ReworkIN>();
        }

        public double ResWidth = 0;

        public List<ReworkIN> listreworkin;
        public List<ReworkIN> listReworkIN
        {
            get { return listreworkin; }
            set
            {
                listreworkin = value;
                RaisedOnPropertyChanged("listReworkIN");
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
