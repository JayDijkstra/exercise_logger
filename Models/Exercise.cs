namespace ExerciseLogger.Models
{
    public abstract class Exercise
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Notes { get; set; }
        public ExerciseType ExerciseType { get; set; }
    }

    public enum ExerciseType
    {
        WarmingUp,
        Main,
        CoolingDown,
    }
}
