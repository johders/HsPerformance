using CommunityToolkit.Mvvm.ComponentModel;

namespace HsPerformance.User.Mobile.ViewModels
{
    public partial class ExerciseListOverviewViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ExerciseListItemViewModel> _exercises = new();

        public ExerciseListOverviewViewModel()
        {
            Exercises = new List<ExerciseListItemViewModel>()
            {
                new(Guid.Parse("{71ef8bb6-06af-4437-847c-e13fef88ae5c}"), 
                DateTime.Today,
                new BaseExerciseViewModel
                { 
                Id = Guid.Parse("{bedc18f0-1396-43e5-862e-bac7f34149d2}"),
                Name = "Lunge with reach",
                VideoUrl = "https://www.youtube.com/watch?v=JVzLwJFaGcQ",
                Description = "Stand up tall with your feet shoulder-width apart. " +
                "\r\n\r\n1. Step forward with your right foot, lowering your body into a basic lunge position." +
                "\r\n2. Twist your upper body to the right from your midsection. Keep your core engaged, squeeze your glutes, and be careful to not rotate your knee." +
                "\r\n3. Bring your arms back to the center in a slow, controlled movement.\r\nStep the right foot back and return to the starting position."
                }, 3, 20, 0, 30),

                new(Guid.Parse("{fc50cb4b-c916-4412-82f0-0f4dc99b7823}"),
                DateTime.Today,
                new BaseExerciseViewModel
                {
                Id = Guid.Parse("{3374de58-d003-4d72-a6a6-eefa68eca18b}"),
                Name = "Pull up",
                VideoUrl = "https://www.youtube.com/watch?v=eGo4IYlbE5g",
                Description = "Start by positioning yourself under the center of a pullup bar. Reach up and grip the bar with both hands, palms facing away from you. " +
                "Your arms should be extended straight overhead.\r\nWrap your fingers over the bar and your thumb under the bar so that it’s almost touching your fingertips." +
                "\r\nMake sure your hands are a little more than shoulder-width apart.\r\nPress your shoulders down.\r\nBring your shoulder blades toward each other, as if you are " +
                "trying to use them to squeeze a lemon.\r\nLift your feet completely off the floor, crossing your ankles. This is called a “dead hang.”\r\nLift your chest slightly and pull. " +
                "Draw your elbows down to your body until your chin is above the bar.\r\nAs you lower yourself back down, control your release to prevent injury."
                }, 4, 10, 0, 60),

                new(Guid.Parse("{71ef8bb6-06af-4437-847c-e13fef88ae5c}"),
                DateTime.Today,
                new BaseExerciseViewModel
                {
                Id = Guid.Parse("{d961cd7e-4b1f-45fb-97e7-90af700579a9}"),
                Name = "Jumping jacks",
                VideoUrl = "https://www.youtube.com/watch?v=iSSAk4XCsRA",
                Description = "Begin by standing with your legs straight and your arms to your sides." +
                "\r\nJump up and spread your feet beyond hip-width apart while bringing your arms above " +
                "your head, nearly touching.\r\nJump again, lowering your arms and bringing your legs " +
                "together. Return to your starting position"
                }, 5, 15, 0, 45),

                new(Guid.Parse("{6727cc63-6e5f-4b7d-a321-091a76040e42}"),
                DateTime.Today,
                new BaseExerciseViewModel
                {
                Id = Guid.Parse("{48e5692c-0c6f-44d1-955e-f0c48bc778ad}"),
                Name = "Plank",
                VideoUrl = "https://www.youtube.com/watch?v=yeKv5oX_6GY",
                Description = "Lying on the ground with the elbows in line with the shoulder and the feet shoulder width apart, " +
                "Push your body up bearing the weight on  the forearms and feet, Keeping your body straight."
                }, 3, 0, 60, 30),

            };
        }
    }
}
