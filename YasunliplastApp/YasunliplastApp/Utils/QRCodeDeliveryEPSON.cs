using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace YasunliplastApp.Utils
{
    public class QRCodeDeliveryEPSON : INotifyPropertyChanged
    {
        #region Fields

        private string barcodeid;
        private string itemid;
        private string itemname;
        private string qty;
        private string lotno;
        private string rfid;
        private string boxtype;
        private Color color;

        #endregion

        #region Constructor
        public QRCodeDeliveryEPSON()
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

        public string Qty
        {
            get { return this.qty; }
            set
            {
                this.qty = value;
                RaisePropertyChanged("Qty");
            }
        }
        public string LotNo
        {
            get { return this.lotno; }
            set
            {
                this.lotno = value;
                RaisePropertyChanged("LotNo");
            }
        }
        public string RFID
        {
            get { return this.rfid; }
            set
            {
                this.rfid = value;
                RaisePropertyChanged("RFID");
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
