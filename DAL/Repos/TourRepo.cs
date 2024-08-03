using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TourRepo : Repo, IRepo<Tour, int, bool> 
    {
        public bool Create(Tour obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tour> Read()
        {
            return db.Tours.ToList();
        }

        public Tour Read(int id)
        {
            return db.Tours.Find(id);
        }

        public bool Update(Tour obj)
        {
            throw new NotImplementedException();
        }
    }
}
