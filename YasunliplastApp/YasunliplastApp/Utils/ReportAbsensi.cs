using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class ReportAbsensi : INotifyPropertyChanged
    {
        #region Fields
        private string strbase64photo;
        private ImageSource photo;
        private string employeeid;
        private string employeename;
        private string machine;
        private string workdate;

        #endregion

        #region Constructor
        public ReportAbsensi()
        {

        }
        #endregion

        #region Public Properties
        public string StrBase64Photo
        {
            get { return this.strbase64photo; }
            set
            {
                this.strbase64photo = value;
                RaisePropertyChanged("StrBase64Photo");
            }
        }
        public ImageSource Photo
        {
            get { return this.photo; }
            set
            {
                this.photo = value;
                RaisePropertyChanged("Photo");
            }
        }
        public string EmployeeID
        {
            get { return this.employeeid; }
            set
            {
                this.employeeid = value;
                RaisePropertyChanged("EmployeeID");
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
        public string Machine
        {
            get { return this.machine; }
            set
            {
                this.machine = value;
                RaisePropertyChanged("Machine");
            }
        }
        public string WorkDate
        {
            get { return this.workdate; }
            set
            {
                this.workdate = value;
                RaisePropertyChanged("WorkDate");
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
