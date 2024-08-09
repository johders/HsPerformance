using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HsPerformance.User.Mobile.Models;
using HsPerformance.User.Mobile.Services;
using HsPerformance.User.Mobile.ViewModels.Base;
using System.Collections.ObjectModel;

namespace HsPerformance.User.Mobile.ViewModels
{

    public partial class ExerciseListOverviewViewModel : ViewModelBase
    {
        private readonly IExerciseService _exerciseService;
        private readonly INavigationService _navigationService;
        
        [ObservableProperty]
        private ObservableCollection<ExerciseListItemViewModel> _exercises = new();

        [ObservableProperty]
        private ExerciseListItemViewModel? _selectedExercise;

        [RelayCommand]
        private async Task NavigateToSelectedExercise()
        {
            if(SelectedExercise is not null)
            {
                await _navigationService.GoToSelectedExercise(SelectedExercise.Id);
                SelectedExercise = null;
            }
        }
        public ExerciseListOverviewViewModel(INavigationService navigationService, IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
            _navigationService = navigationService;
        }

        public override async Task LoadAsync()
        {
            if(Exercises.Count == 0)
            {
                await Loading(GetExercises);
            }
        }

        private async Task GetExercises()
        {
            List<ExerciseModel> exercises = await _exerciseService.GetExercises();
            ObservableCollection<ExerciseListItemViewModel> listItems = new();
            foreach(var exercise in exercises)
            {
                listItems.Add(MapExerciseModelToExerciseListItemViewModel(exercise));
            }

            Exercises.Clear();
            Exercises = listItems;
        }

        private ExerciseListItemViewModel MapExerciseModelToExerciseListItemViewModel(ExerciseModel exercise)
        {
            var baseExercise = new BaseExerciseViewModel
            {
                Id = exercise.Exercise.Id,
                Name = exercise.Exercise.Name,
                VideoUrl = exercise.Exercise.VideoUrl
            };

            return new ExerciseListItemViewModel(
                exercise.Id,
                exercise.Date,
                baseExercise,
                exercise.Sets,
                exercise.Reps,
                exercise.Duration,
                exercise.Rest,
                (ExerciseStatusEnum)exercise.Status
                );
        }
    }
}
