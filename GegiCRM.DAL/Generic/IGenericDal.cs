using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace GegiCRM.DAL.Abstract.Generic
{
    public interface IGenericDal<T> where T : class
    {
        T Create(T t);
        void Delete(T t);
        T Update(T t);
        List<T> GetListAll(bool includeDeletedRecords);
        T? GetByID(int id, bool includeDeletedRecords);
        List<T> ListByFilter(Expression<Func<T, bool>> filter, bool includeDeletedRecords);
        public IEnumerable<T> Include(params Expression<Func<T, object>>[] includes);
        public IEnumerable<T> Include(Expression<Func<T, bool>> filter,  params Expression<Func<T, object>>[] includes);


    }
}
