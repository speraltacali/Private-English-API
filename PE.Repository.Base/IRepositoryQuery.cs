using PE.Domain.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PE.Repository.Base
{
    public interface IRepositoryQuery<T> where T : EntityBase
    {
        T GetById(long id);

        T GetById(long id, params Expression<Func<T, object>>[] includeProprerty);

        T GetById(long id  ,  string query);

        //*********************************************************************************//

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(params Expression<Func<T,object>>[] includeProperty);

        IEnumerable<T> GetAll(string query);

        //*********************************************************************************//

        IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate, params Expression<Func<T,object>>[] includeProperty);

        IEnumerable<T> GetByFilter(Expression<Func<T , bool>> predicate, string query);
    }
}
