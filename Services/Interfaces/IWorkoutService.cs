using ExerciseLogger.Models;

namespace ExerciseLogger.Services.Interfaces
{
    public interface IWorkoutService
    {
        Task<List<Workout>> GetAllWorkoutAsync();
        Task AddWorkoutAsync(Workout workout);
    }
}
