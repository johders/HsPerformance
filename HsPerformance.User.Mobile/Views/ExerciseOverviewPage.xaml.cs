using HsPerformance.User.Mobile.Services;
using HsPerformance.User.Mobile.ViewModels;

namespace HsPerformance.User.Mobile.Views;

public partial class ExerciseOverviewPage : ContentPageBase
{
	public ExerciseOverviewPage(ExerciseListOverviewViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}