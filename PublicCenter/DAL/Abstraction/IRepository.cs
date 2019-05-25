using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Abstractions
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        T Create(T item);
        T Update(T item);
        void Delete(int id);
    }
}
