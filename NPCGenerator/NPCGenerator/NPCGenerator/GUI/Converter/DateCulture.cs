using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace NPCGenerator.GUI.Converter
{
    // Custom class implements the IValueConverter interface. 
    public class DateCulture : IValueConverter
    {
        #region IValueConverter Members 
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            if (value is DateTime)
            {
                return ((DateTime)value).ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern);
            }
            return "FORMAT ERROR";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
