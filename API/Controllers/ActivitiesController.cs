using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities() => await _context.Activities.ToListAsync();

        [HttpGet("{id}")] //api/activities/id
        public async Task<ActionResult<Activity>> GetActivitiy(Guid id) => await _context.Activities.FirstAsync(s => s.Id == id);
    }
}