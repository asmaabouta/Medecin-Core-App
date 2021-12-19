using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    class RendezVousRepository:GenericRepository<RendezVous>
    {
        public RendezVousRepository(PatientContext context) : base(context)
        {

        }
    }
}
