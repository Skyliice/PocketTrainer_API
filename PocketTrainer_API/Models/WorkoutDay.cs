namespace PocketTrainer_API.Models;

public class WorkoutDay
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Workout> Workouts { get; set; }
    public List<Exercise> Exercises { get; set; }
}