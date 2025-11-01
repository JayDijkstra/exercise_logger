namespace ExerciseLogger.Models
{
    public class StrengthExercise : Exercise
    {
        public WeightType WeightType { get; set; } = WeightType.KiloGrams;
        public int Sets { get; set; } = 4;
        public int Reps { get; set; } = 10;
        public int Load{ get; set; }
    }

    public enum WeightType
    {
        Level,
        KiloGrams,
    }
}