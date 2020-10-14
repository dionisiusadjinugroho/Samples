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
    public partial class QCSamplingDetailView : BaseContentPage
    {
        QCSamplingDetailViewModel viewModel;
        App _application = Application.Current as App;

        public QCSamplingDetailView()
        {
            InitializeComponent();
            BindingContext = viewModel = new QCSamplingDetailViewModel();
        }

        public QCSamplingDetailView(List<SamplingQC> samplingQc)
        {
            InitializeComponent();
            BindingContext = viewModel = new QCSamplingDetailViewModel();

            //GridControlItemSampling.ItemsSource = samplingQc;
            //GridControlItemSampling.RefreshData();
            DataGridSF_SamplingDetail.ItemsSource = samplingQc;
            DataGridSF_SamplingDetail.Refresh();
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