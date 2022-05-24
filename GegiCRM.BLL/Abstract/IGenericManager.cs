using System.Linq.Expressions;

namespace GegiCRM.BLL.Abstract
{
    public interface IGenericManager<T> where T : class
    {
        void Create(T t);
        void Delete(T t);
        List<T> GetAll();
        T? GetById(int id);
        List<T> ListByFilter(Expression<Func<T, bool>> filter);
        void Update(T t);
    }
}