using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using Syncfusion.SfPullToRefresh.XForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DEMOScannerZebraView : BaseContentPage
    {

        App _application = Application.Current as App;
        DEMOScannerZebraViewModel viewModel;

        public DEMOScannerZebraView()
        {
            InitializeComponent();
            BindingContext = viewModel = new DEMOScannerZebraViewModel();

            textboxScan.Focus();
            textboxScan.TextChanged += TextboxScan_TextChanged;

            GlobalVar._listDEMODataZebra = new List<DEMODataBarcode>();
        }


        private void TextboxScan_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string a = textboxScan.Text;
                string LastString = a.Substring(a.Length - 1);


                if (LastString == "\n")
                {
                    string b = a.Remove(a.Length - 1);

                    if (AppSettings.IsMqttConnected)
                    {
                        _application.mqttHelper.PublishMQTT(string.Format("{0},{1}", b, GlobalVar.PlantID), "SCAN_BARCODE_DEMO_" + GlobalVar.MacAddress);
                        _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_DEMO_" + GlobalVar.MacAddress);
                    }
                    textboxScan.Text = "";
                }
            }
            catch (Exception)
            {

            }

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("RESPON_BARCODE_DEMO_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPOND_BARCODE_DEMO, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {

                        string[] strarray = { "@#$" };
                        string[] strsplit = args.Split(strarray, StringSplitOptions.None);

                        if (args != "ERROR")
                        {
                            DEMODataBarcode dataDEMO = new DEMODataBarcode();
                            dataDEMO.BarcodeID = strsplit[0];
                            dataDEMO.ItemID = strsplit[1];
                            dataDEMO.ItemName = strsplit[2];

                            foreach(var item in GlobalVar._listDEMODataZebra)
                            {
                                if(item.BarcodeID == dataDEMO.BarcodeID)
                                {
                                    ///Return if find same BarcodeID
                                    return;
                                }
                            }

                            List<DEMODataBarcode> x = new List<DEMODataBarcode>();
                            sfListView.ItemsSource = x;

                            GlobalVar._listDEMODataZebra.Add(dataDEMO);
                            viewModel.listDataBarcode = GlobalVar._listDEMODataZebra;
                            sfListView.ItemsSource = viewModel.listDataBarcode;
                            labeltotal.Text = string.Format("Total = {0}", Convert.ToString(viewModel.listdatabarcode.Count()));
                        }
                        else
                        {
                            DisplayAlert("Warning", "Wrong Scanned Barcode. Please try again.", "OK");
                        }

                    });
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPOND_BARCODE_DEMO);
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

        List<DEMODataBarcode> demo = new List<DEMODataBarcode>();
        int i = 0;
        private void buttonadd_Clicked(object sender, EventArgs e)
        {
            List<DEMODataBarcode> x = new List<DEMODataBarcode>();
            sfListView.ItemsSource = x;


            DEMODataBarcode dataDEMO = new DEMODataBarcode();
            dataDEMO.BarcodeID = "BARCODE DUMMY" + i.ToString();
            dataDEMO.ItemID = "ITEM ID DUMMY" + i.ToString();
            dataDEMO.ItemName = "ITEM NAME DUMMY" + i.ToString();




            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            demo.Add(dataDEMO);
            GlobalVar._listDEMODataZebra = demo;
            sfListView.RefreshView();
            viewModel.listDataBarcode = GlobalVar._listDEMODataZebra;
            sfListView.ItemsSource = viewModel.listDataBarcode;

        }

        private bool FilterContacts(object obj)
        {
            if (filterText == null || filterText.Text == null)
                return true;

            var classInfo = obj as DEMODataBarcode;
            return (classInfo.BarcodeID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.ItemID.ToLower().Contains(filterText.Text.ToLower())
                || classInfo.ItemName.ToLower().Contains(filterText.Text.ToLower())
                );
        }


    }


}