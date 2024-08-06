using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Services
{
    public interface INavigationService
    {
        Task GoToSelectedExercise(Guid selectedExerciseId);
    }
}
