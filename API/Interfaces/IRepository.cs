using System.Collections.Generic;

namespace API.Interfaces
{
    public interface IRepository<T, K>
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        T GetById(K id);
        void Delete(T entity);
        void DeleteById(K id);
        void Update(T entity);
        void UpdateById(K id, T entity);
        int Count();
    }
}