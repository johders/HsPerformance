namespace HsPerformance.User.Mobile.ViewModels
{
    public class ExerciseListItemViewModel
    {
        public Guid Id { get; set; }
        public UserViewModel? User { get; set; }
        public DateTime Date { get; set; }
        public BaseExerciseViewModel Exercise { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Duration { get; set; }
        public int Rest { get; set; }
        public ExerciseStatusEnum Status { get; set; }

        public ExerciseListItemViewModel(Guid id, DateTime date, 
            BaseExerciseViewModel exercise, int sets, int reps, int duration, int rest, 
            ExerciseStatusEnum status = ExerciseStatusEnum.NotCompleted, UserViewModel? user = null)
        {
            Id = id;           
            Date = date;
            Exercise = exercise;
            Sets = sets;
            Reps = reps;
            Duration = duration;
            Rest = rest;
            Status = status;
            User = user;
        }
    }
}
