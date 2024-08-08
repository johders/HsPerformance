using HsPerformance.User.Mobile.Models;
using HsPerformance.User.Mobile.Repositories;

namespace HsPerformance.User.Mobile.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public Task<ExerciseModel?> GetExercise(Guid id)
        {
            return _exerciseRepository.GetExercise(id);
        }

        public Task<List<ExerciseModel>> GetExercises() => _exerciseRepository.GetExercises();

        public Task<bool> UpdateStatus(Guid id, ExerciseStatusModel status)
        {
            return _exerciseRepository.UpdateStatus(id, status);
        }
    }
}
