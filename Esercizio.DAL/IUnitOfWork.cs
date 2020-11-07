using Esercizio.DAL.Entities;
using Esercizio.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.DAL
{
    public interface IUnitOfWork
    {
        IRepository<Risorsa> RisorsaRepository { get; }
        IRepository<FiguraProfessionale> FiguraProfessionaleRepository { get; }

        void Commit();
        void Rollback();
    }
}
