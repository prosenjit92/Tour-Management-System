using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LocationRepo : Repo, IRepo<Location, int, bool>
    {
        public bool Create(Location obj)
        {
            db.Locations.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Location> Read()
        {
            throw new NotImplementedException();
        }

        public Location Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Location obj)
        {
            var ex = Read(obj.LocationId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return true;
            return false;

        }
    }
}
