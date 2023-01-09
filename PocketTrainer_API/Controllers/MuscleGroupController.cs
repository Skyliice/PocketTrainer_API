using Microsoft.AspNetCore.Mvc;
using PocketTrainer_API.Data;
using PocketTrainer_API.Models;

namespace PocketTrainer_API.Controllers;

[ApiController]
[Route("[controller]")]
public class MuscleGroupController : ControllerBase
{
    private PocketTrainerDb _context;

    public MuscleGroupController(PocketTrainerDb context)
    {
        _context = context;
    }
    
    [HttpGet]
    public List<MuscleGroup> GetAll()
    {
        return _context.MuscleGroups.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<MuscleGroup> GetSingleMuscleGroup(int id)
    {
        if (_context.MuscleGroups.Any(o => o.Id == id))
            return _context.MuscleGroups.SingleOrDefault(o => o.Id == id);
        else return NotFound();
    }
}