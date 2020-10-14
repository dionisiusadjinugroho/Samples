using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YasunliplastApp.Utils
{
    public class DEMODataBarcode : INotifyPropertyChanged
    {
        #region Fields

        private string barcodeid;
        private string itemid;
        private string itemname;


        #endregion

        #region Constructor
        public DEMODataBarcode()
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
