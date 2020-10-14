using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels.Base;
using YasunliplastApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace YasunliplastApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        App _application;

        public ICommand OnViewSelection { get; set; }

        public HomeViewModel()
        {
            _application = Application.Current as App;
            OnViewSelection = new Command<string>(async (viewType) => await NavigateOnViewSelection(viewType));
        }

        async Task NavigateOnViewSelection(string viewType)
        {
            if (viewType == "qcsampling")
            {
                //if (VariableGlobal.LoginUSER == true)
                if (GlobalVar.Division.ToUpper().Contains("QC") || GlobalVar.Division.ToUpper() == "IT")
                {
                    await _application.MainPage.Navigation.PushAsync(new QCSamplingView(), true);
                }
                else
                {
                    MessagingCenter.Send<MqttHelper, bool>(_application.mqttHelper, MessagingCenterKeys.PopUpNotAuthorized, true);
                }
            }

            if (viewType == "reportqcsampling")
                await _application.MainPage.Navigation.PushAsync(new ReportSamplingView(), true);

            if (viewType == "absensi_op")
            {
                //if (VariableGlobal.LoginUSER == true)
                if (GlobalVar.Division.ToUpper().Contains("LEADER") || GlobalVar.Division.ToUpper() == "IT")
                {
                    await _application.MainPage.Navigation.PushAsync(new AbsensiOpView(), true);
                }
                else
                {
                    MessagingCenter.Send<MqttHelper, bool>(_application.mqttHelper, MessagingCenterKeys.PopUpNotAuthorized, true);
                }
            }

            if (viewType == "reportabsensi")
                await _application.MainPage.Navigation.PushAsync(new ReportAbsensiView(), true);

            if (viewType == "laporanmonitoringbarang")
                await _application.MainPage.Navigation.PushAsync(new MonitoringStockView(), true);

            if (viewType == "scheduling")
                await _application.MainPage.Navigation.PushAsync(new SchedulingView(), true);

            if (viewType == "historyboxes")
            {
                await NavigateToScannerpage();
            }

            if (viewType == "surkom")
                await _application.MainPage.Navigation.PushAsync(new SuratKonfirmasi(), true);

            if (viewType == "sppaktivitas")
                await _application.MainPage.Navigation.PushAsync(new SPPAktivitasView(), true);

            if (viewType == "DEMOScannerZebra")
                await _application.MainPage.Navigation.PushAsync(new DEMOScannerZebraRFIDView(), true);

            if (viewType == "DEMOScannerZebraRFID")
                await _application.MainPage.Navigation.PushAsync(new DEMOScannerZebraRFIDView(), true);

            if (viewType == "TRIALCounterInjection")
                await _application.MainPage.Navigation.PushAsync(new TRIALCounterInjectionView(), true);

            if (viewType == "TRIALCounterReworkIN")
                await _application.MainPage.Navigation.PushAsync(new TRIALCounterReworkINView(), true);

            if (viewType == "ADD_LOC_REWORK")
                await _application.MainPage.Navigation.PushAsync(new ReworkLocationView(), true);

            if (viewType == "QRCODE_DELIVERY_EPSON_RFID")
                await _application.MainPage.Navigation.PushAsync(new DEMOScannerZebraRFID_DeliveryEPSONView(), true);

            if (viewType == "CHECKER_ITEM_DELIVERY_EPSON_IN_GUDANG")
                await _application.MainPage.Navigation.PushAsync(new DEMOScannerZebraRFID_CheckerItemDeliveryView(), true);

            if (viewType == "RFID_PAIRING_LOCATION")
                await _application.MainPage.Navigation.PushAsync(new RFIDPairingView(), true);

             if (viewType == "STO_GUDANG_READY")
                await _application.MainPage.Navigation.PushAsync(new STOGudangReadyView(), true);

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
                TopText = "Scan Barcode",
                BottomText = "Scanning will happen automatically",
            };
            overlay.BindingContext = overlay;
            ZXingScannerPage scanPage = new ZXingScannerPage(options, overlay)
            {
                HasTorch = true,
                IsTorchOn = false
            };

            overlay.FlashButtonClicked += async (sender, e) =>
            {
                scanPage.ToggleTorch();
            };

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;
                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await _application.MainPage.Navigation.PopAsync();

                    if (result != null && !string.IsNullOrWhiteSpace(result.Text))
                    {
                        Process(result.Text);
                        GlobalVar._listHistoryBox = new List<ListHistoryBox>();
                        await _application.MainPage.Navigation.PushAsync(new HistoryBox(), true);
                    }
                });

            };
            await _application.MainPage.Navigation.PushAsync(scanPage);
        }
        private void Process(string result)
        {
            GlobalVar.BarcodeID = result;
            if (AppSettings.IsMqttConnected)
            {
                _application.mqttHelper.PublishMQTT(string.Format("{0},{1}", GlobalVar.BarcodeID, GlobalVar.PlantID), "DAFTAR_RIWAYAT_BOX" + GlobalVar.MacAddress);
            }
        }
    }
}
