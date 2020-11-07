using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.DAL.Repo
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
