using GegiCRM.DAL.Abstract.Generic;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        virtual public T Create(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
            return t;
        }

        virtual public T Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
            return t;
        }

        virtual public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        virtual public T GetByID(int id, bool includeDeletedRecords)
        {
            var c = new Context();
            return c.Set<T>().Find(id);
        }

        virtual public List<T> GetListAll(bool includeDeletedRecords)
        {
            var c = new Context();
            return c.Set<T>().ToList();
        }

        virtual public List<T> ListByFilter(Expression<Func<T, bool>> filter, bool includeDeletedRecords)
        {
            var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        /// <summary>
        /// usage: data = CustomerReposirty.Include(c => c.AddedBy).Include(c => c.MainCustomer.AddedBy).ToList();
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IEnumerable<T> Include(params Expression<Func<T, object>>[] includes)
        {
            Context c = new Context();
            var dbSet = c.Set<T>();

            IEnumerable<T> query = null;
            foreach (var include in includes)
            {
                query = dbSet.Include(include);
            }

            return query ?? dbSet;
        }

        public IEnumerable<T> Include(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes)
        {
            Context c = new Context();
            var dbSet = c.Set<T>();

            IEnumerable<T> query = null;

            query = dbSet.Where(filter);

            foreach (var include in includes)
            {
                query = dbSet.Include(include);
            }

            return query ?? dbSet;
        }

    }
}
