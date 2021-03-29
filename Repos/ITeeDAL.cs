using GolfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Repos
{
    public class ITeeDAL : IMainRepo<Tee>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tee entityToDelete)
        {
            throw new NotImplementedException();
        }

        public List<Tee> Get()
        {
            throw new NotImplementedException();
        }

        public Tee GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Tee entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Tee entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
