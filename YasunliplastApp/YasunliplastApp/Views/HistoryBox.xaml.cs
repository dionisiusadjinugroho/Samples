using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
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
using Android.Media;
using Syncfusion.SfDataGrid.XForms;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryBox : BaseContentPage
    {
        App _application = Application.Current as App;
        HistoryBoxViewModel viewModel;
        
        public HistoryBox()
        {
            InitializeComponent();
            BindingContext = viewModel = new HistoryBoxViewModel();
            sfPullToRefresh1.Refreshing += PullToRefresh_Refreshing;
        }


        private async void PullToRefresh_Refreshing(object sender, EventArgs args)
        {
            DataGridSF_HistoryBox.IsBusy = true;           
            // Get_Message();
            await Task.Delay(new TimeSpan(0, 0, 2));
            DataGridSF_HistoryBox.Refresh();
            sfPullToRefresh1.IsRefreshing = false;
            this.DataGridSF_HistoryBox.IsBusy=false;            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GlobalVar._listHistoryBox = new List<ListHistoryBox>();
            viewModel.Historyboxes = GlobalVar._listHistoryBox;
            DataGridSF_HistoryBox.ItemsSource = viewModel.Historyboxes;
            DataGridSF_HistoryBox.Refresh();
            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("RIWAYAT_BOX" + GlobalVar.MacAddress);
            }
            else
            {
                DisplayAlert("Error", "MQTT Not Connected Please Restart Application", "OK");
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, "Info_Detail", (sender, args) =>
            {             
                ListHistoryBox listHistoryBox = new ListHistoryBox();               
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(async() =>
                    {
                        if (args == "Wrong_Barcode")
                        {
                            await BacktoScanner();
                        }
                        else
                        {                           
                            string[] strarray = { "@#$" };
                            string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                            //string[] datax = args.Split(',');
                            //List<string> strarray = new List<string>();
                            int i = 0, u = 0; int batas = strsplit.Count() - 19;
                            brcd_ID.Text = GlobalVar.BarcodeID;
                            foreach (string newstr in strsplit)
                            {                                
                                if (i == 0)
                                {
                                    //listHistoryBox = new ListHistoryBox();
                                    jmlhbrg.Text = newstr;
                                    i++;
                                }
                                else if (i == 1)
                                {
                                    posisiNow.Text = newstr;
                                    i++;
                                }
                                else if (i == 2)
                                {
                                    posisiTo.Text = newstr;
                                    i++;
                                }
                                else if (i == 3)
                                {
                                    PosisiLastScan.Text = newstr;
                                    i++;
                                }
                                else if (i == 4)
                                {
                                    WaktuLastScan.Text = newstr;
                                    i++;
                                }
                                else if (i == 5)
                                {
                                    pack.Text = newstr;
                                    i++;
                                }
                                else if (i == 6)
                                {
                                    itemID.Text = newstr;
                                    i++;
                                }
                                else if (i == 7)
                                {
                                    Operator_Scan.Text = newstr;
                                    i++;
                                }
                                else if (i == 8)
                                {
                                    opr_labl.Text = newstr;
                                    //GlobalVar._listScheduling.Add(scheduling);
                                    i++;
                                }
                                else if (i == 9)
                                {
                                    opr_injct.Text = newstr;
                                    i++;
                                }
                                else if (i == 10)
                                {
                                    adm_Pack.Text = newstr;
                                    i++;
                                }
                                else if (i == 11)
                                {
                                    scn_Pack.Text = newstr;
                                    i++;
                                }
                                else if (i == 12)
                                {
                                    ldr_Pack.Text = newstr;
                                    i++;
                                }
                                else if (i == 13)
                                {
                                    qc_Pack.Text = newstr;
                                    i++;
                                }
                                else if (i == 14)
                                {
                                    wh_Pack.Text = newstr;
                                    i++;
                                }
                                else if (i == 15)
                                {
                                    item.Text = newstr;
                                    i++;
                                }
                                else if (i == 16)
                                {
                                    hold_ID.Text = newstr;
                                    i++;
                                }
                                else if (i == 17)
                                {
                                    adm_hold.Text = newstr;
                                    i++;
                                }
                                else if (i == 18)
                                {
                                    release_hold.Text = newstr;
                                    i++;
                                }
                                else if (i == 19)
                                {
                                    listHistoryBox = new ListHistoryBox();
                                    listHistoryBox.ScanTime = newstr;     
                                    i++; u += 1;
                                }
                                else if (i == 20)
                                {
                                    listHistoryBox.Keterangan = newstr;
                                    i++; u += 1;
                                }
                                else if (i == 21)
                                {
                                    listHistoryBox.AdmScan = newstr;
                                    i++; u += 1;
                                }
                                else if (i == 22)
                                {
                                    listHistoryBox.PlannerScan = newstr;
                                    i++; u += 1;
                                }
                                else if (i == 23)
                                {
                                    listHistoryBox.ReceiveBy = newstr;
                                    if (GlobalVar._listHistoryBox.Count < batas/5)
                                    GlobalVar._listHistoryBox.Add(listHistoryBox);
                                    u += 1;
                                    if (u < batas) i = 19;
                                    else if (u == batas) i = 0;
                                }
                            }                        
                        }
                        viewModel.Historyboxes = GlobalVar._listHistoryBox;
                        DataGridSF_HistoryBox.ItemsSource = viewModel.Historyboxes;
                        DataGridSF_HistoryBox.Refresh();
                    });
                }
            });

            sfPullToRefresh1.IsRefreshing = false;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MqttHelper, List<ListHistoryBox>>(this, MessagingCenterKeys.InfoDetail);
        }

        async Task BacktoScanner()
        {
            await DisplayAlert("Information", "Barcode Wrong or Data Empty. Please Scan another Barcode.", "Ok");
        }

        
    }

}