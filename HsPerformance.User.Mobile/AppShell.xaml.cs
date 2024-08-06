using HsPerformance.User.Mobile.Views;

namespace HsPerformance.User.Mobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("exercise", typeof(ExerciseDetailPage));
        }
    }
}
