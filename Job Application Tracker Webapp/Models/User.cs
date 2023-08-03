namespace Job_Application_Tracker_Webapp.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public DateTime datecreated { get; set; } //date when the account was created
        public string password { get; set; } //hashed password
        public DateTime last_login { get; set; }

        public User()
        {
            
        }
    }
}
