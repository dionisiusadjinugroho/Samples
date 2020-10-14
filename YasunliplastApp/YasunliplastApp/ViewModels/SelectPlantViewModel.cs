using YasunliplastApp.ViewModels.Base;
using YasunliplastApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace YasunliplastApp.ViewModels
{
    public class SelectPlantViewModel : ViewModelBase
    {
        App _application;

        public ICommand OnViewSelection { get; set; }

        public SelectPlantViewModel()
        {
            _application = Application.Current as App;
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));
        }

        async Task NavigateOnViewSelection(string viewType)
        {
            if (viewType == "homeviewP1")
                await _application.MainPage.Navigation.PushAsync(new HomeView("P1"), true);
            if (viewType == "homeviewP2")
                await _application.MainPage.Navigation.PushAsync(new HomeView("P2"), true);
            if (viewType == "homeviewP3")
                await _application.MainPage.Navigation.PushAsync(new HomeView("P3"), true);

        }
    }
}
