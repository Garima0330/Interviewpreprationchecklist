using Microsoft.AspNetCore.Mvc;
using InterviewPrepPlanner.API.Data;
using InterviewPrepPlanner.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InterviewPrepPlanner.API.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
        {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
            {
            _context = context;
            }

        [HttpGet("byday/{dayId}")]
        public IActionResult GetTasksByDay(int dayId)
            {
            var tasks = _context.Tasks
                .Where(t => t.DayId == dayId)
                .ToList();

            return Ok(tasks);
            }

        [HttpPost]
        public IActionResult AddTask(TaskItem task)
            {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Ok(task);
            }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, TaskItem updatedTask)
            {
            var task = _context.Tasks.Find(id);
            if (task == null)
                return NotFound();

            task.Title = updatedTask.Title;
            task.Note = updatedTask.Note;
            task.IsCompleted = updatedTask.IsCompleted;

            _context.SaveChanges();
            return Ok(task);
            }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
            {
            var task = _context.Tasks.Find(id);
            if (task == null)
                return NotFound();

            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return Ok();
            }
        }
    }
