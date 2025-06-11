using Microsoft.AspNetCore.Mvc;
using InterviewPrepPlanner.API.Data;
using InterviewPrepPlanner.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InterviewPrepPlanner.API.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class DayController : ControllerBase
        {
        private readonly AppDbContext _context;

        public DayController(AppDbContext context)
            {
            _context = context;
            }

        [HttpGet("byweek/{weekId}")]
        public IActionResult GetDaysByWeek(int weekId)
            {
            var days = _context.Days
                .Where(d => d.WeekId == weekId)
                .ToList();

            return Ok(days);
            }

        [HttpPost]
        public IActionResult AddDay(Day day)
            {
            _context.Days.Add(day);
            _context.SaveChanges();
            return Ok(day);
            }
        }
    }
