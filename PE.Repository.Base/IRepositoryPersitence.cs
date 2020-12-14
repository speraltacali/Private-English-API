using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Repository.Base
{
    public interface IRepositoryPersitence<T> where T :  EntityBase
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(long id);

        void Save();
    }
}
