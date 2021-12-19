using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    interface IGenericRepository<T> where T : class
    {
        public void Add(T obj);
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public void Delete(int id);
        public void Update(T obj);

        public void Save();
    }
}
