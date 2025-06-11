using Microsoft.AspNetCore.Mvc;
using InterviewPrepPlanner.API.Data;
using InterviewPrepPlanner.API.Models;

namespace InterviewPrepPlanner.API.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class MonthController : ControllerBase
        {
        private readonly AppDbContext _context;

        public MonthController(AppDbContext context)
            {
            _context = context;
            }

        [HttpGet]
        public IActionResult GetMonths()
            {
            return Ok(_context.Months.ToList());
            }

        [HttpPost]
        public IActionResult AddMonth(Month month)
            {
            _context.Months.Add(month);
            _context.SaveChanges();
            return Ok(month);
            }
        }
    }
