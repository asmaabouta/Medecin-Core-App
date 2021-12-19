using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Medecin
    {
        [Key]
        public int ID { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Specialite { get; set; }
        public string PrixVisite { get; set; }



    }
}
