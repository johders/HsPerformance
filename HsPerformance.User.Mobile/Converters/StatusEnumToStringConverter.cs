using HsPerformance.User.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Converters
{
    public class StatusEnumToStringConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not ExerciseStatusEnum status)
            {
                return string.Empty;
            }

            return status switch
            {
                ExerciseStatusEnum.NotCompleted => "Not completed",
                ExerciseStatusEnum.PartiallyCompleted => "Partially completed",
                ExerciseStatusEnum.Completed => "Completed",
                _ => string.Empty
            };
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
