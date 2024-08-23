using HsPerformance.User.Mobile.Views;

namespace HsPerformance.User.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new MainPage();
            //MainPage = new ExerciseDetailPage();
            //MainPage = new ExerciseOverviewPage();
        }
    }
}
