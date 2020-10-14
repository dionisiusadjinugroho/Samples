using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YasunliplastApp.Utils
{
    public class CounterInjection : INotifyPropertyChanged
    {
        #region Fields

        private string barcodeid;
        //private string boxtype;
        //private string cavityno;
        //private string itemid;
        //private string itemname;
        //private string model;
        //private string sppno;
        //private string scantime;
        //private string qty;
        //private string machinename;


        #endregion

        #region Constructor
        public CounterInjection()
        {

        }
        #endregion

        #region Public Properties

        public string BarcodeID
        {
            get { return this.barcodeid; }
            set
            {
                this.barcodeid = value;
                RaisePropertyChanged("BarcodeID");
            }
        }
        //public string BoxType
        //{
        //    get { return this.boxtype; }
        //    set
        //    {
        //        this.boxtype = value;
        //        RaisePropertyChanged("BoxType");
        //    }
        //}
        //public string CavityNo
        //{
        //    get { return this.cavityno; }
        //    set
        //    {
        //        this.cavityno = value;
        //        RaisePropertyChanged("CavityNo");
        //    }
        //}
        //public string ItemID
        //{
        //    get { return this.itemid; }
        //    set
        //    {
        //        this.itemid = value;
        //        RaisePropertyChanged("ItemID");
        //    }
        //}
        //public string ItemName
        //{
        //    get { return this.itemname; }
        //    set
        //    {
        //        this.itemname = value;
        //        RaisePropertyChanged("ItemName");
        //    }
        //}
        //public string Model
        //{
        //    get { return this.model; }
        //    set
        //    {
        //        this.model = value;
        //        RaisePropertyChanged("Model");
        //    }
        //}
        //public string SPPNo
        //{
        //    get { return this.sppno; }
        //    set
        //    {
        //        this.sppno = value;
        //        RaisePropertyChanged("SPPNo");
        //    }
        //}
        //public string ScanTime
        //{
        //    get { return this.scantime; }
        //    set
        //    {
        //        this.scantime = value;
        //        RaisePropertyChanged("ScanTime");
        //    }
        //}

        //public string Qty
        //{
        //    get { return this.qty; }
        //    set
        //    {
        //        this.qty = value;
        //        RaisePropertyChanged("Qty");
        //    }
        //}

        //public string MachineName
        //{
        //    get { return this.machinename; }
        //    set
        //    {
        //        this.machinename = value;
        //        RaisePropertyChanged("MachineName");
        //    }
        //}
        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion

    }
}
