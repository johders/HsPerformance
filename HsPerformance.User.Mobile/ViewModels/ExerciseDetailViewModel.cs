using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HsPerformance.User.Mobile.Models;
using HsPerformance.User.Mobile.Services;
using HsPerformance.User.Mobile.ViewModels.Base;

namespace HsPerformance.User.Mobile.ViewModels
{
    public partial class ExerciseDetailViewModel : ViewModelBase, IQueryAttributable
    {
        private readonly IExerciseService _exerciseService;

        [ObservableProperty]
        private Guid _id;

        [ObservableProperty]
        private UserViewModel _user;

        [ObservableProperty]
        private DateTime _date;

        [ObservableProperty]
        private BaseExerciseViewModel _exercise;

        [ObservableProperty]
        private int _sets;

        [ObservableProperty]
        private int _reps;

        [ObservableProperty]
        private int _duration;

        [ObservableProperty]
        private int _rest;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CompleteExerciseCommand))]
        private ExerciseStatusEnum _exerciseStatus;

        [RelayCommand(CanExecute = nameof(CanCompleteExercise))]
        private void CompleteExercise() => ExerciseStatus = ExerciseStatusEnum.Completed;
        private bool CanCompleteExercise() => ExerciseStatus != ExerciseStatusEnum.Completed;

        private async Task GetExercise(Guid id)
        {
            var exercise = await _exerciseService.GetExercise(id);

            if(exercise != null)
            {
                MapExerciseData(exercise);
            }
        }

        private void MapExerciseData(ExerciseModel exercise)
        {
            Id = exercise.Id;
            User = null;
            Date = exercise.Date;
            Exercise = new BaseExerciseViewModel
            {
                Id = exercise.Exercise.Id,
                Name = exercise.Exercise.Name,
                VideoUrl = exercise.Exercise.VideoUrl,
                Description = exercise.Exercise.Description
            };
            Sets = exercise.Sets;
            Reps = exercise.Reps;
            Duration = exercise.Duration;
            Rest = exercise.Rest;
            ExerciseStatus = (ExerciseStatusEnum)exercise.Status;
        }

        public override async Task LoadAsync()
        {
            await Loading(
                async () =>
                {
                    if (Id != Guid.Empty)
                    {
                        await GetExercise(Id);
                    }
                });
        }

        public ExerciseDetailViewModel(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var exerciseId = query["ExerciseId"].ToString();
            if (Guid.TryParse(exerciseId, out var selectedId))
            {
                Id = selectedId;
            }
        }
    }
}
