using YasunliplastApp.Utils;
using YasunliplastApp.ViewModels.Base;
using YasunliplastApp.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace YasunliplastApp.ViewModels
{
    public class ReportAbsensiViewModel : ViewModelBase
    {
        App _application;

        public ReportAbsensiViewModel()
        {
            _application = Application.Current as App;
            ResWidth = _application.MainPage.Width;

            ReportAbsensis = new List<ReportAbsensi>();
            /////DUMMY DATA - TESTING BINDING
            //Random random = new Random();
            //for (int i=0;i<100;i++)
            //{
            //    ReportAbsensi RS = new ReportAbsensi();
            //    RS.BarcodeID = "SPP00000" + Convert.ToString(random.Next(0, 100000));
            //    RS.EmployeeName = "Employee" + Convert.ToString(random.Next(0, 100000));
            //    RS.ItemID = "ItemID" + Convert.ToString(random.Next(0, 100000));
            //    RS.ItemName = "Employee" + Convert.ToString(random.Next(0, 100000));
            //    RS.SamplingTime = "Datetime" + Convert.ToString(random.Next(0, 100000));
            //    ReportAbsensis.Add(RS);
            //}
        }

        public double ResWidth = 0;

        public List<ReportAbsensi> ReportAbsensis
        {
            get;
            set;
        }

        internal class ConverterBase64ImageSource : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                string base64Image = (string)value;

                if (base64Image == null)
                    return null;

                // Convert base64Image from string to byte-array
                var imageBytes = System.Convert.FromBase64String(base64Image);

                // Return a new ImageSource
                return ImageSource.FromStream(() => { return new MemoryStream(imageBytes); });
            }
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                // Not implemented as we do not convert back
                throw new NotSupportedException();
            }

        }


    }
}
