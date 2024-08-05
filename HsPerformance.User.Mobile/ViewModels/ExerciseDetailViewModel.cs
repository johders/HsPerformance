using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace HsPerformance.User.Mobile.ViewModels
{
    public class ExerciseDetailViewModel : INotifyPropertyChanged
    {
        private ExerciseStatusEnum _status;

        public Guid Id { get; set; }
        public UserViewModel User { get; set; }
        public BaseExerciseViewModel Exercise { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Duration { get; set; }
        public int Rest { get; set; }


        public ExerciseStatusEnum Status
        {
            get => _status;
            set
            {
                if (!value.Equals(_status))
                {
                    _status = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CompleteExerciseCommand { get; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CompleteExercise() => Status = ExerciseStatusEnum.Completed;

        public ExerciseDetailViewModel()
        {
            CompleteExerciseCommand = new Command(CompleteExercise);

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
            Status = ExerciseStatusEnum.NotCompleted;
        }
    }
}
