using GolfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Repos
{
    public class IPlayerDAL : IMainRepo<Player>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Player entityToDelete)
        {
            throw new NotImplementedException();
        }

        public List<Player> Get()
        {
            throw new NotImplementedException();
        }

        public Player GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Player entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Player entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
