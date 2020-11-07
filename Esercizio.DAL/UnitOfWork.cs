using Esercizio.DAL.Entities;
using Esercizio.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private CensimentoContext dbContext;
        private IRepository<Risorsa> risorsaRepository;
        private IRepository<FiguraProfessionale> figuraProfessionaleRepository;

        public IRepository<Risorsa> RisorsaRepository => risorsaRepository = risorsaRepository ?? new Repository<Risorsa>(dbContext);
        public IRepository<FiguraProfessionale> FiguraProfessionaleRepository => figuraProfessionaleRepository = figuraProfessionaleRepository ?? new Repository<FiguraProfessionale>(dbContext);


        public UnitOfWork(CensimentoContext context)
        {
            this.dbContext = context;
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public void Rollback()
        {
            dbContext.Dispose();
        }
    }
}
