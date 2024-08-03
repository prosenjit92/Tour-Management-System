using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TourAssignmentRepo : Repo, IRepo<TourAssignment, int, bool>
    {
        public bool Create(TourAssignment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TourAssignment> Read()
        {
            return db.TourAssignments.ToList();
        }

        public TourAssignment Read(int id)
        {
            return db.TourAssignments.Find(id);
        }

        public bool Update(TourAssignment obj)
        {
            throw new NotImplementedException();
        }
    }
}
