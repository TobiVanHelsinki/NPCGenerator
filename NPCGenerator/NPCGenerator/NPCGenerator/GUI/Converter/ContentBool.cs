using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace NPCGenerator.GUI.Converter
{
    // Custom class implements the IValueConverter interface. 
    public class ContentBool : IValueConverter
    {
        #region IValueConverter Members 
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            return (bool)value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            return value.ToString() ?? "-";
        }
        #endregion
    }
}
