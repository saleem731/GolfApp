using GolfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Repos
{
    public class IWeatherDAL : IMainRepo<Weather>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Weather entityToDelete)
        {
            throw new NotImplementedException();
        }

        public List<Weather> Get()
        {
            throw new NotImplementedException();
        }

        public Weather GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Weather entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Weather entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
