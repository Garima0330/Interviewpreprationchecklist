namespace InterviewPrepPlanner.API.Models
    {
    public class Month
        {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Week> Weeks { get; set; }
        }
    }
