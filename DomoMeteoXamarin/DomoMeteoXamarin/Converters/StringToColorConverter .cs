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
            /*
            string valueAsString = value.ToString();

            DateTime parsedDate = DateTime.Parse(valueAsString);

            DateTime today = DateTime.Today;

            var days = (today - parsedDate).TotalDays;

            if(days > 2)
            {
                case (""):
                    {
                        return Color.Cyan;
                    }
                case ("Accent"):
                    {
                        return Color.Red;
                    }
                default:
                    {
                        //return Color.FromHex(value.ToString());
                        return Color.Green;
                    }
            }
            */

            return Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
