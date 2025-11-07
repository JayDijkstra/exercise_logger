namespace ExerciseLogger.Models
{
    public class StrengthExercise : Exercise
    {
        public WeightType WeightType { get; set; } = WeightType.KiloGrams;
        public List<ExerciseSet> Sets { get; set; } = [];
    }

    public enum WeightType
    {
        Level,
        KiloGrams,
    }
}
