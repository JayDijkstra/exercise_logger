using ExerciseLogger.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseLogger.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<StrengthExercise> StrengthExercises { get; set; }
        public DbSet<CardioExercise> CardioExercises { get; set; }
        public DbSet<ExerciseSet> ExerciseSets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Exercise>()
                .HasDiscriminator<String>("ExcerciseType")
                .HasValue<StrengthExercise>("Strength")
                .HasValue<CardioExercise>("Cardio");

            builder.Entity<StrengthExercise>()
                .HasMany(e => e.Sets)
                .WithOne(s => s.StrengthExercise)
                .HasForeignKey(s => s.StrengthExerciseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
