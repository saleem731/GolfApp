using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Repos
{
    public interface IMainRepo<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);

        void Update(TEntity entityToUpdate);

        List<TEntity> Get();

        TEntity GetByID(int id);

        void Delete(int id);

        void Delete(TEntity entityToDelete);

        void SaveChanges();
    }
}
