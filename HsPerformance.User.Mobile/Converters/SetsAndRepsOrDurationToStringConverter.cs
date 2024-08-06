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

            int sets = (int)values[0];
            int reps = (int)values[1];
            int duration = (int)values[2];

            if (reps != 0) return $"{sets} X {reps}";
            else return $"{sets} X {duration} seconds";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
