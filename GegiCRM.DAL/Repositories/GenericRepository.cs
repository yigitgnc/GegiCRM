using GegiCRM.DAL.Abstract;
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

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(SetLastModifed(t));
            c.SaveChanges();
        }

        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(SetLastModifed(t));
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> ListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }


        private static T SetLastModifed(T tEntity)
        {
            int id = 1;//todo: identity den Current Userin idsini alcaz burda

            var LastModProp = tEntity.GetType().GetProperty("ModifiedBy");
            if (LastModProp != null)
            {
                tEntity.GetType()
                    .GetProperty("ModifiedBy")
                    .SetValue(tEntity, id);
            }
            return tEntity;
        }
    }
}
