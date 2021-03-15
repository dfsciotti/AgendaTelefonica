using System.Collections.Generic;

namespace AgendaTelefonica.Repository
{
    public interface IBaseRepository<T>
    {
        void Delete(T obj);
        void Insert(T obj);
        void Update(T obj);
        T Select(int id);
        IEnumerable<T> GetAll();
    }
}
