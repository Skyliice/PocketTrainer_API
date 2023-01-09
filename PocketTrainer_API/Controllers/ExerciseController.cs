using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PocketTrainer_API.Data;
using PocketTrainer_API.Models;

namespace PocketTrainer_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController : ControllerBase
{
    private PocketTrainerDb _context;

    public ExerciseController(PocketTrainerDb context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IEnumerable<Exercise> GetAll()
    {
        return _context.Exercises
            .Include(o=>o.MuscleGroups)
            .AsNoTracking();
    }

    [HttpGet("{id}")]
    public ActionResult<Exercise> GetSingleExercise(int id)
    {
        if (_context.Exercises.Any(o => o.Id == id))
            return _context.Exercises
                .Include(o => o.MuscleGroups)
                .AsNoTracking()
                .SingleOrDefault(o => o.Id == id);
        else
            return NotFound();
    }
    
}