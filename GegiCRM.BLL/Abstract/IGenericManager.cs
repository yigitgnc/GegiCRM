using System.Linq.Expressions;

namespace GegiCRM.BLL.Abstract
{
    public interface IGenericManager<T> where T : class
    {
        T Create(T t);
        void Delete(T t);
        List<T> GetAll(bool includeDeletedRecords);
        T? GetById(int id,bool includeDeletedRecords);
        List<T> ListByFilter(Expression<Func<T, bool>> filter, bool includeDeletedRecords);
        T Update(T t);
    }
}