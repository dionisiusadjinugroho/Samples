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
using YasunliplastApp.Models;
using Com.Zebra.Rfid.Api3;
using System.Runtime.CompilerServices;
using System.Timers;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DEMOScannerZebraRFID_CheckerItemDeliveryView : BaseContentPage
    {
        private ReaderModel rfidModel;
        private static ObservableCollection<TagItem> _allItems;
        private Object tagreadlock = new object();
        private static Dictionary<String, int> tagListDict = new Dictionary<string, int>();
        private int totalTagCount = 0;
        private static string _uniquetags, _totaltags, _totaltime;
        private bool _listAvailable;
        private DateTime startime;
        private System.Timers.Timer aTimer;
        private string _connectionStatus;
        public string UniqueTags { get => _uniquetags; set { _uniquetags = value; OnPropertyChanged(); } }
        public string TotalTags { get => _totaltags; set { _totaltags = value; OnPropertyChanged(); } }
        public string TotalTime { get => _totaltime; set { _totaltime = value; OnPropertyChanged(); } }
        public bool listAvailable { get => _listAvailable; set { _listAvailable = value; OnPropertyChanged(); } }
        public bool hintAvailable { get => !_listAvailable; set { OnPropertyChanged(); } }
        public string readerConnection { get => _connectionStatus; set { _connectionStatus = value; OnPropertyChanged(); } }
        public bool isConnected { get => rfidModel.isConnected; set => OnPropertyChanged(); }

        App _application = Application.Current as App;
        DEMOScannerZebraRFID_CheckerItemDeliveryViewModel viewModel;

        List<string> listtagNum = new List<string>();


        public DEMOScannerZebraRFID_CheckerItemDeliveryView()
        {
            InitializeComponent();
            BindingContext = viewModel = new DEMOScannerZebraRFID_CheckerItemDeliveryViewModel();

            GlobalVar._listCheckerDeliveryEPSONGudang = new List<CheckerDeliveryEPSONGudang>();


            rfidModel = ReaderModel.readerModel;

            if (_allItems == null)
                _allItems = new ObservableCollection<TagItem>();

        }

        internal void UpdateIn()
        {
            rfidModel.TagRead += TagReadEvent;
            rfidModel.TriggerEvent += HHTriggerEvent;
            rfidModel.StatusEvent += StatusEvent;
            rfidModel.ReaderConnectionEvent += ReaderConnectionEvent;
            rfidModel.ReaderAppearanceEvent += ReaderAppearanceEvent;
        }
        internal void UpdateOut()
        {
            rfidModel.TagRead -= TagReadEvent;
            rfidModel.TriggerEvent -= HHTriggerEvent;
            rfidModel.StatusEvent -= StatusEvent;
            rfidModel.ReaderConnectionEvent -= ReaderConnectionEvent;
            rfidModel.ReaderAppearanceEvent -= ReaderAppearanceEvent;
        }
        public void ReaderAppearanceEvent(bool appeared)
        {

        }

        // Tag event
        public void TagReadEvent(TagData[] aryTags)
        {
            lock (tagreadlock)
            {
                for (int index = 0; index < aryTags.Length; index++)
                {
                    Console.WriteLine("Tag ID " + aryTags[index].TagID);

                    String tagID = aryTags[index].TagID;
                    if (tagListDict.ContainsKey(tagID))
                    {
                        tagListDict[tagID] = tagListDict[tagID] + aryTags[index].TagSeenCount;
                        UpdateCount(tagID, tagListDict[tagID], aryTags[index].PeakRSSI);
                    }
                    else
                    {
                        tagListDict.Add(tagID, aryTags[index].TagSeenCount);
                        UpdateList(tagID, aryTags[index].TagSeenCount, aryTags[index].PeakRSSI);
                    }
                    totalTagCount += aryTags[index].TagSeenCount;
                    updateCounts();
                    if (aryTags[index].OpCode == ACCESS_OPERATION_CODE.AccessOperationRead &&
                        aryTags[index].OpStatus == ACCESS_OPERATION_STATUS.AccessSuccess)
                    {
                        if (aryTags[index].MemoryBankData.Length > 0)
                        {
                            Console.WriteLine(" Mem Bank Data " + aryTags[index].MemoryBankData);
                        }
                    }
                }
            }
        }

        private void updateCounts()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                UniqueTags = tagListDict.Count.ToString();
                TotalTags = totalTagCount.ToString();
                TimeSpan span = (DateTime.Now - startime);
                TotalTime = span.ToString("hh\\:mm\\:ss");

            });
        }

        private void UpdateList(String tag, int count, short rssi)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                _allItems.Add(new TagItem { InvID = tag, TagCount = count, RSSI = rssi });
                string strtag = tag.Substring(tag.Length - 8, 8);
                Int64 curtag = Int64.Parse(strtag, System.Globalization.NumberStyles.HexNumber);
                foreach(var item in listtagNum)
                {

                    //Return if detect same tag
                    if(item == curtag.ToString())
                    {
                        return;
                    }
                }
                listtagNum.Add(curtag.ToString());
                listtagNum = listtagNum.Distinct().ToList();
                if (AppSettings.IsMqttConnected)
                {
                    _application.mqttHelper.PublishMQTT(string.Format("{0},{1}", curtag, GlobalVar.PlantID), "SCAN_RFID_DELIVERY_IN_GUDANG_" + GlobalVar.MacAddress);
                    _application.mqttHelper.SubscribeMQTT("RESPON_RFID_DELIVERY_IN_GUDANG_" + GlobalVar.MacAddress);
                }
            });
        }

        private void UpdateCount(String tag, int count, short rssi)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var found = _allItems.FirstOrDefault(x => x.InvID == tag);
                if (found != null)
                {
                    found.TagCount = count;
                    found.RSSI = rssi;
                }
            });
        }

        public void HHTriggerEvent(bool pressed)
        {
            if (pressed)
            {
                PerformInventory();
                listAvailable = true;
                hintAvailable = false;
            }
            else
            {
                StopInventory();
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void StopInventory()
        {
            rfidModel.StopInventory();
            aTimer?.Stop();
            aTimer?.Dispose();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void PerformInventory()
        {
            Device.BeginInvokeOnMainThread(() => { tagListDict.Clear(); _allItems.Clear(); });
            totalTagCount = 0;
            startime = DateTime.Now;
            SetTimer();
            rfidModel.PerformInventory();
        }

        public void StatusEvent(Events.StatusEventData statusEvent)
        {
            if (statusEvent.StatusEventType == STATUS_EVENT_TYPE.InventoryStartEvent)
            {
                //startime = DateTime.Now;
            }
            if (statusEvent.StatusEventType == STATUS_EVENT_TYPE.InventoryStopEvent)
            {
                updateCounts();
                int total = 0;
                foreach (var entry in tagListDict)
                    total += entry.Value;
                Console.WriteLine("Unique tags " + tagListDict.Count + " Total tags" + total);
            }
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            updateCounts();
        }

        public void ReaderConnectionEvent(bool connection)
        {
            updateHints();
            aTimer?.Stop();
            aTimer?.Dispose();
        }

        private void updateHints()
        {
            if (_allItems.Count == 0)
            {
                _listAvailable = false;
                readerConnection = isConnected ? "Connected" : "Not connected";
            }
            else
                _listAvailable = true;
        }


        internal void OnResume()
        {
            rfidModel?.SetTriggerMode();
            Console.WriteLine("OnResume");
        }

        internal void OnSleep()
        {
            rfidModel?.Disconnect();
            Console.WriteLine("OnSleep");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            rfidModel?.SetTriggerMode();

            UpdateIn();



            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("RESPON_RFID_DELIVERY_IN_GUDANG_" + GlobalVar.MacAddress);
            }
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_RFID_DELIVERY_IN_GUDANG, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {

                        string[] strarray = { "@#$" };
                        string[] strsplit = args.Split(strarray, StringSplitOptions.None);

                        if (!args.Contains("ERROR"))
                        {
                            CheckerDeliveryEPSONGudang dataQR = new CheckerDeliveryEPSONGudang();
                            dataQR.BarcodeID = strsplit[0];
                            dataQR.ItemID = strsplit[1];
                            dataQR.ItemName = strsplit[2];
                            dataQR.Qty = strsplit[3];
                            dataQR.LotNo = strsplit[4];
                            dataQR.RFID = strsplit[5];
                            dataQR.BoxType = strsplit[6];
                            dataQR.Rak = strsplit[7];
                            dataQR.Tingkat = strsplit[8];
                            dataQR.Nomor = strsplit[9];

                            if (dataQR.LotNo.ToUpper().Contains("RFID"))
                            {
                                dataQR.Color = Color.White;
                            }
                            else
                            {
                                dataQR.Color = Color.Red;
                            }


                            foreach (var item in GlobalVar._listCheckerDeliveryEPSONGudang)
                            {
                                if (item.BarcodeID == dataQR.BarcodeID)
                                {
                                    ///Return if find same BarcodeID
                                    return;
                                }
                            }

                            Device.BeginInvokeOnMainThread(() =>
                            {
                                List<CheckerDeliveryEPSONGudang> x = new List<CheckerDeliveryEPSONGudang>();
                                sfListView.ItemsSource = x;

                                GlobalVar._listCheckerDeliveryEPSONGudang.Add(dataQR);
                                viewModel.listDataBarcode = GlobalVar._listCheckerDeliveryEPSONGudang;
                                sfListView.ItemsSource = viewModel.listDataBarcode;

                                labeltotal.Text = string.Format("Total = {0}", Convert.ToString(viewModel.listdatabarcode.Count()));
                                labelItemName.Text = string.Format("Item Name : {0}", dataQR.ItemName);
                                labelItemID.Text = string.Format("Item ID : {0}", dataQR.ItemID);
                                labelQty.Text = string.Format("Qty : {0}", dataQR.Qty);
                                labelBox.Text = string.Format("Box Type : {0}", dataQR.BoxType);
                                labelRFID.Text = string.Format("RFID : {0}", dataQR.RFID);
                                labelRak.Text = string.Format("Rak : {0}", dataQR.Rak);
                                labelTingkat.Text = string.Format("Tingkat : {0}", dataQR.Tingkat);
                                labelNomor.Text = string.Format("Nomor : {0}", dataQR.Nomor);
                                remark.Text = "OK";
                            });
                        }
                        else
                        {
                            string RFID = strsplit[1];
                            remark.Text = string.Format("{0} - RFID Belum Terpairing. Atau belum Warehouse Out RFID.", RFID);
                            listtagNum.Remove(RFID);
                            //DisplayAlert("Warning", "RFID Belum Terpairing. Atau belum Warehouse Out RFID.", "OK");
                        }

                    });
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            UpdateOut();

            rfidModel?.Disconnect();

            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.RESPON_RFID_DELIVERY_IN_GUDANG);
        }

        List<CheckerDeliveryEPSONGudang> demo = new List<CheckerDeliveryEPSONGudang>();

        private void sfListView_SelectionChanged(object sender, Syncfusion.ListView.XForms.ItemSelectionChangedEventArgs e)
        {
            if(sfListView.SelectedItem != null)
            {
                var item_selected = sfListView.SelectedItem as CheckerDeliveryEPSONGudang;
                //barcode.Text = item_selected.ItemID;

                labelItemName.Text = string.Format("Item Name : {0}", item_selected.ItemName);
                labelItemID.Text = string.Format("Item ID : {0}", item_selected.ItemID);
                labelQty.Text = string.Format("Qty : {0}", item_selected.Qty);
                labelBox.Text = string.Format("Box Type : {0}", item_selected.BoxType);
                labelRFID.Text = string.Format("RFID : {0}", item_selected.RFID);
                labelRak.Text = string.Format("Rak : {0}", item_selected.Rak);
                labelTingkat.Text = string.Format("Tingkat : {0}", item_selected.Tingkat);
                labelNomor.Text = string.Format("Nomor : {0}", item_selected.Nomor);

                if (item_selected.LotNo.ToUpper().Contains("RFID") )
                {
                    labelItemName.TextColor = Color.Black;
                    labelItemID.TextColor = Color.Black;
                    labelQty.TextColor = Color.Black;
                    labelBox.TextColor = Color.Black;
                    labelRFID.TextColor = Color.Black;
                    labelRak.TextColor = Color.Black;
                    labelTingkat.TextColor = Color.Black;
                    labelNomor.TextColor = Color.Black;
                }
                else
                {
                    labelItemName.TextColor = Color.Red;
                    labelItemID.TextColor = Color.Red;
                    labelQty.TextColor = Color.Red;
                    labelBox.TextColor = Color.Red;
                    labelRFID.TextColor = Color.Red;
                    labelRak.TextColor = Color.Red;
                    labelTingkat.TextColor = Color.Red;
                    labelNomor.TextColor = Color.Red;
                }
            }
        }


        int i = 0;


        private void buttonadd_Clicked(object sender, EventArgs e)
        {

            i++;
            List<CheckerDeliveryEPSONGudang> x = new List<CheckerDeliveryEPSONGudang>();
            sfListView.ItemsSource = x;


            CheckerDeliveryEPSONGudang dataDEMO = new CheckerDeliveryEPSONGudang();
            dataDEMO.BarcodeID = "BARCODE DUMMY" + i.ToString();
            dataDEMO.ItemID = "ITEM ID DUMMY" + i.ToString();
            dataDEMO.ItemName = "ITEM NAME DUMMY" + i.ToString();
            dataDEMO.Qty = "QTY DUMMY" + i.ToString();



            demo.Add(dataDEMO);
            viewModel.listDataBarcode.Add(dataDEMO);
            sfListView.ItemsSource = viewModel.listDataBarcode;
            sfListView.RefreshView();
        }


    }


}