using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewPrepPlanner.API.Models
    {
    public class Day
        {
        public int Id { get; set; }
        public int WeekId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }

        public Week Week { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
        }
    }
