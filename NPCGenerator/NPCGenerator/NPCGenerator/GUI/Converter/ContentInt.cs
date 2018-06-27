using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace NPCGenerator.GUI.Converter
{
    // Custom class implements the IValueConverter interface. 
    public class ContentInt : IValueConverter
    {
        #region IValueConverter Members 
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            if (value is int)
            {
                return value.ToString();
            }
            return "0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            if (value is int)
            {
                return value;
            }
            if (value is string && int.TryParse((value as string), out int result))
            {
                return result;
            }
            return 0;
        }
        #endregion
    }
}
