using HsPerformance.User.Mobile.ViewModels;

namespace HsPerformance.User.Mobile.ViewsPartial;

public partial class CalendarView : ContentView
{
	public CalendarView()
	{
		InitializeComponent();
		BindingContext = new CalendarViewModel();
	}
}