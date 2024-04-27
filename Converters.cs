using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShellNavigationTest
{
    public static class Converters
    {
        public static InvertBool InvertBool { get; set; } = new InvertBool();
    }


    public class InvertBool : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var b = value as bool?;
            if (b == null)
            {
                return value;
            }

            return !b.Value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
