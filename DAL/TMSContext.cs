using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TMSContext : DbContext
    {
        public DbSet<GuideProfile> GuideProfiles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<TravelerProfile> TravelerProfiles { get; set; }
        public DbSet<TourAssignment> TourAssignments { get; set; }
        public DbSet<TourGuide> TourGuides { get; set; }
        public DbSet<Tour> Tours { get; set; }
    }
}
