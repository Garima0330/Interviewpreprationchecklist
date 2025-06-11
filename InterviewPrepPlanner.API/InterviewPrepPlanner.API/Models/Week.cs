namespace InterviewPrepPlanner.API.Models
    {
    public class Week
        {
        public int Id { get; set; }
        public int MonthId { get; set; }
        public int WeekNumber { get; set; }

        public Month Month { get; set; }
        public ICollection<Day> Days { get; set; }
        }
    }
