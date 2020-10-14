using Java.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class SurKom : INotifyPropertyChanged
    {
        #region Fields
        private ImageSource photo;
        private string nama;     
        private string jabatan;
        private string surkomDate;  
        private TimeSpan planning;
        private TimeSpan aktual;
        private string reason;

        #endregion

        #region Constructor
        public SurKom()
        {

        }
        #endregion

        #region Public Properties    
        public ImageSource Photo
        {
            get { return this.photo; }
            set
            {
                this.photo = value;
                RaisePropertyChanged("Photo");
            }
        }
        public string Nama
        {
            get { return this.nama; }
            set
            {
                this.nama = value;
                RaisePropertyChanged("SurkomId");
            }
        }
        public string Jabatan
        {
            get { return this.jabatan; }
            set
            {
                this.jabatan = value;
                RaisePropertyChanged("Jabatan");
            }
        }          
        public string SurkomDate
        {
            get { return this.surkomDate; }
            set
            {
                this.surkomDate = value;
                RaisePropertyChanged("SurkomDate");
            }
        }      
     
        public TimeSpan Planning
        {
            get { return this.planning; }
            set
            {
                this.planning = value;
                RaisePropertyChanged("Planning");
            }
        }
        public TimeSpan Actual
        {
            get { return this.aktual; }
            set
            {
                this.aktual = value;
                RaisePropertyChanged("Actual");
            }
        }
        public string Reason
        {
            get { return this.reason; }
            set
            {
                this.reason = value;
                RaisePropertyChanged("Reason");
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
