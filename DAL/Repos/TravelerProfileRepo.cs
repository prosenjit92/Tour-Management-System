using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TravelerProfileRepo : Repo, IRepo<TravelerProfile, int, bool>
    {
        public bool Create(TravelerProfile obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TravelerProfile> Read()
        {
            throw new NotImplementedException();
        }

        public TravelerProfile Read(int id)
        {
            return db.TravelerProfiles.Find(id);
        }

        public bool Update(TravelerProfile obj)
        {
            throw new NotImplementedException();
        }
    }
}
