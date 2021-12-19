using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    class RendezVous
    {
        [Key]
        public int ID { get; set; }
        
        public DateTime date { get; set; }
        public Boolean Valider { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int MedecinID { get; set; }
        public Medecin Medecin { get; set; }

    }
}
