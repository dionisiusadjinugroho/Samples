using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Syncfusion.XForms.PopupLayout;
using System.ComponentModel;

namespace YasunliplastApp.Utils
{
    public class GlobalVar
    {
        public static string Username = null;
        public static string Password = null;

        public static string MacAddress = null;
        public static string EmployeeID = null;
        public static string EmployeeName = null;

        public static string OperatorName = null;
        public static string OperatorNPK = null;
        public static string MachineID = null;
        public static string MachineName = null;

        public static string PlantID = null;
        public static string Division = null;

        public static string BarcodeID = null;

        public static string aktivitas = null;

        public static List<SurKom> _SurkomList = new List<SurKom>();
        public static List<Scheduling> _listScheduling = new List<Scheduling>();
        public static List<ReportAbsensi> _listreportAbsensi = new List<ReportAbsensi>();
        public static List<MonitoringStock> _listmonitoringStock = new List<MonitoringStock>();
        public static List<ListHistoryBox> _listHistoryBox = new List<ListHistoryBox>();
        public static List<ListSPPAktivitas> _listSPPAktivitas = new List<ListSPPAktivitas>();
        public static List<DEMODataBarcode> _listDEMODataZebra = new List<DEMODataBarcode>();
        public static List<ReworkIN> _listreworkINs = new List<ReworkIN>();
        public static List<ReworkLocation> _listReworkLocations = new List<ReworkLocation>();
        public static List<QRCodeDeliveryEPSON> _listQRCodeDeliveryEPSON = new List<QRCodeDeliveryEPSON>();
        public static List<CheckerDeliveryEPSONGudang> _listCheckerDeliveryEPSONGudang = new List<CheckerDeliveryEPSONGudang>();
        public static List<RFIDPairing> _listRFIDPairing = new List<RFIDPairing>();
        public static int urutanPhotoAbsensi = 0;
        public static int urutanPhotoScheduling = 0;

        public static void SetSfPopupText(string HeaderText, string BodyText, AppearanceMode appearanceMode = AppearanceMode.OneButton, string AcceptText = "ACCEPT", string DeclineText = "DECLINE")
        {
            Label popupContent;
            DataTemplate dataTemplate = new DataTemplate(() =>
            {
                popupContent = new Label();
                popupContent.Text = BodyText;
                popupContent.FontFamily = "Poppins";
                popupContent.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
                popupContent.FontAttributes = FontAttributes.Bold;
                popupContent.BackgroundColor = Color.White;
                return popupContent;
            });
            SfPopupLayout sfPopup = new SfPopupLayout();
            sfPopup.PopupView.AppearanceMode = appearanceMode;
            sfPopup.PopupView.AcceptButtonText = "ACCEPT";
            sfPopup.PopupView.DeclineButtonText = "DECLINE";
            sfPopup.PopupView.HeaderTitle = HeaderText;
            sfPopup.PopupView.ContentTemplate = dataTemplate;
            sfPopup.PopupView.AnimationMode = AnimationMode.SlideOnTop;
            sfPopup.Show();
        }


    }
}
