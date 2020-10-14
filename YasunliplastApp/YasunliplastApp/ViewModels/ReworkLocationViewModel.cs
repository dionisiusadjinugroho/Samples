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
    public class ReworkLocationViewModel : ViewModelBase
    {
        App _application;

        public ReworkLocationViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            listReworkLocation = new List<ReworkLocation>();
        }

        public double ResWidth = 0;

        public List<ReworkLocation> listreworklocation;
        public List<ReworkLocation> listReworkLocation
        {
            get { return listreworklocation; }
            set
            {
                listreworklocation = value;
                RaisedOnPropertyChanged("listReworkLocation");
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
