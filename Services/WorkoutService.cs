using ExerciseLogger.Data;
using ExerciseLogger.Models;
using ExerciseLogger.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExerciseLogger.Services
{
    public class WorkoutService : IWorkoutService
    {
        // TODO:: There are just a few entitites, for now we can directly call the db context.
        // TODO:: Refactor it with the repository pattern when entities increases.
        private readonly AppDbContext _context;

        public WorkoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Workout>> GetAllWorkoutAsync() =>
            await _context.Workouts.OrderByDescending(w => w.Date).ToListAsync();

        public async Task AddWorkoutAsync(Workout workout)
        {
            _context.Workouts.Add(workout);
            await _context.SaveChangesAsync();

        }
    }
}
