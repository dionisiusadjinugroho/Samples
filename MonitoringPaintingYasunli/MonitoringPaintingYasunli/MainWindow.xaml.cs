using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Timers;
using System.Windows;
using YasunliESModel.Models;

namespace MonitoringPaintingYasunli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer_status = new Timer();
        private int count = 0;
        private int second = 0;
        private string conString = @"Data Source=######;Initial Catalog=#########;Persist Security Info=True;User ID=######;Password=#########;MultipleActiveResultSets=True";
        public static MainWindow _Form1;

        public MainWindow()
        {
            InitializeComponent();
            _Form1 = this;

            var context = new YasunliESContext(conString);
            string now = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            string query = string.Format(@"SELECT MIN(x.id) as ID,  -- change to MAX if you want the highest
                     x.BarcodeID,
                     x.ScanTime,
            		 x.Type as TypeDetail,
            		 pt.Type,
            		 pt.ScanCount,
            		 i.ItemID,
            		 i.ItemName,
            		 i.Colour
                FROM Inventory.PaintingTransactionDetail x
                JOIN (SELECT p.BarcodeID,
                             MAX(ScanTime) AS max_ScanTime
                        FROM Inventory.PaintingTransactionDetail p
                    GROUP BY p.BarcodeID) y ON y.BarcodeID = x.BarcodeID
                                          AND y.max_ScanTime = x.ScanTime
            	JOIN Inventory.PaintingTransaction as pt on pt.BarcodeID = x.BarcodeID
            	JOIN Inventory.DetailLabelPainting as dlp on dlp.BarcodeID = x.BarcodeID
            	JOIN Inventory.DetailLabel as dl on dl.BarcodeID = dlp.BarcodeIDRefference
            	JOIN Inventory.Label as l on l.LabelID = dl.LabelID
            	JOIN Inventory.Item as i on i.ItemID = l.ItemID
                where x.ScanTime >= '{0}'
            GROUP BY x.BarcodeID, x.ScanTime,x.Type,pt.Type,pt.ScanCount,i.ItemID,i.ItemName,i.Colour
            ", now);
            //            string query = string.Format(@"SELECT MIN(x.id) as ID,  -- change to MAX if you want the highest
            //         x.BarcodeID,
            //         x.ScanTime,
            //		 x.Type as TypeDetail,
            //		 pt.Type,
            //		 pt.ScanCount,
            //		 i.ItemID,
            //		 i.ItemName,
            //		 i.MainModel
            //    FROM Inventory.PaintingTransactionDetail x
            //    JOIN (SELECT p.BarcodeID,
            //                 MAX(ScanTime) AS max_ScanTime
            //            FROM Inventory.PaintingTransactionDetail p
            //        GROUP BY p.BarcodeID) y ON y.BarcodeID = x.BarcodeID
            //                              AND y.max_ScanTime = x.ScanTime
            //	JOIN Inventory.PaintingTransaction as pt on pt.BarcodeID = x.BarcodeID
            //	JOIN Inventory.DetailLabelPainting as dlp on dlp.BarcodeID = x.BarcodeID
            //	JOIN Inventory.DetailLabel as dl on dl.BarcodeID = dlp.BarcodeIDRefference
            //	JOIN Inventory.Label as l on l.LabelID = dl.LabelID
            //	JOIN Inventory.Item as i on i.ItemID = l.ItemID
            //GROUP BY x.BarcodeID, x.ScanTime,x.Type,pt.Type,pt.ScanCount,i.ItemID,i.ItemName,i.MainModel
            //", now);
            List<MonitoringPainting> getlistRawMP = new List<MonitoringPainting>();
            try
            {
                getlistRawMP = context.Database.SqlQuery<MonitoringPainting>(query).ToList();
            }
            catch (Exception)
            {

            }

            MonitoringPaintingSource._listMonitoringPainting = new List<MonitoringPainting>();
            MonitoringPaintingSource._listMonitoringPainting = getlistRawMP;

            var getlistNoDuplicateColour = getlistRawMP.Distinct(new DistinctColour()).ToList();
            var getlistNoDuplicateItemName = getlistRawMP.Distinct(new DistinctItemName()).ToList();

            List<MonitoringPaintingDetail> _listNODUPE = new List<MonitoringPaintingDetail>();
            foreach (var colour in getlistNoDuplicateColour)
            {
                foreach (var itemname in getlistNoDuplicateItemName)
                {
                    foreach (var itemraw in getlistRawMP)
                    {
                        if (itemraw.Colour == colour.Colour && itemraw.ItemName == itemname.ItemName)
                        {
                            var checkexistinNoDUPE = _listNODUPE.Where(x => x.Colour == itemraw.Colour && x.ItemName == itemraw.ItemName).FirstOrDefault();
                            if (checkexistinNoDUPE == null)
                            {
                                var a = new MonitoringPaintingDetail();
                                a.ItemName = itemraw.ItemName;
                                a.Colour = itemraw.Colour;
                                _listNODUPE.Add(a);
                            }

                        }

                    }
                }
            }
            //MonitoringPaintingSource._listMonitoringPaintingDetail = new List<MonitoringPaintingDetail>();
            foreach (var item in _listNODUPE)
            {
                MonitoringPaintingDetail mpdet = new MonitoringPaintingDetail();
                mpdet.ItemName = item.ItemName;
                mpdet.Colour = item.Colour;
                foreach (var itemraw in getlistRawMP)
                {
                    if (itemraw.Colour == item.Colour && itemraw.ItemName == item.ItemName)
                    {
                        mpdet.RawPart++;
                        switch (itemraw.Type)
                        {
                            case "REPAINT":
                                switch (itemraw.ScanCount)
                                {
                                    case 0:
                                        mpdet.R0++;
                                        mpdet.TotalRepaint++;
                                        break;

                                    case 1:
                                        mpdet.R1++;
                                        mpdet.TotalRepaint++;
                                        break;

                                    case 2:
                                        mpdet.R2++;
                                        mpdet.TotalRepaint++;
                                        break;

                                    case 3:
                                        mpdet.R3++;
                                        mpdet.TotalRepaint++;
                                        break;

                                    case 4:
                                        mpdet.R4++;
                                        mpdet.TotalRepaint++;
                                        break;
                                    case 5:
                                        mpdet.R5++;
                                        mpdet.TotalRepaint++;
                                        break;
                                }
                                break;

                            case "OKPAINTING":
                                switch (itemraw.ScanCount)
                                {
                                    case 0:
                                        mpdet.OK0++;
                                        mpdet.TotalOK++;
                                        break;

                                    case 1:
                                        mpdet.OK1++;
                                        mpdet.TotalOK++;
                                        break;

                                    case 2:
                                        mpdet.OK2++;
                                        mpdet.TotalOK++;
                                        break;

                                    case 3:
                                        mpdet.OK3++;
                                        mpdet.TotalOK++;
                                        break;

                                    case 4:
                                        mpdet.OK4++;
                                        mpdet.TotalOK++;
                                        break;
                                    case 5:
                                        mpdet.OK5++;
                                        mpdet.TotalOK++;
                                        break;
                                }

                                break;

                            case "NG":
                                switch (itemraw.ScanCount)
                                {
                                    case 0:
                                        mpdet.NG0++;
                                        mpdet.TotalNG++;
                                        break;

                                    case 1:
                                        mpdet.NG1++;
                                        mpdet.TotalNG++;
                                        break;

                                    case 2:
                                        mpdet.NG2++;
                                        mpdet.TotalNG++;
                                        break;

                                    case 3:
                                        mpdet.NG3++;
                                        mpdet.TotalNG++;
                                        break;

                                    case 4:
                                        mpdet.NG4++;
                                        mpdet.TotalNG++;
                                        break;
                                    case 5:
                                        mpdet.NG5++;
                                        mpdet.TotalNG++;
                                        break;
                                }
                                break;

                            case "RAWPART":
                                mpdet.R0++;
                                mpdet.TotalRepaint++;
                                break;

                        }
                    }
                    else
                    {

                    }
                }
                MonitoringPaintingSource._listMonitoringPaintingDetail.Add(mpdet);
            }


            second = Convert.ToInt32(ConfigurationManager.ConnectionStrings["Second"].ConnectionString);

            timer_status.Elapsed += new ElapsedEventHandler(OnElapsedTime_Count);
            timer_status.Interval = 1000; //number in milliseconds
            timer_status.Enabled = true;

            MqttClass.MQTT_Connect();
        }

        private void OnElapsedTime_Count(object sender, ElapsedEventArgs e)
        {
            count++;
            if (count >= second)
            {
                timer_status.Enabled = false;
                Check();
            }
        }

        private void Check()
        {

            //Dispatcher.Invoke(() =>
            //{
            //    dashboardcontrol1.ReloadData();
            //});
            //timer_status.Enabled = true;
            //count = 0;
        }
    }
}