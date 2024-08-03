using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TourGuideRepo : Repo, IRepo<TourGuide, int, TourGuide>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.TourGuides.FirstOrDefault(u => u.Uname.Equals(username) && u.Password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public TourGuide Create(TourGuide obj)
        {
            db.TourGuides.Add(obj);
            if(db.SaveChanges()>0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.TourGuides.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<TourGuide> Read()
        {
            return db.TourGuides.ToList();
        }

        public TourGuide Read(int id)
        {
            return db.TourGuides.Find(id);
        }

        public TourGuide Update(TourGuide obj)
        {
            var ex = Read(obj.GuideID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }
    }
}
