using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<TourGuide,int, TourGuide> TourGuideData()
        {
            return new TourGuideRepo();
        }
        public static IRepo<TravelerProfile,int, bool> TravelerProfileData()
        {
            return new TravelerProfileRepo();
        }
        public static IRepo<Tour,int, bool> TourData()
        {
            return new TourRepo();
        }
        public static IRepo<TourAssignment,int, bool> TourAssignmentData()
        {
            return new TourAssignmentRepo();
        }
        public static IRepo<Location,int, bool> LocationData()
        {
            return new LocationRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new TourGuideRepo();
        }


    }
}
