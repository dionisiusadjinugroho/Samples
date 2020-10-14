using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;

namespace YasunliplastApp.ViewModels
{
    public class MonitoringStockViewModel : ViewModelBase
    {
        App _application;

        public MonitoringStockViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            monitoringstocks = new List<MonitoringStock>();
            /////DUMMY DATA - TESTING BINDING
            //Random random = new Random();
            //for (int i=0;i<100;i++)
            //{
            //    ReportSampling RS = new ReportSampling();
            //    RS.BarcodeID = "SPP00000" + Convert.ToString(random.Next(0, 100000));
            //    RS.EmployeeName = "Employee" + Convert.ToString(random.Next(0, 100000));
            //    RS.ItemID = "ItemID" + Convert.ToString(random.Next(0, 100000));
            //    RS.ItemName = "Employee" + Convert.ToString(random.Next(0, 100000));
            //    RS.SamplingTime = "Datetime" + Convert.ToString(random.Next(0, 100000));
            //    reportsamplings.Add(RS);
            //}

        }

        public double ResWidth = 0;

        public List<MonitoringStock> monitoringstocks
        {
            get;
            set;
        }


    }
}
