using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace YasunliplastApp.ViewModels
{
    public class AbsensiOpViewModel : ViewModelBase
    {
        App _application;
        public ICommand OnViewSelection { get; set; }

        public AbsensiOpViewModel()
        {
            _application = Application.Current as App;
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));
        }

        async Task NavigateOnViewSelection(string viewType)
        {

        }
    }
}
