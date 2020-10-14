using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class MonitoringStock : INotifyPropertyChanged
    {
        #region Fields

        private string itemcode;
        private string itemname;
        private string qty;
        private string packageid;
        private string location;
        private string mainmodel;
        private string status;
        private string customername;
        private string judge;
        private string boxtype;
        private Color color;

        #endregion

        #region Constructor
        public MonitoringStock()
        {

        }
        #endregion

        #region Public Properties

        public string ItemCode
        {
            get { return this.itemcode; }
            set
            {
                this.itemcode = value;
                RaisePropertyChanged("ItemCode");
            }
        }
        public string ItemName
        {
            get { return this.itemname; }
            set
            {
                this.itemname = value;
                RaisePropertyChanged("ItemName");
            }
        }
        public string QTY
        {
            get { return this.qty; }
            set
            {
                this.qty = value;
                RaisePropertyChanged("QTY");
            }
        }
        public string PackageID
        {
            get { return this.packageid; }
            set
            {
                this.packageid = value;
                RaisePropertyChanged("PackageID");
            }
        }
        public string Location
        {
            get { return this.location; }
            set
            {
                this.location = value;
                RaisePropertyChanged("Location");
            }
        }
        public string MainModel
        {
            get { return this.mainmodel; }
            set
            {
                this.mainmodel = value;
                RaisePropertyChanged("MainModel");
            }
        }
        public string Status
        {
            get { return this.status; }
            set
            {
                this.status = value;
                RaisePropertyChanged("Status");
            }
        }
        public string CustomerName
        {
            get { return this.customername; }
            set
            {
                this.customername = value;
                RaisePropertyChanged("CustomerName");
            }
        }
        public string Judge
        {
            get { return this.judge; }
            set
            {
                this.judge = value;
                RaisePropertyChanged("Judge");
            }
        }
        public string BoxType
        {
            get { return this.boxtype; }
            set
            {
                this.boxtype = value;
                RaisePropertyChanged("BoxType");
            }
        }
        public Color Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
                RaisePropertyChanged("Color");
            }
        }
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
