﻿using System;
using Xamarin.Forms;
using System.Globalization;
using System.Collections;

namespace FormsToolkit
{
    public class HasDataConverter : IValueConverter
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //if null then not visible
            if (value == null)
                return false;

            //if empty string then not visible
            if (value is string)
                return !string.IsNullOrWhiteSpace((string)value);

            //if blank list not visible
            if (value is IList)
                return ((IList)value).Count > 0;

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

