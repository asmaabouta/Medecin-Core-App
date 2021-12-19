using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {
        }

        public DbSet<Patient> patients { get; set; }
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }

        

    }
}
