﻿namespace PocketTrainer_API.Models;

public class MuscleGroup
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImagePath { get; set; }
    public List<Exercise> Exercises { get; set; }
}