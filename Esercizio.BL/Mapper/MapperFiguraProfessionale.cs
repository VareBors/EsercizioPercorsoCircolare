using Esercizio.BL.DTO;
using Esercizio.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.BL.Mapper
{
    public static class MapperFiguraProfessionale
    {
        public static FiguraProfessionale GetEntityFiguraProfessionale(DTOFiguraProfessionale dtoFiguraProfessionale)
        {
            FiguraProfessionale figuraProfessionaleEntity = new FiguraProfessionale()
            {
                FiguraProfessionaleID = dtoFiguraProfessionale.FiguraProfessionaleID,
                Descrizione = dtoFiguraProfessionale.Descrizione

            };

            return figuraProfessionaleEntity;
        }

        public static DTOFiguraProfessionale GetDTOFiguraProfessionale(FiguraProfessionale figuraProfessionale)
        {
            DTOFiguraProfessionale DTOFiguraProfessionale = new DTOFiguraProfessionale()
            {
                FiguraProfessionaleID = figuraProfessionale.FiguraProfessionaleID,
                Descrizione = figuraProfessionale.Descrizione

            };
            return DTOFiguraProfessionale;
        }
    }
}
