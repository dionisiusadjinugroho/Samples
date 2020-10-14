using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YasunliplastApp.Utils
{
    public class ReportSampling : INotifyPropertyChanged
    {
        #region Fields

        private string barcodeid;
        private string itemid;
        private string itemname;
        private string samplingtime;
        private string employeename;
        private string output;

        #endregion

        #region Constructor
        public ReportSampling()
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
        public string SamplingTime
        {
            get { return this.samplingtime; }
            set
            {
                this.samplingtime = value;
                RaisePropertyChanged("SamplingTime");
            }
        }
        public string EmployeeName
        {
            get { return this.employeename; }
            set
            {
                this.employeename = value;
                RaisePropertyChanged("EmployeeName");
            }
        }
        public string Output
        {
            get { return this.output; }
            set
            {
                this.output = value;
                RaisePropertyChanged("Output");
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
