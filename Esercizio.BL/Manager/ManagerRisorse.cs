using System;
using System.Collections.Generic;
using System.Text;
using Esercizio.BL.DTO;
using Esercizio.BL.Mapper;
using Esercizio.DAL.Entities;
using Esercizio.DAL;
using System.Linq;

namespace Esercizio.BL.Manager
{
    public class ManagerRisorse
    {
        public IUnitOfWork unitOfWork;
        public ManagerRisorse(IUnitOfWork iunitofWork)
        {
            unitOfWork = iunitofWork;
        }
        public int Add(DTORisorsa dtoRisorsa)
        {
            Risorsa risorsa = MapperRisorsa.GetEntityRisorsa(dtoRisorsa);
            risorsa.DataCreazione = DateTime.Now;

            unitOfWork.RisorsaRepository.Add(risorsa);
            unitOfWork.Commit();
            return risorsa.ID;
        }
        public int Update(DTORisorsa dtoRisorsa)
        {
            Risorsa risorsa = MapperRisorsa.GetEntityRisorsa(dtoRisorsa);
            risorsa.DataCreazione = DateTime.Now;

            unitOfWork.RisorsaRepository.Update(risorsa);
            unitOfWork.Commit();
            return risorsa.ID;
        }
        public int Delete(DTORisorsa dtoRisorsa)
        {
            Risorsa risorsa = MapperRisorsa.GetEntityRisorsa(dtoRisorsa);
            risorsa.DataCreazione = DateTime.Now;

            unitOfWork.RisorsaRepository.Delete(risorsa);
            unitOfWork.Commit();
            return risorsa.ID;
        }
        public List<DTORisorsa> GetAll()
        {
            List<Risorsa> listaRisorse;
            List<DTORisorsa> listaDTORisorse = new List<DTORisorsa>();
            listaRisorse = unitOfWork.RisorsaRepository.GetAll().ToList();
            
            foreach (Risorsa item in listaRisorse)
            {
                listaDTORisorse.Add(MapperRisorsa.GetDTORisorsa(item));
            }

            return listaDTORisorse;
        }
    }
}
