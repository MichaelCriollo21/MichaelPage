using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.PruebaMP.Interface
{
    public interface IBase<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
