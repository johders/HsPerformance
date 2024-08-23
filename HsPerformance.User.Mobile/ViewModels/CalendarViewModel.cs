using CommunityToolkit.Mvvm.ComponentModel;
using HsPerformance.User.Mobile.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.ViewModels
{
    public partial class CalendarViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<CalendarListItemViewModel> _dates = new();

        [ObservableProperty]
        private CalendarListItemViewModel? _selectedDate;

        public CalendarViewModel()
        {
            GetDates(DateTime.Now);
        }

        private void GetDates(DateTime selectedDate)
        {
            int daysCount = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            for (int day = 1; day <= daysCount; day++)
            {
                Dates.Add(new CalendarListItemViewModel
                {
                    Date = new DateTime(selectedDate.Year, selectedDate.Month, day)
                });
            }
        }
    }
}
