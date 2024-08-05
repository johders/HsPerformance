using HsPerformance.User.Mobile.ViewModels;

namespace HsPerformance.User.Mobile.Views;

public partial class ExerciseOverviewPage : ContentPage
{
	public ExerciseOverviewPage()
	{
		InitializeComponent();
		BindingContext = new ExerciseListOverviewViewModel();
	}
}