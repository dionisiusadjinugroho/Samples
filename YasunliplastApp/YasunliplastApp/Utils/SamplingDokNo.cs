using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YasunliplastApp.Utils
{
    public class SamplingDokNo : INotifyPropertyChanged
    {
        public string _documentno;
        public string DocumentNo
        {
            get { return _documentno; }
            set
            {
                if(_documentno != value)
                {
                    _documentno = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
