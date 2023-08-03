namespace Job_Aplication_Tracker.Models
{
    public class Application
    {
        public int id { get; set; }
        public string position { get; set; }
        public string enterprise { get; set; }
        public short confidence { get; set; } //1-5 represented by 1-5 stars
        public string link { get; set; } //lnk to the application
        public DateTime application_date { get; set; }
        public string state { get; set; } //waiting for response, waiting for interview, successful interview...
        public DateTime state_change_date { get; set; }
        public int user_id { get; set; }

        public Application()
        {

        }
    }
}
