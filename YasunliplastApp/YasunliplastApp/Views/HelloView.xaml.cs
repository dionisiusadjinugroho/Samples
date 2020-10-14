using YasunliplastApp.Utils;
using Rg.Plugins.Popup.Services;
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
    public partial class HelloView : Rg.Plugins.Popup.Pages.PopupPage
    {
        public HelloView()
        {
            InitializeComponent();

            txtHello.Text = string.Format("Hello {0} {1}Have a nice day !", GlobalVar.EmployeeName, Environment.NewLine);
        }

        private void CloseClick(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}