using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    class MedecinRepository : GenericRepository<Medecin>
    {
        public MedecinRepository(PatientContext context) : base(context)
        {

        }
    }
}
