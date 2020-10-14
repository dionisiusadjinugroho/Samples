using Syncfusion.SfPullToRefresh.XForms;
using Syncfusion.XForms.Backdrop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonitoringStockView : SfBackdropPage
    {

        App _application = Application.Current as App;
        MonitoringStockViewModel viewModel;
        List<string> _listPosition = new List<string>();
        public MonitoringStockView()
        {
            InitializeComponent();
            BindingContext = viewModel = new MonitoringStockViewModel();

            sfPullToRefresh.Pulling += PullToRefresh_Pulling;
            sfPullToRefresh.Refreshing += PullToRefresh_Refreshing;

            #region ADD POSITION DIVISI
            _listPosition.Add("Gudang");
            _listPosition.Add("Gudang Material");
            _listPosition.Add("Printing");
            _listPosition.Add("Painting");
            _listPosition.Add("Finishing");
            _listPosition.Add("Assembling");
            _listPosition.Add("Delivery");
            _listPosition.Add("QC Out Going");
            _listPosition.Add("Engineering");
            _listPosition.Add("QC Produksi");
            Combobox_Position.DataSource = _listPosition;
            #endregion
        }

        private async void PullToRefresh_Refreshing(object sender, EventArgs args)
        {




            if (string.IsNullOrEmpty(Combobox_Position.Text))
            {
                sfPullToRefresh.IsRefreshing = false;
                return;
            }
            else
            {
                if (AppSettings.IsMqttConnected)
                {
                    string pubmsg = null;
                    if (string.IsNullOrEmpty(Combobox_SearchItem.Text))
                    {
                        pubmsg = string.Format("{0},{1},{2}", "ALL", Combobox_Position.Text,GlobalVar.PlantID);
                    }
                    else
                    {
                        pubmsg = string.Format("{0},{1},{2}", Combobox_SearchItem.Text, Combobox_Position.Text, GlobalVar.PlantID);
                    }
                    _application.mqttHelper.PublishMQTT(pubmsg, "MONITORING_STOCK_" + GlobalVar.MacAddress);
                    _application.mqttHelper.SubscribeMQTT("RESPON_MONITORING_STOCK_" + GlobalVar.MacAddress);

                    sfPullToRefresh.IsRefreshing = true;
                    await Task.Delay(2000);
                }


            }

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
                string pubmsg = string.Format("{0}", GlobalVar.PlantID);
                _application.mqttHelper.PublishMQTT(pubmsg, "GETALLITEM_" + GlobalVar.MacAddress);
            }
            _application.mqttHelper.SubscribeMQTT("SENDITEMALL_" + GlobalVar.MacAddress);
            _application.mqttHelper.SubscribeMQTT("RESPON_MONITORING_STOCK_" + GlobalVar.MacAddress);
            MessagingCenter.Subscribe<MqttHelper, List<string>>(this, MessagingCenterKeys.SENDITEMALL_, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Combobox_SearchItem.DataSource = args.OrderBy(x=>x);

                    });
                }
            });

            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.MonitoringStock, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (args == "EMPTY")
                        {
                            sfPullToRefresh.IsRefreshing = false;
                        }
                        else
                        {
                            GlobalVar._listmonitoringStock = new List<MonitoringStock>();
                            string[] strsplit = args.Split(',');
                            int TTLqty = 0;
                            int i = 0;
                            MonitoringStock monitoringStock = new MonitoringStock();
                            foreach (string newstr in strsplit)
                            {
                                if (i == 0)
                                {
                                    monitoringStock = new MonitoringStock();
                                    monitoringStock.ItemCode = newstr;
                                    i++;
                                }
                                else if (i == 1)
                                {
                                    monitoringStock.ItemName = newstr;
                                    i++;
                                }
                                else if (i == 2)
                                {
                                    monitoringStock.QTY = "QTY = " + newstr;
                                    string qty = monitoringStock.QTY.Replace("QTY = ", "");
                                    TTLqty += Convert.ToInt32(qty);
                                    i++;
                                }
                                else if (i == 3)
                                {
                                    monitoringStock.PackageID = newstr;
                                    i++;
                                }
                                else if (i == 4)
                                {
                                    monitoringStock.Location = "Location = " + newstr;
                                    i++;
                                }
                                else if (i == 5)
                                {
                                    monitoringStock.MainModel = "Model = " + newstr;
                                    i++;
                                }
                                else if (i == 6)
                                {
                                    monitoringStock.Status = newstr;
                                    i++;
                                }
                                else if (i == 7)
                                {
                                    monitoringStock.Judge = newstr;
                                    i++;
                                }
                                else if (i == 8)
                                {
                                    if(!string.IsNullOrEmpty(monitoringStock.Judge))
                                    {
                                        if (monitoringStock.Judge.ToUpper().Contains("OK"))
                                        {
                                            monitoringStock.Color = Color.DodgerBlue;
                                        }
                                        else
                                        {
                                            monitoringStock.Color = Color.Red;
                                        }
                                    }
                                    if(monitoringStock.Status.ToUpper().Contains("HOLD"))
                                    {
                                        monitoringStock.Color = Color.Red;
                                    }
                                    if(string.IsNullOrEmpty(monitoringStock.Judge) && !monitoringStock.Status.ToUpper().Contains("HOLD"))
                                    {
                                        monitoringStock.Color = Color.Black;
                                    }
                                    monitoringStock.BoxType = newstr;
                                    i++;
                                }
                                else if (i == 9)
                                {
                                    monitoringStock.CustomerName = newstr;
                                    GlobalVar._listmonitoringStock.Add(monitoringStock);
                                    i = 0;
                                }
                            }
                            labelTotal.Text = "TOTAL = " + TTLqty.ToString();
                            viewModel.monitoringstocks = GlobalVar._listmonitoringStock;
                            sfListView.ItemsSource = viewModel.monitoringstocks;
                            sfPullToRefresh.IsRefreshing = false;
                        }

                    });
                }
            });





        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            //MessagingCenter.Unsubscribe<MqttHelper, List<ReportSampling>>(this, MessagingCenterKeys.SamplingReportSampling_ServerToClientA);
            MessagingCenter.Unsubscribe<MqttHelper, List<string>>(this, MessagingCenterKeys.SENDITEMALL_);
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

            var classInfo = obj as MonitoringStock;
            return (classInfo.ItemCode.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.ItemName.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.QTY.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.PackageID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.Location.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.MainModel.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.Status.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.Judge.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.BoxType.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.CustomerName.ToLower().Contains(filterText.Text.ToLower())
                );
        }

        private void SfBackdropPage_BackLayerStateChanged(object sender, EventArgs e)
        {
            if (this.IsBackLayerRevealed)
            {
                Combobox_SearchItem.IsEnabled = true;
                Combobox_Position.IsEnabled = true;
            }
            else
            {
                Combobox_SearchItem.IsEnabled = false;
                Combobox_Position.IsEnabled = false;
            }

        }


    }
}