using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HsPerformance.User.Mobile.ViewModels
{
    public partial class ExerciseDetailViewModel : ObservableObject
    {
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

        public ExerciseDetailViewModel()
        {

            Id = Guid.Parse("{8ef61111-65be-4e96-9d54-0fde6ec6f423}");
            User = new UserViewModel
            {
                Id = Guid.Parse("{adf4c14b-ca1e-4bfe-867b-b693a9d0808d}"),
                Email = "hsp-test@gmail.com"
            };
            Exercise = new BaseExerciseViewModel
            {
                Id = Guid.Parse("{bedc18f0-1396-43e5-862e-bac7f34149d2}"),
                Name = "Lunge with reach",
                VideoUrl = "https://www.youtube.com/watch?v=JVzLwJFaGcQ",
                Description = "Stand up tall with your feet shoulder-width apart. " +
                "\r\n\r\n1. Step forward with your right foot, lowering your body into a basic lunge position." +
                "\r\n2. Twist your upper body to the right from your midsection. Keep your core engaged, squeeze your glutes, and be careful to not rotate your knee." +
                "\r\n3. Bring your arms back to the center in a slow, controlled movement.\r\nStep the right foot back and return to the starting position."
            };
            Sets = 3;
            Reps = 20;
            //Duration = 45;
            Rest = 30;
            ExerciseStatus = ExerciseStatusEnum.NotCompleted;
        }
    }
}
