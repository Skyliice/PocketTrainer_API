using Microsoft.EntityFrameworkCore;
using PocketTrainer_API.Models;

namespace PocketTrainer_API.Data;

public class PocketTrainerDb : DbContext
{
    public PocketTrainerDb(DbContextOptions options) : base(options) {}
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<MuscleGroup> MuscleGroups { get; set; }
    public DbSet<WorkoutDay> WorkoutDays { get; set; }
    public DbSet<Workout> Workouts { get; set; }

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        
    }
}