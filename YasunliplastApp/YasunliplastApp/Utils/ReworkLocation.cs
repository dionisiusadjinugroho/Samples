using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YasunliplastApp.Utils
{
    public class ReworkLocation : INotifyPropertyChanged
    {
        #region Fields

        private string barcodeid;
        private string itemid;
        private string itemname;
        private string model;
        private string qty;
        private string location;



        #endregion

        #region Constructor
        public ReworkLocation()
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

        public string ItemID
        {
            get { return this.itemid; }
            set
            {
                this.itemid = value;
                RaisePropertyChanged("ItemID");
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
        public string Model
        {
            get { return this.model; }
            set
            {
                this.model = value;
                RaisePropertyChanged("Model");
            }
        }
        public string Qty
        {
            get { return this.qty; }
            set
            {
                this.qty = value;
                RaisePropertyChanged("Qty");
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
