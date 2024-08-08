using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Models
{
    public class ExerciseModel
    {
        public Guid Id { get; set; }
        public UserModel User { get; set; } = default!;
        public DateTime Date { get; set; }
        public BaseExerciseModel Exercise { get; set; } = default!;
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Duration { get; set; }
        public int Rest { get; set; }
        public ExerciseStatusModel Status { get; set; }

    }
}
