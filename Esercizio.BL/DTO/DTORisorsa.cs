using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.BL.DTO
{
    public class DTORisorsa
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int FiguraProfessionaleID { get; set; }
        public string DescrizioneFiguraProfessionale { get; set; }
    }
}
