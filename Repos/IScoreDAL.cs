using GolfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Repos
{
    public class IScoreDAL : IMainRepo<Score>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Score entityToDelete)
        {
            throw new NotImplementedException();
        }

        public List<Score> Get()
        {
            throw new NotImplementedException();
        }

        public Score GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Score entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Score entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
