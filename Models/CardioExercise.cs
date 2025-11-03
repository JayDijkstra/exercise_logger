namespace ExerciseLogger.Models
{
    public class CardioExercise : Exercise
    {
        public int Level { get; set; }
        public int DurationInMinutes { get; set; }
        public string? Program;
    }
}
