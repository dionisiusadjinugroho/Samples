﻿using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using YasunliplastApp.Utils;
using Syncfusion.SfPullToRefresh.XForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportAbsensiView : BaseContentPage
    {
        bool ShowReport = false;
        App _application = Application.Current as App;
        ReportAbsensiViewModel viewModel;
        public ReportAbsensiView()
        {
            InitializeComponent();
            BindingContext = viewModel = new ReportAbsensiViewModel();

            sfPullToRefresh.Pulling += PullToRefresh_Pulling;
            sfPullToRefresh.Refreshing += PullToRefresh_Refreshing;

        }

        private async void PullToRefresh_Refreshing(object sender, EventArgs args)
        {
            GlobalVar.urutanPhotoAbsensi = 0;
            GlobalVar._listreportAbsensi = new List<ReportAbsensi>();
            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("ReportAbsensi_ServerToClient_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("ReportAbsensiFAIL_ServerToClient_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("ReportImageAbsensiOperator_ServerToClient_" + GlobalVar.MacAddress);
            }

            ShowReport = false;
            ////////GET DATA FROM IEnumerableList
            IList listenddate = (IList)dtimepicker_end.SelectedItem;
            string strenddate = string.Format("{0}-{1}-{2} {3}:{4}:00", listenddate[0], listenddate[1], listenddate[2], listenddate[3], listenddate[4]);

            IList liststartdate = (IList)dtimepicker_start.SelectedItem;
            string strstartdate = string.Format("{0}-{1}-{2} {3}:{4}:00", liststartdate[0], liststartdate[1], liststartdate[2], liststartdate[3], liststartdate[4]);
            /////////////////////////////////////////
            ///
            if (AppSettings.IsMqttConnected)
            {
                string pubmsg = string.Format("{0},{1},{2},{3}", strstartdate, strenddate, GlobalVar.PlantID, GlobalVar.MacAddress);
                _application.mqttHelper.PublishMQTT(pubmsg, "ReportAbsensi_ClientToServer_");
            }



            sfPullToRefresh.IsRefreshing = true;
            await Task.Delay(2000);
        }

        private void PullToRefresh_Pulling(object sender, PullingEventArgs args)
        {
            args.Cancel = false;
            var progress = args.Progress;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("ReportAbsensi_ServerToClient_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("ReportAbsensiFAIL_ServerToClient_" + GlobalVar.MacAddress);
                _application.mqttHelper.SubscribeMQTT("ReportImageAbsensiOperator_ServerToClient_" + GlobalVar.MacAddress);
            }

            MessagingCenter.Subscribe<MqttHelper, List<ReportAbsensi>>(this, MessagingCenterKeys.ReportAbsensi_ServerToClient_, (sender, args) =>
            {
                if (!ShowReport)
                {
                    ShowReport = true;
                    if (args != null)
                    {
                        Device.BeginInvokeOnMainThread(async () =>
                        {
                            viewModel.ReportAbsensis = args;
                            sfListView.ItemsSource = viewModel.ReportAbsensis;
                            sfPullToRefresh.IsRefreshing = false;
                        });
                    }
                }
            });

            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.ReportAbsensiFAIL_ServerToClient_, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        if (args == "FAIL")
                        {
                            sfPullToRefresh.IsRefreshing = false;
                        }
                    });
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MqttHelper, List<ReportAbsensi>>(this, MessagingCenterKeys.ReportAbsensi_ServerToClient_);
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.ReportAbsensiFAIL_ServerToClient_);
        }

        private void ToolbarStartDate_Clicked(object sender, EventArgs e)
        {
            dtimepicker_start.IsOpen = !dtimepicker_start.IsOpen;
        }

        private void ToolbarEndDate_Clicked(object sender, EventArgs e)
        {
            dtimepicker_end.IsOpen = !dtimepicker_end.IsOpen;
        }

        private void filterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sfListView.DataSource != null)
            {
                sfListView.DataSource.Filter = FilterContacts;
                sfListView.DataSource.RefreshFilter();
            }
            sfListView.RefreshView();
        }

        private bool FilterContacts(object obj)
        {
            if (filterText == null || filterText.Text == null)
                return true;

            var classInfo = obj as ReportAbsensi;
            return (classInfo.EmployeeID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.EmployeeName.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.Machine.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.WorkDate.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.Machine.ToLower().Contains(filterText.Text.ToLower()));
        }
    }


}