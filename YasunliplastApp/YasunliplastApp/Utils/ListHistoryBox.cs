using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class ListHistoryBox : INotifyPropertyChanged
    {
        #region Fields
        private string scanTime;
        private string keterangan;
        private string admScan;
        private string plannerScan;
        private string receiveBy;

        #endregion

        #region Constructor
        public ListHistoryBox()
        {

        }
        #endregion

        #region Public Properties
        public string ScanTime
        {
            get { return this.scanTime; }
            set
            {
                this.scanTime = value;
                RaisePropertyChanged("ScanTime");
            }
        }

        public string Keterangan
        {
            get { return this.keterangan; }
            set
            {
                this.keterangan = value;
                RaisePropertyChanged("Keterangan");
            }
        }
        public string AdmScan
        {
            get { return this.admScan; }
            set
            {
                this.admScan = value;
                RaisePropertyChanged("AdmScan");
            }
        }
        public string PlannerScan
        {
            get { return this.plannerScan; }
            set
            {
                this.plannerScan = value;
                RaisePropertyChanged("PlannerScan");
            }
        }
        public string ReceiveBy
        {
            get { return this.receiveBy; }
            set
            {
                this.receiveBy = value;
                RaisePropertyChanged("ReceiveBy");
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
