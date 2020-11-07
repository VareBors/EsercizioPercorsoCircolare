using Esercizio.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.DAL.Repo
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private CensimentoContext Context;
        private DbSet<TEntity> _dbSet;
        
        protected DbSet<TEntity> DbSet
        {
            get
            {
                if (_dbSet == null)
                {
                    _dbSet = Context.Set<TEntity>();
                }
                return _dbSet;
            }
        }

        public Repository(CensimentoContext context)
        {
            this.Context = context;
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            Type genericType = typeof(TEntity);

            if(genericType == typeof(Risorsa))
            {
                return DbSet.Include("FiguraProfessionale");
            }
            else
            {
                return DbSet;
            }
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
    }
}
