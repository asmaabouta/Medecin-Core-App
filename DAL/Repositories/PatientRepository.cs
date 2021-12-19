using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
     class PatientRepository:GenericRepository<Patient>
    {
        public PatientRepository(PatientContext context) : base(context)
        {

        }
    }
}
