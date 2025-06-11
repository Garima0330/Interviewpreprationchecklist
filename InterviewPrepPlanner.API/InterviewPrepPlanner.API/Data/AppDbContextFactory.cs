using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using InterviewPrepPlanner.API.Models;

namespace InterviewPrepPlanner.API.Data
    {
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
        public AppDbContext CreateDbContext(string[] args)
            {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=LPT4463\\SQLEXPRESS;Database=master;trusted_connection=true;TrustServerCertificate=True");

            return new AppDbContext(optionsBuilder.Options);
            }
        }
    }
