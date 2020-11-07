using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Esercizio.DAL.Entities
{
    public class FiguraProfessionale
    {
        [Key]
        public int FiguraProfessionaleID { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataCreazione { get; set; }
        public virtual List<Risorsa> Risorse { get; set; }
    }
}
