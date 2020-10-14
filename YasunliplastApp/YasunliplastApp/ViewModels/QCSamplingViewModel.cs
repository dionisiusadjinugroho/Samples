using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.ViewModels
{
    public class QCSamplingViewModel : ViewModelBase
    {
        App _application;

        public QCSamplingViewModel()
        {
            _application = Application.Current as App;
        }
    }
}
