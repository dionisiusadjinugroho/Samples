using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.ViewModels
{
    public class QCSamplingDetailViewModel : ViewModelBase
    {
        App _application;

        public QCSamplingDetailViewModel()
        {
            _application = Application.Current as App;
        }
    }
}
