using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Services
{
    public class NavigationService : INavigationService
    {
        public async Task GoToSelectedExercise(Guid id)
        {
            var parameters = new Dictionary<string, object> { { "ExerciseId", id } };
            await Shell.Current.GoToAsync("exercise", parameters);
        }
    }
}
