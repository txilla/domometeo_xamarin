using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DomoMeteoXamarin.Converters
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            string valueAsString = value.ToString();

            DateTime parsedDate = DateTime.Parse(valueAsString);

            DateTime today = DateTime.Today;

            var days = (today - parsedDate).TotalDays;

            if (days > 2)
            {
                return Color.Red;
            }

            return Color.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
