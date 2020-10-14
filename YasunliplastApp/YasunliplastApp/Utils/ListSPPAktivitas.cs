using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class ListSPPAktivitas : INotifyPropertyChanged
    {
        #region Fields

        private string sppno;
        private string status;
        private string technisiname;
        private string customername;
        private string mouldname;
        private string model;
        private Color color;

        #endregion

        #region Constructor
        public ListSPPAktivitas()
        {

        }


        #endregion

        #region Public Properties

        public string SPPNo
        {
            get { return this.sppno; }
            set
            {
                this.sppno = value;
                RaisePropertyChanged("SPPNo");
            }
        }

        public string TechnisiName
        {
            get { return this.technisiname; }
            set
            {
                this.technisiname = value;
                RaisePropertyChanged("TechnisiName");
            }
        }

        public string MouldName
        {
            get { return this.mouldname; }
            set
            {
                this.mouldname = value;
                RaisePropertyChanged("MouldName");
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
