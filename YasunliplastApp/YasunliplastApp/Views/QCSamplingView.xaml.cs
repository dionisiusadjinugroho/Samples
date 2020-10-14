using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels;
using YasunliplastApp.Views.Base;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace YasunliplastApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QCSamplingView : BaseContentPage
    {
        QCSamplingViewModel viewModel;
        App _application = Application.Current as App;

        System.Timers.Timer timerRefreshUI;

        List<string> listNG;

        List<SamplingQC> listDetailSamplingQC;

        int loopOperator = 0;

        bool ShownConfirmationSave = false;

        private CancellationTokenSource cancelTimer;


        public QCSamplingView()
        {

            InitializeComponent();
            BindingContext = viewModel = new QCSamplingViewModel();


            timerRefreshUI = new System.Timers.Timer();
            timerRefreshUI.Interval = 500;
            timerRefreshUI.Elapsed += TimerRefreshUI_Elapsed;
            timerRefreshUI.Stop();


            #region AddComboboxNG
            listNG = new List<string>();
            listNG.Add("Flash");
            listNG.Add("Remain Trimming");
            listNG.Add("Trimming");
            listNG.Add("Silver");
            listNG.Add("Black Dot");
            listNG.Add("Gate Long");
            listNG.Add("Over Cut");
            listNG.Add("Short Shoot");
            listNG.Add("Flow Mark");
            listNG.Add("Pin Mark");
            listNG.Add("Sink Mark");
            listNG.Add("Color Dot");
            listNG.Add("Finger Mark");
            listNG.Add("Scratch");
            listNG.Add("Dented");
            listNG.Add("Etching Dull");
            listNG.Add("Stretch Mark");
            listNG.Add("Broken Rib/Hook");
            listNG.Add("Broken Tips");
            listNG.Add("Broken Boss");
            listNG.Add("Bending/Melengkung");
            listNG.Add("Warpage/Melintir");
            listNG.Add("Oil Mark");
            listNG.Add("Printing Tipis");
            listNG.Add("Printing Smear");
            listNG.Add("Printing Bayang");
            listNG.Add("Printing Putus");
            listNG.Add("Printing Kotor");
            listNG.Add("Printing Other");
            listNG.Add("Flash Terinject");
            listNG.Add("Void/Bubble");
            listNG.Add("Stringing/Meler");
            listNG.Add("Dirty");
            listNG.Add("Wrong Contain");
            listNG.Add("Mixed Part");
            listNG.Add("Burry");
            listNG.Add("White Stress");
            listNG.Add("Hair Mark");
            listNG.Add("Other");
            Combobox_NG_SFusion.DataSource = listNG;///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion AddNG

            listDetailSamplingQC = new List<SamplingQC>();

        }

        private void TimerRefreshUI_Elapsed(object sender, ElapsedEventArgs e)
        {

            timerRefreshUI.Stop();
            Device.BeginInvokeOnMainThread(() =>
            {
                DisplayAlert("Test", "TIMER", "Cancel");
            });

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            _application.mqttHelper.SubscribeMQTT("SamplingAdd_ServerToClientA" + GlobalVar.MacAddress);
            MessagingCenter.Subscribe<MqttHelper, List<SamplingQC>>(this, MessagingCenterKeys.SamplingAdd_ServerToClientA, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        //GridControlItemSampling.ItemsSource = args;
                        //GridControlItemSampling.RefreshData();

                    });
                }
            });





            //if (AppSettings.IsMqttConnected)
            //{
            //    _application.mqttHelper.PublishMQTT("REQUEST", "SamplingHeaderDokNo_ClientAToServer"+GlobalVar.MacAddress);
            //}

            //_application.mqttHelper.SubscribeMQTT("SamplingHeaderDokNo_ServerToClientA"+GlobalVar.MacAddress);
            //MessagingCenter.Subscribe<MqttHelper, List<string>>(this, MessagingCenterKeys.SamplingHeaderDokNo_ServerToClientA, (sender, args) =>
            //{
            //    if (args != null)
            //    {
            //        Device.BeginInvokeOnMainThread(() =>
            //        {
            //            if (Combobox_DokNo.SelectedIndex < 0)
            //            {
            //                Combobox_DokNo.ItemsSource = args;
            //            }

            //        });
            //    }
            //});

            _application.mqttHelper.SubscribeMQTT("SamplingBarcode_ServerToClientA"+GlobalVar.MacAddress);
            MessagingCenter.Subscribe<MqttHelper, SamplingBarcode>(this, MessagingCenterKeys.SamplingBarcode_ServerToClientA, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (args.Barcode != "FAIL")
                        {
                            textbox_BarcodeID.Text = args.Barcode;
                            textbox_ItemID.Text = args.ItemID;
                            textbox_ItemName.Text = args.ItemName;
                        }
                        else
                        {
                            DisplayAlert("Warning", "Label sudah pernah disampling QC Reguler", "OK");
                        }
                    });
                }
            });


            _application.mqttHelper.SubscribeMQTT("SamplingOperator_ServerToClientA"+GlobalVar.MacAddress);
            MessagingCenter.Subscribe<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingOperator_ServerToClientA, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (loopOperator == 0)
                        {
                            textbox_Operator1NPK.Text = args.NPK;
                            textbox_Operator1Name.Text = args.EmployeeName;
                            loopOperator++;
                        }
                        else if (loopOperator == 1)
                        {
                            textbox_Operator2NPK.Text = args.NPK;
                            textbox_Operator2Name.Text = args.EmployeeName;
                            loopOperator++;
                        }
                        else if (loopOperator == 2)
                        {
                            textbox_Operator3NPK.Text = args.NPK;
                            textbox_Operator3Name.Text = args.EmployeeName;
                            loopOperator++;
                        }
                        else if (loopOperator == 3)
                        {
                            textbox_Operator4NPK.Text = args.NPK;
                            textbox_Operator4Name.Text = args.EmployeeName;
                            loopOperator = 0;
                        }
                    });
                }
            });


            _application.mqttHelper.SubscribeMQTT("SamplingUserQC_ServerToClientA"+GlobalVar.MacAddress);
            MessagingCenter.Subscribe<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingUserQC_ServerToClientA, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (args.NPK == "WRONGDIVISION")
                        {
                            DisplayAlert("Warning", "Wrong Division", "OK");
                            return;
                        }
                        if (args.NPK == "WRONGDATA")
                        {
                            DisplayAlert("Warning", "Wrong Data NPK", "OK");
                            return;
                        }
                        foreach (var item in listDetailSamplingQC)
                        {
                            item.NPK = args.NPK;
                            item.EmployeeName = args.EmployeeName;
                        }
                        //string SamplingHeader = string.Format("*{0},{1}#", args.NPK, Combobox_DokNo.SelectedItem.ToString());
                        string SamplingHeader = string.Format("*{0},{1}#", args.NPK, "REGULER");
                        string strSampling = null;
                        string SamplingDetail = string.Format("~{0}@", strSampling);

                        foreach (var item in listDetailSamplingQC)
                        {
                            //string curSampling = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},", item.BARCODE, args.NPK, item.Judgement, item.Detail, Combobox_DokNo.SelectedItem.ToString(), item.Operator1, item.Operator2, item.Operator3, item.Operator4, item.Criteria);
                            string curSampling = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},", item.BARCODE, args.NPK, item.Judgement, item.Detail, "REGULER", item.Operator1, item.Operator2, item.Operator3, item.Operator4, item.Criteria);
                            strSampling = strSampling + curSampling;
                        }
                        SamplingDetail = string.Format("~{0}@{1}$", strSampling, GlobalVar.PlantID);
                        string PubMsg = string.Format("{2}{0}{1}", SamplingHeader, SamplingDetail, GlobalVar.MacAddress);///Format *SamplingHeader#~Sampling@
                        if (AppSettings.IsMqttConnected)
                        {
                            _application.mqttHelper.PublishMQTT(PubMsg, "SamplingSaveData_ClientAToServer");
                        }
                        else
                        {
                            DisplayAlert("Warning", "Your Connection has been Disconnected. Please Try Again.", "OK");
                            return;
                        }


                    });
                }
            });

            _application.mqttHelper.SubscribeMQTT("SamplingStatusSaveData_ServerToClientA"+GlobalVar.MacAddress);
            MessagingCenter.Subscribe<MqttHelper, string>(this, MessagingCenterKeys.SamplingStatusSaveData_ServerToClientA, (sender, args) =>
            {
                if (args != null)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (ShownConfirmationSave == false)
                        {
                            ShownConfirmationSave = true;
                            if (args == "SUCCESSSAVE")
                            {
                                ///Clear Textbox Combobox Etc after Sucessfully Save
                                ///
                                Combobox_NG_SFusion.Text = "";
                                textbox_BarcodeID.Text = "";
                                textbox_ItemID.Text = "";
                                textbox_ItemName.Text = "";
                                //textbox_Operator1NPK.Text = "";
                                //textbox_Operator1Name.Text = "";
                                //textbox_Operator2NPK.Text = "";
                                //textbox_Operator2Name.Text = "";
                                //textbox_Operator3NPK.Text = "";
                                //textbox_Operator3Name.Text = "";
                                //textbox_Operator4NPK.Text = "";
                                //textbox_Operator4Name.Text = "";
                                EntryDetail.Text = "";

                                DisplayAlert("Information", "Successfully Save Data Sampling", "OK");
                                return;
                            }
                            if (args == "FAILSAVE")
                            {
                                DisplayAlert("Warning", "Failed Save Data Sampling. Please Check your Connection and Try Again.", "OK");
                                return;
                            }
                        }

                    });
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MqttHelper, List<SamplingQC>>(this, MessagingCenterKeys.SamplingAdd_ServerToClientA);
            //MessagingCenter.Unsubscribe<MqttHelper, List<string>>(this, MessagingCenterKeys.SamplingHeaderDokNo_ServerToClientA);
            MessagingCenter.Unsubscribe<MqttHelper, SamplingBarcode>(this, MessagingCenterKeys.SamplingBarcode_ServerToClientA);
            MessagingCenter.Unsubscribe<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingOperator_ServerToClientA);
            MessagingCenter.Unsubscribe<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingUserQC_ServerToClientA);
            MessagingCenter.Unsubscribe<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingStatusSaveData_ServerToClientA);

        }

        async Task NavigateToScannerpage()
        {
            //setup Scanner options
            MobileBarcodeScanningOptions options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                UseFrontCameraIfAvailable = false,
                TryHarder = true,
                DelayBetweenContinuousScans = 10000,
                DisableAutofocus = false
            };

            var overlay = new ZXingDefaultOverlay
            {
                ShowFlashButton = true,
                TopText = "Hold your phone up to the barcode",
                BottomText = "Scanning will happen automatically"
            };

            overlay.BindingContext = overlay;
            ZXingScannerPage scanPage = new ZXingScannerPage(options, overlay)
            {
                HasTorch = true,
                IsTorchOn = false
            };

#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
            overlay.FlashButtonClicked += async (sender, e) => {
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
                scanPage.ToggleTorch();
            };

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;
                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();

                    if (result != null && !string.IsNullOrWhiteSpace(result.Text))
                    {
                        textbox_ScanResult.Text = result.Text;
                        Process(result.Text);
                        //_application.mqttHelper.PublishMQTT(result.Text, "BarcodeDEMOXacti");
                    }
                });
            };
            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);
        }

        async Task NavigateToScannerpageUserQC()
        {
            //setup Scanner options
            MobileBarcodeScanningOptions options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                UseFrontCameraIfAvailable = false,
                TryHarder = true,
                DelayBetweenContinuousScans = 10000
            };

            var overlay = new ZXingDefaultOverlay
            {
                ShowFlashButton = true,
                TopText = "Memerlukan NPK QC",
                BottomText = "Scanning will happen automatically",
            };
            overlay.BindingContext = overlay;
            ZXingScannerPage scanPage = new ZXingScannerPage(options, overlay)
            {
                HasTorch = true,
                IsTorchOn = false
            };

#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
            overlay.FlashButtonClicked += async (sender, e) => {
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
                scanPage.ToggleTorch();
            };

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;
                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();

                    if (result != null && !string.IsNullOrWhiteSpace(result.Text))
                    {
                        textbox_ScanResult.Text = result.Text;
                        _application.mqttHelper.PublishMQTT(result.Text, "SamplingUserQC_ClientAToServer" + GlobalVar.MacAddress);

                    }

                });
            };
            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);
        }

        private async void Process(string result)
        {

            if (AppSettings.IsMqttConnected && !string.IsNullOrEmpty(textbox_ScanResult.Text))
            {

                if (result.Length > 11 && result.Length <= 50)
                {
                    _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2}",GlobalVar.PlantID,textbox_ScanResult.Text, GlobalVar.MacAddress), "SamplingBarcode_ClientAToServer");  //Send Data Format MQTT : Barcode
                }
                else if (result.Length > 50)
                {
                    if (result.Contains("Z1") && result.Contains("Z2") && result.Contains("Z3") && result.Contains("Z4") && result.Contains("Z5") && result.Contains("Z6") && result.Contains("Z7"))
                    {
                        int index1 = result.IndexOf("Z5");
                        int index2 = result.IndexOf("|", index1);
                        string customerbarcode = result.Substring(index1 + 2, index2 - index1 - 2);
                        _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2}", GlobalVar.PlantID, customerbarcode, GlobalVar.MacAddress), "SamplingBarcode_ClientAToServer");  //Send Data Format MQTT : Barcode
                    }
                    else
                    {
                        await DisplayAlert("Warning", "Wrong Data Barcode. Please Scan Correct Barcode.", "OK");
                    }

                }
                else if (result.Length > 5 && result.Length <= 8)
                {
                    _application.mqttHelper.PublishMQTT(string.Format("{0},{1},{2}", GlobalVar.PlantID, textbox_ScanResult.Text, GlobalVar.MacAddress), "SamplingOperator_ClientAToServer"); // Send Data Format MQTT : Operator NPK
                }
                else
                {
                    await DisplayAlert("Warning", "Wrong Data Barcode. Please Scan Correct Barcode.", "OK");
                }
            }
        }

        private async void Button_ScanBarcodeSampling_Clicked(object sender, EventArgs e)
        {
            if (AppSettings.IsMqttConnected)
            {
                await NavigateToScannerpage();
            }
        }

        private void SwitchNG_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                Combobox_NG_SFusion.IsVisible = false;
                textbox_NG.Text = "Good";
                textbox_NG.TextColor = Color.Green;
                textbox_NG.FontAttributes = FontAttributes.Bold;
            }
            else
            {
                Combobox_NG_SFusion.IsVisible = true;
                textbox_NG.Text = "NG";
                textbox_NG.TextColor = Color.Red;
                textbox_NG.FontAttributes = FontAttributes.Bold;
            }
        }

        private async void ToolbarSave_Clicked(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////
            ///
            #region ToolBarAdd_Clicked
            //Validasi
            if (string.IsNullOrEmpty(textbox_BarcodeID.Text) || string.IsNullOrEmpty(textbox_ItemID.Text) || string.IsNullOrEmpty(textbox_ItemName.Text))
            {
                await DisplayAlert("Warning", "Barcode/Item Id/Item Name Empty", "OK");
                return;
            }

            string strJudge = null;
            string strCriteria = null;
            if (!SwitchNG.IsToggled && Combobox_NG_SFusion.SelectedIndex < 0)
            {
                await DisplayAlert("Warning", "Criteria NG Empty", "OK");
                return;
            }

            if (SwitchNG.IsToggled)
            {
                strJudge = "OK";
                strCriteria = "";
            }
            else
            {
                strJudge = "NG";
                List<string> listselectedNG = Combobox_NG_SFusion.SelectedValue as List<string>;
                foreach (var str in listselectedNG)
                {
                    strCriteria += str + "-";
                }
            }

            SamplingQC samplingQc = new SamplingQC();
            samplingQc.BARCODE = textbox_BarcodeID.Text;
            samplingQc.ITEM_ID = textbox_ItemID.Text;
            samplingQc.ITEM_NAME = textbox_ItemName.Text;
            samplingQc.NPK = "";
            samplingQc.EmployeeName = "";
            samplingQc.ScanDate = DateTime.Now;
            samplingQc.Detail = EntryDetail.Text;
            samplingQc.Judgement = strJudge;
            samplingQc.Operator1 = textbox_Operator1NPK.Text;
            samplingQc.Operator2 = textbox_Operator2NPK.Text;
            samplingQc.Operator3 = textbox_Operator3NPK.Text;
            samplingQc.Operator4 = textbox_Operator4NPK.Text;
            samplingQc.Criteria = strCriteria;

            listDetailSamplingQC = new List<SamplingQC>();
            listDetailSamplingQC.Add(samplingQc);

            Combobox_NG_SFusion.Text = "";
            #endregion
            ///\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\





            if (listDetailSamplingQC.Count <= 0)
            {
                await DisplayAlert("Warning", "Data Sampling Empty", "OK");
                return;
            }

            //if(Combobox_DokNo.SelectedIndex < 0)
            //{
            //    await DisplayAlert("Warning", "Dokumen No Empty", "OK");
            //    return;
            //}
            if (AppSettings.IsMqttConnected)
            {
                //await NavigateToScannerpageUserQC();


                //////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                ShownConfirmationSave = false;


                foreach (var item in listDetailSamplingQC)
                {
                    item.NPK = GlobalVar.EmployeeID;
                    item.EmployeeName = GlobalVar.EmployeeName;
                }
                //string SamplingHeader = string.Format("*{0},{1}#", args.NPK, Combobox_DokNo.SelectedItem.ToString());
                string SamplingHeader = string.Format("*{0},{1}#", GlobalVar.EmployeeID, "REGULER");
                string strSampling = null;
                string SamplingDetail = string.Format("~{0}@", strSampling);

                foreach (var item in listDetailSamplingQC)
                {
                    //string curSampling = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},", item.BARCODE, args.NPK, item.Judgement, item.Detail, Combobox_DokNo.SelectedItem.ToString(), item.Operator1, item.Operator2, item.Operator3, item.Operator4, item.Criteria);
                    string curSampling = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},", item.BARCODE, GlobalVar.EmployeeID, item.Judgement, item.Detail, "REGULER", item.Operator1, item.Operator2, item.Operator3, item.Operator4, item.Criteria);
                    strSampling = strSampling + curSampling;
                }
                SamplingDetail = string.Format("~{0}@{1}$", strSampling, GlobalVar.PlantID);
                string PubMsg = string.Format("{2}{0}{1}", SamplingHeader, SamplingDetail,GlobalVar.MacAddress);///Format *SamplingHeader#~Sampling@
                if (AppSettings.IsMqttConnected)
                {
                    _application.mqttHelper.PublishMQTT(PubMsg, "SamplingSaveData_ClientAToServer");
                }
                else
                {
                    await DisplayAlert("Warning", "Your Connection has been Disconnected. Please Try Again.", "OK");
                    return;
                }

                ///\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            }
        }

        private void ToolbarAdd_Clicked(object sender, EventArgs e)
        {
            //Validasi
            if (string.IsNullOrEmpty(textbox_BarcodeID.Text) || string.IsNullOrEmpty(textbox_ItemID.Text) || string.IsNullOrEmpty(textbox_ItemName.Text))
            {
                DisplayAlert("Warning", "Barcode/Item Id/Item Name Empty", "OK");
                return;
            }

            string strJudge = null;
            string strCriteria = null;
            if (!SwitchNG.IsToggled && Combobox_NG_SFusion.SelectedIndex < 0)
            {
                DisplayAlert("Warning", "Criteria NG Empty", "OK");
                return;
            }

            if (SwitchNG.IsToggled)
            {
                strJudge = "OK";
                strCriteria = "";
            }
            else
            {
                strJudge = "NG";
                List<string> listselectedNG = Combobox_NG_SFusion.SelectedValue as List<string>;
                foreach (var str in listselectedNG)
                {
                    strCriteria += str + ",";
                }
            }

            SamplingQC samplingQc = new SamplingQC();
            samplingQc.BARCODE = textbox_BarcodeID.Text;
            samplingQc.ITEM_ID = textbox_ItemID.Text;
            samplingQc.ITEM_NAME = textbox_ItemName.Text;
            samplingQc.NPK = "";
            samplingQc.EmployeeName = "";
            samplingQc.ScanDate = DateTime.Now;
            samplingQc.Detail = EntryDetail.Text;
            samplingQc.Judgement = strJudge;
            samplingQc.Operator1 = textbox_Operator1NPK.Text;
            samplingQc.Operator2 = textbox_Operator2NPK.Text;
            samplingQc.Operator3 = textbox_Operator3NPK.Text;
            samplingQc.Operator4 = textbox_Operator4NPK.Text;
            samplingQc.Criteria = strCriteria;


            listDetailSamplingQC.Add(samplingQc);

            Combobox_NG_SFusion.Text = "";
            //GridControlItemSampling.ItemsSource = listDetailSamplingQC;
            //GridControlItemSampling.RefreshData();
        }

        private async void ToolbarView_Clicked(object sender, EventArgs e)
        {
            await _application.MainPage.Navigation.PushAsync(new QCSamplingDetailView(listDetailSamplingQC), true);
        }
    }
}