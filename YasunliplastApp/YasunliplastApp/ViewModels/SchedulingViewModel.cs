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

namespace YasunliplastApp.ViewModels
{
    public class SchedulingViewModel : ViewModelBase
    {
        App _application;
        public ICommand OnViewSelection { get; set; }
        public SchedulingViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            schedulings = new List<Scheduling>();
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));

        }

        public double ResWidth = 0;

        public List<Scheduling> schedulings
        {
            get;
            set;
        }
        async Task NavigateOnViewSelection(string viewType)
        {


        }


    }
}
