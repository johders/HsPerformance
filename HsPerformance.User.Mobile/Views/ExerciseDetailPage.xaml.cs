using HsPerformance.User.Mobile.ViewModels;

namespace HsPerformance.User.Mobile.Views;

public partial class ExerciseDetailPage : ContentPageBase
{
	public ExerciseDetailPage(ExerciseDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}