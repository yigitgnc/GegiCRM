using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new GegiCRM_DBContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new GegiCRM_DBContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new GegiCRM_DBContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new GegiCRM_DBContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new GegiCRM_DBContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
