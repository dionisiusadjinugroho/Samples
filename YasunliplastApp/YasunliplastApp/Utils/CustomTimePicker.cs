using Syncfusion.SfPicker.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class CustomTimePicker : SfPicker
    {
        // Time api is used to modify the Hour collection as per change in Time
        /// <summary>
        /// Time is the acutal DataSource for SfPicker control which will holds the collection of Hour ,Minute and Second
        /// </summary>
        public ObservableCollection<object> Time { get; set; }

        //Minute is the collection of minute numbers

        public ObservableCollection<object> Minute;

        //Hour is the collection of hour numbers

        public ObservableCollection<object> Hour;

        //Second is the collection of AM and PM

        public ObservableCollection<object> Second;
        /// <summary>
        /// Header api is holds the column name for every column in time picker
        /// </summary>

        public ObservableCollection<string> Headers { get; set; }
        public CustomTimePicker()
        {
            Time = new ObservableCollection<object>();
            Hour = new ObservableCollection<object>();
            Minute = new ObservableCollection<object>();
            Second = new ObservableCollection<object>();
            Headers = new ObservableCollection<string>();
            if (Device.RuntimePlatform == Device.Android)
            {
                Headers.Add("HOUR");
                Headers.Add("MINUTE");
                Headers.Add("SECOND");
            }
            else
            {
                Headers.Add("Hour");
                Headers.Add("Minute");
                Headers.Add("Second");
            }

            //Enable Footer of SfPicker
            ShowFooter = true;

            //Enable Header of SfPicker
            ShowHeader = true;

            //Enable Column Header of SfPicker
            ShowColumnHeader = true;


            //SfPicker header text
            HeaderText = "TIME PICKER";

            PopulateTimeCollection();
            this.ItemsSource = Time;

            // Column header text collection
            this.ColumnHeaderText = Headers;
        }

        private void PopulateTimeCollection()
        {

            Hour.Add("-");
            Minute.Add("-");
            Second.Add("-");


            //Populate Hour
            for (int i = 0; i <= 23; i++)
            {
                if(i < 10)
                {
                    Hour.Add("0" + i.ToString());
                }
                else
                    Hour.Add(i.ToString());

            }

            //Populate Minute
            for (int j = 0; j < 60; j++)
            {
                if (j < 10)
                {
                    Minute.Add("0" + j);
                }
                else
                    Minute.Add(j.ToString());
            }

            //Populate Second
            for (int j = 0; j < 60; j++)
            {
                if (j < 10)
                {
                    Second.Add("0" + j);
                }
                else
                    Second.Add(j.ToString());
            }


            Time.Add(Hour);
            Time.Add(Minute);
            Time.Add(Second);
        }
    }
}