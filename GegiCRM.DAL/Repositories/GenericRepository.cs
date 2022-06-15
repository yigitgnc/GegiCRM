using GegiCRM.DAL.Abstract.Generic;
using GegiCRM.DAL.Concrete;
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
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        virtual public List<T> GetListAll(bool includeDeletedRecords)
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        virtual public List<T> ListByFilter(Expression<Func<T, bool>> filter, bool includeDeletedRecords)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }


    }
}
