using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PE.Repository.Base
{
    public interface IRepository<T> : IRepositoryPersitence<T> , IRepositoryQuery<T> where T : EntityBase 
    {
    }
}
