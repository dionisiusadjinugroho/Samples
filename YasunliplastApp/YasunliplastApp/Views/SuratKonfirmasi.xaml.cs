using Java.Lang;
using Syncfusion.SfPullToRefresh.XForms;
using Syncfusion.XForms.Backdrop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MQTTnet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using System.ComponentModel;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuratKonfirmasi : BaseContentPage
    {
        App _application = Application.Current as App;
        SurkomViewModel viewModel;
        //public List<string> DataBefore;
        //public List<string> numbers;
        private readonly System.Threading.Timer Subs = null;
        public static bool Appv;
        public static bool Rjct;
        bool receiveData = false;// bool ModeEdit = false;
        bool subs = true;
        public SuratKonfirmasi()
        {
            InitializeComponent();
            BindingContext = viewModel = new SurkomViewModel();
            Subs = new System.Threading.Timer(this.TickTimer, null, 0, 1000);
            string pubmsg = GlobalVar.PlantID;
            //numbers = new List<string>();
            #region NOT USED
            //sfPullToRefresh.Pulling += PullToRefresh_Pulling;
            //sfPullToRefresh.Refreshing += PullToRefresh_Refreshing;
            //DataGridSF_Scheduling.PullToRefreshCommand = new Command(ExecutePullToRefreshCommand);

            //DataGridSF_Scheduling.WidthRequest = Application.Current.MainPage.Width;
            #region ADD DIVISI
            //_listDivision.Add("ADM PRODUKSI");
            //_listDivision.Add("PRODUKSI I");
            //_listDivision.Add("PRODUKSI II");
            //_listDivision.Add("PRODUKSI III");
            //_listDivision.Add("PPIC INJECTION");
            //_listDivision.Add("KA.DIV/KA.SIE/LEADER PRODUKSI");
            //_listDivision.Add("PRODUKSI NON SHIFT");
            //_listDivision.Add("QC PRODUKSI");
            //_listDivision.Add("PACKING & LABLE");
            //_listDivision.Add("QC INCOMING");
            //_listDivision.Add("QC OUT GOING");
            //_listDivision.Add("FINISHING");
            //_listDivision.Add("GUDANG MATERIAL");
            //_listDivision.Add("GUDANG READY");
            //_listDivision.Add("GUDANG WIP");
            //_listDivision.Add("G.MAINTENANCE");
            //_listDivision.Add("TECHNISI");
            //_listDivision.Add("TECHNISI YUNIOR");
            //_listDivision.Add("PROSES MATERIAL");
            //_listDivision.Add("GILINGAN");
            //_listDivision.Add("ASSEMBLING");
            //_listDivision.Add("PAINTING");
            //_listDivision.Add("QC PAINTING");
            //_listDivision.Add("PRINTING");
            //_listDivision.Add("QC PRINTING");
            //_listDivision.Add("M.MAINTENANCE");
            //_listDivision.Add("DELIVERY");
            //_listDivision.Add("DRIVER");
            //_listDivision.Add("ASS DRIVER");
            //_listDivision.Add("EXIM");
            //_listDivision.Add("HRD");
            //_listDivision.Add("KEBERSIHAN");
            //_listDivision.Add("RECEPTIONIS");
            //_listDivision.Add("ENGINEERING");
            //_listDivision.Add("STAFFPURCHAS/KASIR/PAYROLL");
            //_listDivision.Add("ADM ISO");
            //_listDivision.Add("IT");
            //_listDivision.Add("TUGAS DI AHM");
            //_listDivision.Add("TGS DI EPSON/KYKUNI/M MOTO/PTC");
            //_listDivision.Add("TUGAS DI PT GAYA MOTOR");
            //_listDivision.Add("TUGAS DI HAIER");
            //_listDivision.Add("TUGAS DI PT SANENG");
            //_listDivision.Add("TUGAS DI SHARP");
            //_listDivision.Add("TUGAS DI SUGITY");
            //_listDivision.Add("TUGAS DI TOSHIBA");
            //_listDivision.Add("STAFF GENERAL MANAGER");
            //_listDivision.Add("GA");
            //_listDivision.Add("TPS YAUP");
            //_listDivision.Add("P2K3");
            //_listDivision.Add("SHE");
            //_listDivision.Add("PLANT MANAGER");
            //Combobox_Division.DataSource = _listDivision;
            //Combobox_Division.SelectedItem = "ADM PRODUKSI";
            #endregion
            #region ADD NUMBERS
            //numbers.Add("-");
            //numbers.Add("1");
            //numbers.Add("2");
            //numbers.Add("3");
            //numbers.Add("4");
            //numbers.Add("5");
            //numbers.Add("6");
            //numbers.Add("7");
            //numbers.Add("8");
            //numbers.Add("9");
            //numbers.Add("10");
            //numbers.Add("11");
            //numbers.Add("12");
            //numbers.Add("13");
            //numbers.Add("14");
            //numbers.Add("15");
            #endregion
            #endregion
        }
        #region not used
        //private async void ExecutePullToRefreshCommand()
        //{
        //    this.DataGridSF_Scheduling.IsBusy = true;
        //    await Task.Delay(new TimeSpan(0, 0, 2));
        //    DataGridSF_Scheduling.Refresh();
        //    this.DataGridSF_Scheduling.IsBusy = false;
        //}
        //private void DataGridSF_Scheduling_GridTapped(object sender, Syncfusion.SfDataGrid.XForms.GridTappedEventArgs e)
        //{
        //    ModeEdit = true;
        //    int rowindex = e.RowColumnIndex.RowIndex;
        //    int columnindex = e.RowColumnIndex.ColumnIndex;
        //    if (rowindex < 0 || columnindex < 0)
        //    {
        //        return;
        //    }
        //    string columnName = this.DataGridSF_Scheduling.Columns[columnindex].MappingName;

        //    if (columnName.ToUpper() == "MASUK" /*|| columnName.ToUpper() == "MASUKAKTUAL" */|| columnName.ToUpper() == "PULANG" /*|| columnName.ToUpper() == "PULANGAKTUAL" || columnName.ToUpper() == "MASUKAKTUAL"*/)
        //    {
        //        strTimePickerCode = columnName.ToUpper();
        //        Scheduling test = this.DataGridSF_Scheduling.SelectedItem as Scheduling;
        //        _selectedSurkom = test;
        //        string[] strarray = null;
        //        if (columnName.ToUpper() == "MASUK")
        //            strarray = test.Masuk.Split(':');
        //        //if (columnName.ToUpper() == "MASUKAKTUAL")
        //        //    strarray = test.MasukAktual.Split(':');
        //        if (columnName.ToUpper() == "PULANG")
        //            strarray = test.Pulang.Split(':');
        //        //if (columnName.ToUpper() == "PULANGAKTUAL")
        //        //    strarray = test.PulangAktual.Split(':');



        //        if (test != null)
        //        {
        //            int i = 0;
        //            ObservableCollection<object> objectTime = customTimePicker.ItemsSource as ObservableCollection<object>;
        //            ObservableCollection<object> selectedItem = new ObservableCollection<object>();
        //            foreach ( var item in objectTime)
        //            {
        //                if(i==0)
        //                {
        //                    ObservableCollection<object> coll = item as ObservableCollection<object>;
        //                    foreach (var itemCol in coll)
        //                    {
        //                        string col = Convert.ToString(itemCol);
        //                        if(col == strarray[0])
        //                        {
        //                            i++;
        //                            selectedItem.Add(itemCol);
        //                            break;
        //                        }
        //                    }

        //                }
        //                if (i == 1)
        //                {

        //                    ObservableCollection<object> coll = item as ObservableCollection<object>;
        //                    foreach (var itemCol in coll)
        //                    {
        //                        string col = Convert.ToString(itemCol);
        //                        if (col == strarray[1])
        //                        {
        //                            i++;
        //                            selectedItem.Add(itemCol);
        //                            break;
        //                        }
        //                    }

        //                }
        //                if (i == 2)
        //                {

        //                    ObservableCollection<object> coll = item as ObservableCollection<object>;
        //                    foreach (var itemCol in coll)
        //                    {
        //                        string col = Convert.ToString(itemCol);
        //                        if (col == strarray[2])
        //                        {
        //                            i++;
        //                            selectedItem.Add(itemCol);
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //            if(selectedItem.Count > 0)
        //            {
        //                customTimePicker.SelectedItem = selectedItem;
        //            }
        //            customTimePicker.IsOpen = !customTimePicker.IsOpen;
        //        }
        //    }

        //    if (columnName.ToUpper() == "JUMLAHLEMBUR")
        //    {
        //        numberpicker.ItemsSource = numbers;
        //        Scheduling test = this.DataGridSF_Scheduling.SelectedItem as Scheduling;
        //        _selectedSurkom = test;
        //        string datax = test.JumlahLembur;
        //        numberpicker.SelectedItem = datax;
        //        numberpicker.IsOpen = !numberpicker.IsOpen;
        //    }          
        //}


        //private async void PullToRefresh_Refreshing(object sender, EventArgs args)
        //{
        //    GlobalVar.urutanPhotoScheduling = 0;

        //    if (string.IsNullOrEmpty(Combobox_Division.Text) || txtDate.Text.ToUpper().Contains("DATE"))
        //    {
        //        //sfPullToRefresh.IsRefreshing = false;
        //        return;
        //    }
        //    else
        //    {
        //        if (AppSettings.IsMqttConnected)
        //        {
        //            string pubmsg = null;
        //            pubmsg = string.Format("{0},{1},{2}", Combobox_Division.Text,txtDate.Text, GlobalVar.PlantID);
        //            _application.mqttHelper.PublishMQTT(pubmsg, "GETSCHEDULING_" + GlobalVar.MacAddress);
        //            _application.mqttHelper.SubscribeMQTT("SEND_SCHEDULING_" + GlobalVar.MacAddress);
        //            _application.mqttHelper.SubscribeMQTT("IMAGE_SCHEDULING_" + GlobalVar.MacAddress);

        //            //sfPullToRefresh.IsRefreshing = true;
        //            await Task.Delay(2000);
        //        }


        //    }

        //}

        //private void PullToRefresh_Pulling(object sender, PullingEventArgs args)
        //{
        //    args.Cancel = false;
        //    var progress = args.Progress;
        //}
        #endregion


        public void TickTimer(object obj)
        {
            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.SubscribeMQTT("SEND_SURKOM_LIST" + GlobalVar.MacAddress);
            }
            else
            {
                DisplayAlert("Error", "MQTT Not Connected Please Restart Application", "OK");
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "OnlyLandscape");
            string pubmsg = GlobalVar.PlantID;
            if (AppSettings.IsMqttConnected && subs == true)
            {
                if (AppSettings.IsMqttConnected)
                {
                    _application.mqttHelper.PublishMQTT(GlobalVar.MacAddress, "SEND_MAC_ADDRESS_YSL_SCHEDULE");
                }
                else
                {
                    DisplayAlert("Error", "MQTT Not Connected Please Restart Application", "OK");
                }
                _application.mqttHelper.PublishMQTT(pubmsg, "GET_SURKOM" + GlobalVar.MacAddress);
            }
            else
            {
                DisplayAlert("Error", "MQTT Not Connected Please Restart Application", "OK");
            }
            GlobalVar._SurkomList = new List<SurKom>();
            //PullRefresh.IsRefreshing = true;

            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.Surkoms, (sender, args) =>
            {           
                if (args != null)
                {
                    subs = false;
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        if (args == "EMPTY")
                        {
                            //sfPullToRefresh.IsRefreshing = false;
                            await DisplayAlert("Information", "Data Empty or Not Valid", "OK");
                        }
                        else
                        {
                            if (!receiveData)
                            {
                                receiveData = true;
                                if (args == "EMPTY")
                                {
                                    //sfPullToRefresh.IsRefreshing = false;
                                    await DisplayAlert("Information", "Data Empty or Not Valid", "OK");
                                }
                                else
                                {
                                    string[] strarray = { "@#$@" };                                  
                                    string[] strsplit = args.Split(strarray, StringSplitOptions.None);
                                    //int TTLqty = 0;
                                    int i = 0;
                                    SurKom surkom = new SurKom();
                                    foreach (string newstr in strsplit)
                                    {
                                        if (i == 0)
                                        {
                                            surkom = new SurKom();
                                            surkom.Photo = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(newstr)));
                                            i++;
                                        }
                                        else if (i == 1)
                                        {
                                            surkom.Nama = newstr;
                                            i++;
                                        }
                                        else if (i == 2)
                                        {
                                            surkom.Jabatan = newstr.ToUpper();
                                            i++;
                                        }
                                        else if (i == 3)
                                        {
                                            surkom.SurkomDate = newstr;
                                            i++;
                                        }

                                        else if (i == 4)
                                        {
                                            string[] jamplan = newstr.Split(':');
                                            TimeSpan jam_plan = new TimeSpan(Convert.ToInt32(jamplan[0]), Convert.ToInt32(jamplan[1]), Convert.ToInt32(jamplan[2]));
                                            surkom.Planning = jam_plan;
                                            i++;
                                        }
                                        else if (i == 5)
                                        {
                                            string[] jamact = newstr.Split(':');
                                            TimeSpan jam_act = new TimeSpan(Convert.ToInt32(jamact[0]), Convert.ToInt32(jamact[1]), Convert.ToInt32(jamact[2]));
                                            surkom.Actual = jam_act;
                                            i++;
                                        }
                                        else if (i == 6)
                                        {
                                            int o = 0;
                                            surkom.Reason = newstr;
                                            foreach (var d in GlobalVar._SurkomList)
                                            {
                                                if (d.Nama == surkom.Nama && d.SurkomDate == surkom.SurkomDate && d.Reason == surkom.Reason)
                                                {
                                                    o += 1;
                                                }
                                            }
                                            if (o == 0) GlobalVar._SurkomList.Add(surkom);
                                            i = 0;
                                        }
                                    }
                                    viewModel.surkoms = GlobalVar._SurkomList;
                                    sfListView.ItemsSource = viewModel.surkoms;
                                    //sfPullToRefresh.IsRefreshing = false;
                                    sfListView.RefreshView();
                                   // PullRefresh.IsRefreshing = false;
                                }
                            }
                        }
                    });
                }
                subs = true;
            });
        }
       
        public void Getsurkom()
        {

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "AllowBoth");
            MessagingCenter.Unsubscribe<MqttHelper, string>(this, MessagingCenterKeys.Scheduling);
        }
        #region
        //private void Combobox_Division_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        //{
        //    ////GlobalVar._listScheduling = new List<Scheduling>();

        //    //foreach (var item in _listDivision)
        //    //{
        //    //    if(item.ToUpper() == Combobox_Division.Text.ToUpper())
        //    //    {
        //    //        GetDataEmployee();
        //    //        break;
        //    //    }
        //    //}
        //}

        //private void TimePicker_OkButtonClicked(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        //{
        //    CustomTimePicker customTimePicker = sender as CustomTimePicker;
        //    ////////GET DATA FROM IEnumerableList
        //    IList listTimePicker = (IList)customTimePicker.SelectedItem;

        //    if(strTimePickerCode == "MASUK")
        //    {
        //        GlobalVar._listScheduling.Find(x => x.NPK == _selectedSurkom.NPK).Masuk = string.Format("{0}:{1}:{2}", listTimePicker[0], listTimePicker[1], listTimePicker[2]);
        //    }
        //    //if (strTimePickerCode == "MASUKAKTUAL")
        //    //{
        //    //    GlobalVar._listScheduling.Find(x => x.NPK == _selectedSurkom.NPK).MasukAktual = string.Format("{0}:{1}:{2}", listTimePicker[0], listTimePicker[1], listTimePicker[2]);

        //    //}
        //    if (strTimePickerCode == "PULANG")
        //    {
        //        GlobalVar._listScheduling.Find(x => x.NPK == _selectedSurkom.NPK).Pulang = string.Format("{0}:{1}:{2}", listTimePicker[0], listTimePicker[1], listTimePicker[2]);

        //    }
        //    //if (strTimePickerCode == "PULANGAKTUAL")
        //    //{
        //    //    GlobalVar._listScheduling.Find(x => x.NPK == _selectedSurkom.NPK).PulangAktual = string.Format("{0}:{1}:{2}", listTimePicker[0], listTimePicker[1], listTimePicker[2]);

        //    //}
        //}

        //protected override void OnSizeAllocated(double width, double height)
        //{
        //    base.OnSizeAllocated(width, height); //must be called
        //    if (Application.Current.MainPage.Width != width || Application.Current.MainPage.Height != height)
        //    {
        //        DataGridSF_Scheduling.HeightRequest = height;
        //        DataGridSF_Scheduling.WidthRequest = width;
        //        //reconfigure layout
        //    }
        //}

        //private void NumberPicker_OK(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        //{
        //    GlobalVar._listScheduling.Find(x => x.NPK == _selectedSurkom.NPK).JumlahLembur = numberpicker.SelectedItem.ToString();
        //}

        //async private void Previous_Clicked(object sender, EventArgs e)
        //{
        //    //if (ModeEdit == true)
        //    //{
        //    //    var result = await DisplayAlert("Warning", "Data has not been Saved. Saved Data now?", "Save", "Cancel");
        //    //    if (result == true) SaveData();
        //    //    else ModeEdit = false;
        //    //    return;
        //    //}
        //    //else
        //    //{
        //        if (Combobox_Division.SelectedIndex > 0)
        //        {
        //            Combobox_Division.SelectedIndex = Combobox_Division.SelectedIndex - 1;
        //        }
        //    //}
        //}

        //async private void Next_Clicked(object sender, EventArgs e)
        //{
        //    //if (ModeEdit == true)
        //    //{
        //    //    var result = await DisplayAlert("Warning", "Data has not been Saved. Saved Data now?", "Save", "Cancel");
        //    //    if (result == true) SaveData();
        //    //    else ModeEdit = false;               
        //    //    return;
        //    //}
        //    //else
        //    //{
        //        if (Combobox_Division.SelectedIndex < numbers.Count - 1)
        //        {
        //            Combobox_Division.SelectedIndex = Combobox_Division.SelectedIndex + 1;
        //        }
        //    //}            
        //}

        //private void Submit_Clicked(object sender, EventArgs e)
        //{
        //    SaveData();
        //}
        //async void SaveData()
        //{
        //    receiveData = false;
        //    string datakirim = null;
        //    foreach(var y in GlobalVar._listScheduling)
        //    {
        //        foreach(var t in DataBefore)
        //        {
        //            string[] str = t.Split(',');
        //            if (str[1] == "-") str[1] = "0";
        //            if (y.JumlahLembur == "-") y.JumlahLembur = "0";
        //            if(Convert.ToInt32(y.JumlahLembur) > Convert.ToInt32(str[1]) && y.NPK == str[0])
        //            {
        //                int newlembur = Convert.ToInt32(y.JumlahLembur) - Convert.ToInt32(str[1]);
        //                string[] waktu = y.Pulang.Split(':');
        //                int jampulangbaru = Convert.ToInt32(waktu[0]) + newlembur;
        //                TimeSpan newJamPulang = new TimeSpan(jampulangbaru, 0, 0);
        //                datakirim = datakirim + string.Format("{0}@#${1}@#${2}@#${3}@#${4}@#${5}@#$",GlobalVar.PlantID,Combobox_Division.Text,GlobalVar.Username,y.NPK,y.JumlahLembur,newJamPulang.ToString());
        //            }
        //            else if (Convert.ToInt32(y.JumlahLembur) < Convert.ToInt32(str[1]) && y.NPK == str[0])
        //            {
        //                int newlembur = Convert.ToInt32(str[1]) - Convert.ToInt32(y.JumlahLembur);
        //                string[] waktu = y.Pulang.Split(':');
        //                int jampulangbaru = Convert.ToInt32(waktu[0]) - newlembur;
        //                TimeSpan newJamPulang = new TimeSpan(jampulangbaru, 0, 0);
        //                datakirim = datakirim + string.Format("{0}@#${1}@#${2}@#${3}@#${4}@#${5}@#$", GlobalVar.PlantID, Combobox_Division.Text, GlobalVar.Username, y.NPK, y.JumlahLembur, newJamPulang.ToString());
        //            }
        //            else if (Convert.ToInt32(y.JumlahLembur) == Convert.ToInt32(str[1]) && y.NPK == str[0])
        //            {
        //                datakirim = datakirim + string.Format("{0}@#${1}@#${2}@#${3}@#${4}@#${5}@#$", GlobalVar.PlantID, Combobox_Division.Text, GlobalVar.Username, y.NPK, y.JumlahLembur, y.Pulang);
        //            }
        //        }
        //    }
        //    datakirim = datakirim.Remove(datakirim.Length - 3);
        //    if (AppSettings.IsMqttConnected)
        //    {
        //        _application.mqttHelper.PublishMQTT(datakirim, "SAVE_DATA_SHIFT_BARU" + GlobalVar.MacAddress);
        //        _application.mqttHelper.SubscribeMQTT("SAVE_SCHEDULING_" + GlobalVar.MacAddress);
        //    }
        //}
        #endregion

        async private void approve_Clicked(object sender, EventArgs e)
        {
            if (Appv == true)
            {
                await DisplayAlert("Information!!!","Data Berhasil Disimpan","OK");
                Appv = false;
            }
            string pubmsg = GlobalVar.PlantID;
            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(pubmsg, "GET_SURKOM" + GlobalVar.MacAddress);
            }
            else
            {
                DisplayAlert("Error", "MQTT Not Connected Please Restart Application", "OK");
            }
            receiveData = false;
        }

        async private void reject_Clicked(object sender, EventArgs e)
        {
            if (Rjct == true)
            {
                await DisplayAlert("Information!!!","Data Berhasil Disimpan","OK");
                Rjct = false;            
            }
            string pubmsg = GlobalVar.PlantID;
            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(pubmsg, "GET_SURKOM" + GlobalVar.MacAddress);
            }
            else
            {
                DisplayAlert("Error", "MQTT Not Connected Please Restart Application", "OK");
            }
            receiveData = false;
        } 

    }
}