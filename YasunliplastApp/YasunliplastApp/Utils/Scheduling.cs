using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class Scheduling : INotifyPropertyChanged
    {
        #region Fields
        //private string strbase64photo;
        //private ImageSource photo;
        private string npk;
        private string nama;
        private string masuk;
        private string pulang;
        private string masukaktual;
        private string pulangaktual;
        private string jumlahlembur;
        private string jumlahlemburaktual;
        private string keterangan;
        private string approveby;

        #endregion

        #region Constructor
        public Scheduling()
        {

        }
        #endregion

        #region Public Properties
        //public string StrBase64Photo
        //{
        //    get { return this.strbase64photo; }
        //    set
        //    {
        //        this.strbase64photo = value;
        //        RaisePropertyChanged("StrBase64Photo");
        //    }
        //}
        //public ImageSource Photo
        //{
        //    get { return this.photo; }
        //    set
        //    {
        //        this.photo = value;
        //        RaisePropertyChanged("Photo");
        //    }
        //}
        public string NPK
        {
            get { return this.npk; }
            set
            {
                this.npk = value;
                RaisePropertyChanged("NPK");
            }
        }
        public string Nama
        {
            get { return this.nama; }
            set
            {
                this.nama = value;
                RaisePropertyChanged("Nama");
            }
        }
        public string Masuk
        {
            get { return this.masuk; }
            set
            {
                this.masuk = value;
                RaisePropertyChanged("Masuk");
            }
        }
        public string Pulang
        {
            get { return this.pulang; }
            set
            {
                this.pulang = value;
                RaisePropertyChanged("Pulang");
            }
        }
        public string MasukAktual
        {
            get { return this.masukaktual; }
            set
            {
                this.masukaktual = value;
                RaisePropertyChanged("MasukAktual");
            }
        }
        public string PulangAktual
        {
            get { return this.pulangaktual; }
            set
            {
                this.pulangaktual = value;
                RaisePropertyChanged("PulangAktual");
            }
        }
        public string JumlahLembur
        {
            get { return this.jumlahlembur; }
            set
            {
                this.jumlahlembur = value;
                RaisePropertyChanged("JumlahLembur");
            }
        }

        public string JumlahLemburAktual
        {
            get { return this.jumlahlemburaktual; }
            set
            {
                this.jumlahlemburaktual = value;
                RaisePropertyChanged("JumlahLemburAktual");
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
        public string ApproveBy
        {
            get { return this.approveby; }
            set
            {
                this.approveby = value;
                RaisePropertyChanged("ApproveBy");
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
