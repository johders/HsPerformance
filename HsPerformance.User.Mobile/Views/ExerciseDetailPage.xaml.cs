using HsPerformance.User.Mobile.ViewModels;

namespace HsPerformance.User.Mobile.Views;

public partial class ExerciseDetailPage : ContentPage
{
	public ExerciseDetailPage()
	{
		InitializeComponent();
		BindingContext = new ExerciseDetailViewModel();
	}
}