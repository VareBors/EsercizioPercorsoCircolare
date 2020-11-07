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
    public class ManagerFigureProfessionali
    {
        private readonly IUnitOfWork UnitOfWork;

        public ManagerFigureProfessionali(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public int Add(DTOFiguraProfessionale dToFiguraProfessionale)
        {
            FiguraProfessionale newFiguraProfessionale = MapperFiguraProfessionale.GetEntityFiguraProfessionale(dToFiguraProfessionale);
            newFiguraProfessionale.DataCreazione = DateTime.Now;

            UnitOfWork.FiguraProfessionaleRepository.Add(newFiguraProfessionale);
            UnitOfWork.Commit();
            return newFiguraProfessionale.FiguraProfessionaleID;
        }
        public int Update(DTOFiguraProfessionale dToFiguraProfessionale)
        {
            FiguraProfessionale newFiguraProfessionale = MapperFiguraProfessionale.GetEntityFiguraProfessionale(dToFiguraProfessionale);
            newFiguraProfessionale.DataCreazione = DateTime.Now;

            UnitOfWork.FiguraProfessionaleRepository.Update(newFiguraProfessionale);
            UnitOfWork.Commit();
            return newFiguraProfessionale.FiguraProfessionaleID;
        }
        public int Delete(DTOFiguraProfessionale dToFiguraProfessionale)
        {
            FiguraProfessionale newFiguraProfessionale = MapperFiguraProfessionale.GetEntityFiguraProfessionale(dToFiguraProfessionale);
            newFiguraProfessionale.DataCreazione = DateTime.Now;

            UnitOfWork.FiguraProfessionaleRepository.Delete(newFiguraProfessionale);
            UnitOfWork.Commit();
            return newFiguraProfessionale.FiguraProfessionaleID;
        }
        public List<DTOFiguraProfessionale> GetAll()
        {
            List<FiguraProfessionale> listFigureProfessionali;
            List<DTOFiguraProfessionale> figuraProfessionaleDTOList = new List<DTOFiguraProfessionale>();
            listFigureProfessionali = UnitOfWork.FiguraProfessionaleRepository.GetAll().ToList();

            foreach (FiguraProfessionale item in listFigureProfessionali)
            {
                figuraProfessionaleDTOList.Add(MapperFiguraProfessionale.GetDTOFiguraProfessionale(item));
            }

            return figuraProfessionaleDTOList;
        }
    }
}
