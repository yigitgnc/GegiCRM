using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        T Insert(T t);
        void Delete(T t);
        T Update(T t);
        List<T> GetListAll();
        T? GetByID(int id);
        List<T> ListByFilter(Expression<Func<T, bool>> filter);
    }
}
