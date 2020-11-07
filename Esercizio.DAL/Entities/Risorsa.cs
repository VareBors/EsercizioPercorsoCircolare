using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Esercizio.DAL.Entities
{
    public class Risorsa
    {
        [Key]
        public int ID { get; set; }
        public string User { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataCreazione { get; set; }
        //Campi per gestione Foreign Key 1 a N code First
        public int FiguraProfessionaleID { get; set; }
        public virtual FiguraProfessionale FiguraProfessionale { get; set; }
    }
}
