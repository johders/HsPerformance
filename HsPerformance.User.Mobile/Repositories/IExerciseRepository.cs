using HsPerformance.User.Mobile.Models;
using HsPerformance.User.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Repositories
{
    public interface IExerciseRepository
    {
        Task<List<ExerciseModel>> GetExercises();
        Task<ExerciseModel?> GetExercise(Guid id);
        Task<bool> UpdateStatus(Guid id, ExerciseStatusModel status);
    }
}
