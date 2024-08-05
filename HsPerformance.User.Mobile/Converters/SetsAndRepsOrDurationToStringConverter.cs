using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Converters
{
    public class SetsAndRepsOrDurationToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] == null || values[1] == null || values[2] == null)
            {
                return string.Empty;
            }

            if ((int)values[1] != 0) return $"{values[0]} X {values[1]}";
            else return $"{values[0]} X {values[2]} seconds";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
