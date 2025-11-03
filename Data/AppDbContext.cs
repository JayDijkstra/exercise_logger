using ExerciseLogger.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseLogger.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Exercise>()
                .HasDiscriminator<String>("ExcerciseType")
                .HasValue<StrengthExercise>("Strength")
                .HasValue<CardioExercise>("Cardio");
        }
    }
}
