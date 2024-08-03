namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.TMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.TMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

/*            for (int i = 0; i < 11; i++)
            {
                context.TourGuides.AddOrUpdate(new EF.TourGuide
                {
                    
                    Uname = "User-" + i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Phone = Guid.NewGuid().ToString().Substring(0, 11)
                });
            }
*/            /*Random random = new Random();
            for (int i = 1; i < 11; i++)
            {
                context.TourAssignments.AddOrUpdate(new EF.TourAssignment
                {
                    AssignmentID = i,
                    TourID = random.Next(1, 9),
                    GuideID = random.Next(1, 9)

                });
            }
            for (int i = 1; i < 11; i++)
            {
                context.TravelerProfiles.AddOrUpdate(new EF.TravelerProfile
                {
                    TravelerID = i,
                    TravelerName = Guid.NewGuid().ToString().Substring(0, 10),
                    TravelerPhone = Guid.NewGuid().ToString().Substring(0, 10),

                });
            }
            for (int i = 0; i < 11; i++)
            {
                context.Tours.AddOrUpdate(new EF.Tour
                {
                    TourID = i,
                    TourLocation = Guid.NewGuid().ToString().Substring(0, 10),

                });
            }*/
        }
    }
}
