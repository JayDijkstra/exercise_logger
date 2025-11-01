namespace ExerciseLogger.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public MainFocus MainFocus { get; set; } = MainFocus.Other;
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }

        public enum MainFocus
    {
        Legs,
        Back,
        Chest,
        Triceps,
        Biceps,
        Cardio,
        Fitboxing,
        Other
    }
}
