namespace PocketTrainer_API.Models;

public class Workout
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public List<WorkoutDay> WorkoutDays { get; set; }
}