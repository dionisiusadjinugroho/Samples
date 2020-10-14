using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using YasunliplastApp.Views;

namespace YasunliplastApp.ViewModels
{
    public class HistoryBoxViewModel : ViewModelBase
    {
        App _application;

        public HistoryBoxViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            Historyboxes = new List<ListHistoryBox>();
        }

        public double ResWidth = 0;

        public List<ListHistoryBox> Historyboxes
        {
            get;
            set;
        }

    }
}
