using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Job_Aplication_Tracker.Models;
using Job_Application_Tracker_Webapp.Models;

namespace Job_Application_Tracker_Webapp.Data
{
    public class Job_Application_Tracker_WebappContext : DbContext
    {
        public Job_Application_Tracker_WebappContext (DbContextOptions<Job_Application_Tracker_WebappContext> options)
            : base(options)
        {
        }

        public DbSet<Job_Aplication_Tracker.Models.Application> Application { get; set; } = default!;

        public DbSet<Job_Application_Tracker_Webapp.Models.User>? User { get; set; }
    }
}
