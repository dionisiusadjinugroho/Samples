using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPaintingYasunli
{
    public class MonitoringPainting
    {
        public Int64 ID { get; set; }
        public string BarcodeID { get; set; }
        public DateTime ScanTime { get; set; }
        public string TypeDetail { get; set; }
        public string Type { get; set; }
        public int ScanCount { get; set; }
        public string ItemName { get; set; }
        public string Colour { get; set; }
    }
    public class MonitoringPaintingDetail
    {
        public int RawPart { get; set; }
        public int TotalRepaint { get; set; }
        public int TotalNG { get; set; }
        public int TotalOK { get; set; }
        public int R0 { get; set; }
        public int R1 { get; set; }
        public int R2 { get; set; }
        public int R3 { get; set; }
        public int R4 { get; set; }
        public int R5 { get; set; }
        public int NG0 { get; set; }
        public int NG1 { get; set; }
        public int NG2 { get; set; }
        public int NG3 { get; set; }
        public int NG4 { get; set; }
        public int NG5 { get; set; }
        public int OK0 { get; set; }
        public int OK1 { get; set; }
        public int OK2 { get; set; }
        public int OK3 { get; set; }
        public int OK4 { get; set; }
        public int OK5 { get; set; }
        public string ItemName { get; set; }
        public string Colour { get; set; }
    }

    public static class MonitoringPaintingSource
    {
        public static List<MonitoringPainting> _listMonitoringPainting = new List<MonitoringPainting>();
        public static List<MonitoringPaintingDetail> _listMonitoringPaintingDetail = new List<MonitoringPaintingDetail>();

        public static IList<MonitoringPainting> GetMonitoringPaintings()
        {
            return _listMonitoringPainting;
        }
        public static IList<MonitoringPaintingDetail> GetMonitoringPaintingDetails()
        {
            //MonitoringPaintingDetail mpd = new MonitoringPaintingDetail();
            //mpd.ItemID = "TEST";
            //mpd.ItemName = "TESTNAME";
            //mpd.MainModel = "TESTMODEL";
            //mpd.RawPart = 100;
            //mpd.TotalNG = 10;
            //mpd.TotalOK = 70;
            //mpd.TotalRepaint = 20;
            //mpd.R0 = 10;
            //mpd.R1 = 10;
            //mpd.R2 = 10;
            //mpd.R3 = 10;
            //mpd.R4 = 10;
            //mpd.NG0 = 10;
            //mpd.NG1 = 10;
            //mpd.NG2 = 10;
            //mpd.NG3 = 10;
            //mpd.NG4 = 10;
            //mpd.OK0 = 10;
            //mpd.OK1 = 10;
            //mpd.OK2 = 10;
            //mpd.OK3 = 10;
            //mpd.OK4 = 10;

            //_listMonitoringPaintingDetail.Add(mpd);
            return _listMonitoringPaintingDetail;
        }
    }

    internal class DistinctColour : IEqualityComparer<MonitoringPainting>
    {
        public bool Equals(MonitoringPainting x, MonitoringPainting y)
        {
            // Two items are equal if their keys are equal.
            return x.Colour == y.Colour;
        }

        public int GetHashCode(MonitoringPainting obj)
        {
            return obj.Colour.GetHashCode();
        }
    }
    internal class DistinctItemName : IEqualityComparer<MonitoringPainting>
    {
        public bool Equals(MonitoringPainting x, MonitoringPainting y)
        {
            // Two items are equal if their keys are equal.
            return x.ItemName == y.ItemName;
        }

        public int GetHashCode(MonitoringPainting obj)
        {
            return obj.ItemName.GetHashCode();
        }
    }

}
