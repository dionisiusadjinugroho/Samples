using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPlantView : BaseContentPage
    {
        SelectPlantViewModel viewModel;
        public SelectPlantView()
        {
            InitializeComponent();
            BindingContext = viewModel = new SelectPlantViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}