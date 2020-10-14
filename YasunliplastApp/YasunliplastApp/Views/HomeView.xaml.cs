using Rg.Plugins.Popup.Services;
using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : BaseContentPage
    {
        HomeViewModel viewModel;
        public HomeView()
        {
            InitializeComponent();
            BindingContext = viewModel = new HomeViewModel();
            MenuPermission.Permission(this);
            PopupNavigation.Instance.PushAsync(new HelloView());
        }

        public HomeView(string Plant) : this()
        {
            VariableGlobal.Plant = Plant;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<MqttHelper, bool>(this, MessagingCenterKeys.PopUpNotAuthorized, (sender, args) =>
            {
                if (args == true)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        //SetSfPopupText("Information", "You are not authorized to use this menu");
                        //sfPopup.Show();

                        DisplayAlert("Information", "You are not authorized to use this menu", "OK");
                        return;
                    });
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MqttHelper, bool>(this, MessagingCenterKeys.PopUpNotAuthorized);
        }

        //void SetSfPopupText(string HeaderText, string BodyText)
        //{
        //    Label popupContent;
        //    DataTemplate dataTemplate = new DataTemplate(() =>
        //    {
        //        popupContent = new Label();
        //        popupContent.Padding = 20;
        //        popupContent.Text = BodyText;
        //        popupContent.FontFamily = "Poppins";
        //        popupContent.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
        //        popupContent.FontAttributes = FontAttributes.Bold;
        //        popupContent.BackgroundColor = Color.White;
        //        return popupContent;
        //    });


        //    sfPopup.PopupView.AppearanceMode = AppearanceMode.OneButton;
        //    sfPopup.PopupView.AcceptButtonText = "ACCEPT";
        //    sfPopup.PopupView.HeaderTitle = HeaderText;
        //    sfPopup.PopupView.ContentTemplate = dataTemplate;
        //    sfPopup.PopupView.AnimationMode = AnimationMode.SlideOnTop;
        //}

    }


}