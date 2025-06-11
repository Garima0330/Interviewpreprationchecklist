namespace InterviewPrepPlanner.API.Models
    {
    public class TaskItem
        {
        public int Id { get; set; }
        public int DayId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public bool IsCompleted { get; set; }

        public Day Day { get; set; }
        }
    }
