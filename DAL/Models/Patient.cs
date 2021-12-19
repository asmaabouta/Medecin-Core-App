using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    class Patient
    {  
        [Key]
        public int ID { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public ICollection<RendezVous> RendezVous { get; set; }

    }
}
