namespace ExerciseLogger.Models
{
    public class ExerciseSet
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public int StrengthExerciseId { get; set; }
        public required StrengthExercise StrengthExercise;
    }
}
