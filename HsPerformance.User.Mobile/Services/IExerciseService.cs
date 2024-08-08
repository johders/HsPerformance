using HsPerformance.User.Mobile.Models;

namespace HsPerformance.User.Mobile.Services
{
    public interface IExerciseService
    {
        Task<List<ExerciseModel>> GetExercises();
        Task<ExerciseModel?> GetExercise(Guid id);
        Task<bool> UpdateStatus(Guid id, ExerciseStatusModel status);
    }
}
