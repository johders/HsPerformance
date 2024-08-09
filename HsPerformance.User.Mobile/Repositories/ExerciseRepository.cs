using HsPerformance.User.Mobile.Models;

namespace HsPerformance.User.Mobile.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        public async Task<ExerciseModel?> GetExercise(Guid id)
        {
            return ExerciseRepositoryData().FirstOrDefault(e => e.Id == id);
        }

        public async Task<List<ExerciseModel>> GetExercises()
        {
            List<ExerciseModel> allItems = ExerciseRepositoryData();
            return allItems;
        }

        public async Task<bool> UpdateStatus(Guid id, ExerciseStatusModel status)
        {
            try
            {
                var exercise = ExerciseRepositoryData().FirstOrDefault(e => e.Id == id);
                if (exercise != null)
                {
                    exercise.Status = status;
                    return true;
                }                
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }

        public List<ExerciseModel> ExerciseRepositoryData()
        {
            List<ExerciseModel> data = new List<ExerciseModel> 
            {
                new()
                {
                    Id= Guid.Parse("{71ef8bb6-06af-4437-847c-e13fef88ae5c}"),
                    Date = DateTime.Today,
                    Exercise =
                        new BaseExerciseModel
                        {
                        Id = Guid.Parse("{bedc18f0-1396-43e5-862e-bac7f34149d2}"),
                        Name = "Lunge with reach",
                        VideoUrl = "https://www.youtube.com/watch?v=JVzLwJFaGcQ",
                        Description = "Stand up tall with your feet shoulder-width apart. " +
                        "\r\n\r\n1. Step forward with your right foot, lowering your body into a basic lunge position." +
                        "\r\n2. Twist your upper body to the right from your midsection. Keep your core engaged, squeeze your glutes, and be careful to not rotate your knee." +
                        "\r\n3. Bring your arms back to the center in a slow, controlled movement.\r\nStep the right foot back and return to the starting position."
                        },
                    Sets = 3,
                    Reps = 20,
                    Duration = 0,
                    Rest = 30,
                    Status = ExerciseStatusModel.PartiallyCompleted
                },

                new()
                {
                    Id= Guid.Parse("{fc50cb4b-c916-4412-82f0-0f4dc99b7823}"),
                    Date = DateTime.Today,
                    Exercise =
                        new BaseExerciseModel
                        {
                        Id = Guid.Parse("{3374de58-d003-4d72-a6a6-eefa68eca18b}"),
                        Name = "Pull up",
                        VideoUrl = "https://www.youtube.com/watch?v=eGo4IYlbE5g",
                        Description = "Start by positioning yourself under the center of a pullup bar. Reach up and grip the bar with both hands, palms facing away from you. " +
                        "Your arms should be extended straight overhead.\r\nWrap your fingers over the bar and your thumb under the bar so that it’s almost touching your fingertips." +
                        "\r\nMake sure your hands are a little more than shoulder-width apart.\r\nPress your shoulders down.\r\nBring your shoulder blades toward each other, as if you are " +
                        "trying to use them to squeeze a lemon.\r\nLift your feet completely off the floor, crossing your ankles. This is called a “dead hang.”\r\nLift your chest slightly and pull. " +
                        "Draw your elbows down to your body until your chin is above the bar.\r\nAs you lower yourself back down, control your release to prevent injury."
                        },
                    Sets = 4,
                    Reps = 10,
                    Duration = 0,
                    Rest = 60,
                    Status = ExerciseStatusModel.PartiallyCompleted
                },

                new()
                {
                    Id= Guid.Parse("{9c109c6e-f302-423c-ba2b-115f995d4e27}"),
                    Date = DateTime.Today,
                    Exercise =
                        new BaseExerciseModel
                        {
                        Id = Guid.Parse("{d961cd7e-4b1f-45fb-97e7-90af700579a9}"),
                        Name = "Jumping jacks",
                        VideoUrl = "https://www.youtube.com/watch?v=iSSAk4XCsRA",
                        Description = "Begin by standing with your legs straight and your arms to your sides." +
                        "\r\nJump up and spread your feet beyond hip-width apart while bringing your arms above " +
                        "your head, nearly touching.\r\nJump again, lowering your arms and bringing your legs " +
                        "together. Return to your starting position"
                        },
                    Sets = 5,
                    Reps = 15,
                    Duration = 0,
                    Rest = 45,
                    Status = ExerciseStatusModel.NotCompleted
                },

                new()
                {
                    Id= Guid.Parse("{6727cc63-6e5f-4b7d-a321-091a76040e42}"),
                    Date = DateTime.Today,
                    Exercise =
                        new BaseExerciseModel
                        {
                        Id = Guid.Parse("{48e5692c-0c6f-44d1-955e-f0c48bc778ad}"),
                        Name = "Plank",
                        VideoUrl = "https://www.youtube.com/watch?v=yeKv5oX_6GY",
                        Description = "Lying on the ground with the elbows in line with the shoulder and the feet shoulder width apart, " +
                        "Push your body up bearing the weight on  the forearms and feet, Keeping your body straight."
                        },
                    Sets = 3,
                    Reps = 0,
                    Duration = 60,
                    Rest = 30,
                    Status = ExerciseStatusModel.NotCompleted
                },

                new()
                {
                    Id= Guid.Parse("{75e98072-0bf5-4308-84e9-1b13e530c4bc}"),
                    Date = DateTime.Today,
                    Exercise =
                        new BaseExerciseModel
                        {
                         Id = Guid.Parse("{0e463741-40c9-441f-9000-a550511a0c21}"),
                    Name = "Squat",
                    VideoUrl = "https://www.youtube.com/watch?v=xqvCmoLULNY",
                    Description = "Start with feet slightly wider than hip-width apart, toes turned slightly out.\r\nKeeping your chest up and out and " +
                    "the pressure even in your feet, engage your abdominals and shift your weight back into your heels as you push your hips back." +
                    "\r\nLower yourself into a squat until either your heels begin to lift off the floor, or until your torso begins to round or flex forward. " +
                    "Your depth should be determined by your form.\r\nKeep your chest out and core tight as you push through your heels to stand back " +
                    "up to your starting position. Squeeze your glutes at the top.\r\nPerform 10–15 reps. Work up to 3 sets."
                        },
                    Sets = 6,
                    Reps = 12,
                    Duration = 0,
                    Rest = 30,
                    Status = ExerciseStatusModel.Completed
                },             

            };

            return data;
        }
    }
}
