using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace YasunliplastApp.Utils
{
    public class QRCode_EPRO : INotifyPropertyChanged
    {
        #region Fields

        private string itemid;
        private int ttlqty;
        private string boxtype;
        private int qty_spq;
        private string mobil;
        private int ttlbox;

        #endregion

        #region Constructor
        public QRCode_EPRO()
        {

        }
        #endregion

        #region Public Properties

        public string ITEMID
        {
            get { return this.itemid; }
            set
            {
                this.itemid = value;
                RaisePropertyChanged("ITEMID");
            }
        }
        public int TTLQTY
        {
            get { return this.ttlqty; }
            set
            {
                this.ttlqty = value;
                RaisePropertyChanged("TTLQTY");
            }
        }
        public string BOXTYPE
        {
            get { return this.boxtype; }
            set
            {
                this.boxtype = value;
                RaisePropertyChanged("BOXTYPE");
            }
        }

        public int QTY_SPQ
        {
            get { return this.qty_spq; }
            set
            {
                this.qty_spq = value;
                RaisePropertyChanged("QTY_SPQ");
            }
        }
        public string MOBIL
        {
            get { return this.mobil; }
            set
            {
                this.mobil = value;
                RaisePropertyChanged("MOBIL");
            }
        }
        public int TTLBOX
        {
            get { return this.ttlbox; }
            set
            {
                this.ttlbox = value;
                RaisePropertyChanged("TTLBOX");
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
