using GolfApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Repos
{
    public class IGolfClubDAL : IMainRepo<GolfClub>
    {
        public Golf_AppContext _dBContext;

        public IGolfClubDAL(Golf_AppContext dBContext)
        {
            _dBContext = dBContext;

        }
        public void Delete(int id)
        {
            _dBContext.GolfClubs.Remove(_dBContext.GolfClubs.Where(x => x.ClubId.Equals(id)).FirstOrDefault());
            SaveChanges();
        }

        public void Delete(GolfClub entityToDelete)
        {
            _dBContext.GolfClubs.Remove(entityToDelete);
            SaveChanges();
        }

        public List<GolfClub> Get()
        {
            return _dBContext.GolfClubs.ToList();
        }

        public GolfClub GetByID(int id)
        {
            return Get().Where(x => x.ClubId.Equals(id)).FirstOrDefault();
        }

        public void Insert(GolfClub entity)
        {
            _dBContext.GolfClubs.Add(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dBContext.SaveChanges();
        }

        public void Update(GolfClub entityToUpdate)
        {
            _dBContext.Entry(entityToUpdate).State = EntityState.Modified;
            SaveChanges();
        }
    }
}
