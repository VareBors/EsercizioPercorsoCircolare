using Esercizio.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.DAL
{
    public class CensimentoContext : DbContext
    {
        public DbSet<FiguraProfessionale> FigureProfessionali { get; set; }
        public DbSet<Risorsa> Risorse { get; set; }

        public CensimentoContext(DbContextOptions<CensimentoContext> options) : base(options) 
        { 
        }

        //public CensimentoContext()
        //{

        //}
    }
}
