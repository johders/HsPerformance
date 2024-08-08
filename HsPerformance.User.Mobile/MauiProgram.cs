using HsPerformance.User.Mobile.Repositories;
using HsPerformance.User.Mobile.Services;
using HsPerformance.User.Mobile.ViewModels;
using HsPerformance.User.Mobile.Views;
using Microsoft.Extensions.Logging;

namespace HsPerformance.User.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .RegisterRepositories()
                .RegisterServices()
                .RegisterViewModels()
                .RegisterViews();
            

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static MauiAppBuilder RegisterRepositories(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IExerciseRepository, ExerciseRepository>();
            return builder;
        }

        private static MauiAppBuilder RegisterServices(this  MauiAppBuilder builder)
        {
            builder.Services.AddTransient<IExerciseService, ExerciseService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            return builder;
        }

        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<ExerciseListOverviewViewModel>();
            builder.Services.AddTransient<ExerciseDetailViewModel>();
            return builder;
        }

        private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<ExerciseOverviewPage>();
            builder.Services.AddTransient<ExerciseDetailPage>();
            return builder;
        }
    }
}
