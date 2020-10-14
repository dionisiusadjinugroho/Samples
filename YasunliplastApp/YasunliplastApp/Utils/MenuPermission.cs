using System;
using System.Collections.Generic;
using System.Text;
using YasunliplastApp.Views;

namespace YasunliplastApp.Utils
{
    public class MenuPermission
    {
        public static void Permission(HomeView home)
        {
            ///MENU DIVISI QC
            if (GlobalVar.Division.ToUpper().Contains("QC") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonSampling.IsVisible = true;
                home.buttonReportSampling.IsVisible = true;
                home.buttonStockMonitoring.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("PRODUKSI") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }

            ///MENU DIVISI LEADER PRODUKSI
            if (GlobalVar.Division.ToUpper().Contains("LEADER") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonAbsensiOP.IsVisible = true;
                home.buttonReportAbsensiOP.IsVisible = true;
                home.buttonStockMonitoring.IsVisible = true;
                home.buttonHistoryBox.IsVisible = true;
                home.buttonCounterInjection.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("TECHNISI") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
                home.buttonSPPActivity.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("GUDANG") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
                home.buttonCheckerItemDelivery_RFID.IsVisible = true;
                home.buttonRFIDPairing.IsVisible = true;
                home.buttonSTOGudang.IsVisible = true;

            }

            if (GlobalVar.Division.ToUpper().Contains("EXIM") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("ENGINEERING") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("ASSEMBLING") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("FINISHING") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
                home.buttonCounterReworkIN.IsVisible = true;
                home.buttonAddLocRework.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("DELIVERY") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
                home.buttonQRCodeDeliveryEPSON_RFID.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("PRINTING") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("PPIC") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("PACKING") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("PLANT MANAGER") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonReportAbsensiOP.IsVisible = true;
                home.buttonReportSampling.IsVisible = true;
                home.buttonStockMonitoring.IsVisible = true;
                home.buttonScheduling.IsVisible = true;
                home.buttonSurkom.IsVisible = true;
                home.buttonHistoryBox.IsVisible = true;
                home.buttonSPPActivity.IsVisible = true;
                home.buttonDEMO_Zebra.IsVisible = true;
                home.buttonDEMO_ZebraRFID.IsVisible = true;
                home.buttonCounterInjection.IsVisible = true;
                home.buttonCounterReworkIN.IsVisible = true;
                home.buttonAddLocRework.IsVisible = true;
                home.buttonQRCodeDeliveryEPSON_RFID.IsVisible = true;
                home.buttonCheckerItemDelivery_RFID.IsVisible = true;
                home.buttonRFIDPairing.IsVisible = true;
                home.buttonSTOGudang.IsVisible = true;
            }

            if (GlobalVar.Division.ToUpper().Contains("PROSES MATERIAL") || GlobalVar.Division.ToUpper() == "IT")
            {
                home.buttonStockMonitoring.IsVisible = true;
            }



        }
    }
}
