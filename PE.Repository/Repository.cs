using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PE.Domain.Base.EntityBase;
using PE.Infrastructure.Context;
using PE.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PE.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ModelContext _Context;


        public Repository()
            : this(new ModelContext())
        {

        }


        public Repository(ModelContext Context)
        {
            _Context = Context;
        }

        public void Add(T entity)
        {
            _Context.Set<T>().Add(entity);
        }

        public void Delete(long id)
        {
            var obj = GetById(id);

            _Context.Set<T>().Remove(obj);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public void Update(T entity)
        {
            _Context.Set<T>().Attach(entity);

            _Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        //********************************************************************************************//

        public IEnumerable<T> GetAll()
        {
            return _Context.Set<T>().AsNoTracking().ToList();
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> query = _Context.Set<T>().AsNoTracking();

            query = includeProperty.Aggregate(query, (current, property) => current.Include(property));

            return query.ToList();
        }

        public IEnumerable<T> GetAll(string query)
        {
            IQueryable<T> Query = _Context.Set<T>().AsNoTracking();

            Query = query.Split('.').Aggregate(Query, (current, includeProperty) => current.Include(includeProperty));

            return Query.ToList();
        }

        //********************************************************************************************//

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _Context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> query = _Context.Set<T>().AsNoTracking();

            query = includeProperty.Aggregate(query, (current, Property) => current.Include(Property));

            return query.ToList();
        }

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate, string query)
        {
            IQueryable<T> Query = _Context.Set<T>().AsNoTracking();

            Query = query.Split('.').Aggregate(Query, (current, includePorperty) => current.Include(includePorperty));

            return Query.ToList();
        }

        //********************************************************************************************//

        public T GetById(long id)
        {
            return _Context.Set<T>().Find(id);
        }

        public T GetById(long id, params Expression<Func<T, object>>[] includeProprerty)
        {
            IQueryable<T> query = _Context.Set<T>();

            query = includeProprerty.Aggregate(query, (current, Property) => current.Include(Property));

            return query.FirstOrDefault(x => x.Id == id);
        }

        public T GetById(long id, string query)
        {
            IQueryable<T> Query = _Context.Set<T>();

            Query = query.Split('.').Aggregate(Query, (current, includeProperty) => current.Include(includeProperty));

            return Query.FirstOrDefault(x => x.Id == id);
        }

        
    }
}
