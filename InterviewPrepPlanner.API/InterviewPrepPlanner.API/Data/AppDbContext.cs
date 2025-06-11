using Microsoft.EntityFrameworkCore;
using InterviewPrepPlanner.API.Models;

namespace InterviewPrepPlanner.API.Data
    {
    public class AppDbContext : DbContext
        {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Month> Months { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        }
    }
