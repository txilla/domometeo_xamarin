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
            switch (valueAsString)
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
