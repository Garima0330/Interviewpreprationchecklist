using Microsoft.AspNetCore.Mvc;
using InterviewPrepPlanner.API.Data;
using InterviewPrepPlanner.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InterviewPrepPlanner.API.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class WeekController : ControllerBase
        {
        private readonly AppDbContext _context;

        public WeekController(AppDbContext context)
            {
            _context = context;
            }

        [HttpGet("bymonth/{monthId}")]
        public IActionResult GetWeeksByMonth(int monthId)
            {
            var weeks = _context.Weeks
                .Where(w => w.MonthId == monthId)
                .ToList();

            return Ok(weeks);
            }

        [HttpPost]
        public IActionResult AddWeek(Week week)
            {
            _context.Weeks.Add(week);
            _context.SaveChanges();
            return Ok(week);
            }
        }
    }
