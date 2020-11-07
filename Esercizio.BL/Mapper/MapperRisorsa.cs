using Esercizio.BL.DTO;
using Esercizio.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.BL.Mapper
{
    public static class MapperRisorsa
    {
        public static Risorsa GetEntityRisorsa(DTORisorsa dtoRisorsa)
        {
            Risorsa risorsaEntity = new Risorsa()
            {
                Nome = dtoRisorsa.Nome,
                Cognome = dtoRisorsa.Cognome,
                User = dtoRisorsa.User,
                FiguraProfessionaleID = dtoRisorsa.FiguraProfessionaleID,
            };

            return risorsaEntity;
        }

        public static DTORisorsa GetDTORisorsa(Risorsa risorsa)
        {

            DTORisorsa dtoRisorsa = new DTORisorsa()
            {
                Nome = risorsa.Nome,
                Cognome = risorsa.Cognome,
                User = risorsa.User,
                FiguraProfessionaleID = risorsa.FiguraProfessionaleID,
                DescrizioneFiguraProfessionale = risorsa.FiguraProfessionale.Descrizione
            };

            return dtoRisorsa;
        }
    }
}
