using System;
using System.Collections.Generic;

namespace SubtypeCovariance
{
    public interface IEntityRepository<T> where T : Entity
    {
        void Add(T entity);
        void Remove(Guid id);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
