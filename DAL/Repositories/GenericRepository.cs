using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PatientContext patientContext;
        private DbSet<T> table;
        public GenericRepository(PatientContext context)
        {
            patientContext = context;
            table = patientContext.Set<T>();
        }
        public void Add(T obj)
        {
            table.Add(obj);
        }

        public T GetById(int id)
        {
            var result = table.Find(id);
            return result;
        }

        public IEnumerable<T> GetAll()
        {
            return table;
        }

        public void Delete(int id)
        {
            var result = table.Find(id);
            patientContext.Remove(result);
        }

        public void Update(T obj)
        {
            patientContext.Update(obj);
        }

        public void Save()
        {
            patientContext.SaveChanges();
        }
    }
}
