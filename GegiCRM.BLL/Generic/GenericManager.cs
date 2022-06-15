using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.BLL.Abstract;
using GegiCRM.DAL.Abstract.Generic;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace GegiCRM.BLL.Generic
{
    public class GenericManager<T> : IGenericManager<T> where T : class
    {
        public async Task<AppUser?> GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
        }

        public readonly UserManager<AppUser> _userManager;
        public IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<T> _logger;
        readonly IGenericDal<T> _genericDal;
        //GenericRepository<T> _genericDal = new GenericRepository<T>();
        public GenericManager(
            UserManager<AppUser> userManager,
            //IHttpContextAccessor httpContextAccessor,
            //ILogger<T> logger,
            IGenericDal<T> genericDal
            )
        {
            _userManager = userManager;
            _httpContextAccessor = new HttpContextAccessor();
            _logger = new Logger<T>(new LoggerFactory());
            _genericDal = genericDal;
        }

        public T Create(T t)
        {
            t = SetAddedBy(t);
            t = SetLastModifiedBy(t);
            _genericDal.Create(t);
            return t;
        }
        public T Update(T t)
        {
            t = SetLastModifiedBy(t);
            _genericDal.Update(t);
            return t;
        }

        public void Delete(T t)
        {
            t = SetLastModifiedBy(t);
            _genericDal.Delete(t);
        }
        public List<T> GetAll(bool includeDeletedRecords)
        {
            return _genericDal.GetListAll(includeDeletedRecords);
        }
        public T? GetById(int id, bool includeDeletedRecords)
        {
            return _genericDal.GetByID(id,includeDeletedRecords);
        }

        public List<T> ListByFilter(Expression<Func<T, bool>> filter, bool includeDeletedRecords)
        {
            return _genericDal.ListByFilter(filter, includeDeletedRecords);
        }

        private T SetLastModifiedBy(T tEntity)
        {

            //var LastModProp = tEntity.GetType().GetProperty("ModifiedDate");
            //if (LastModProp != null)
            //{
            //    tEntity.GetType()
            //        .GetProperty("ModifiedDate")
            //        .SetValue(tEntity, DateTime.Now);
            //}

            return SetAuditingProperty(tEntity, "ModifiedById");

        }
        private T SetAddedBy(T tEntity)
        {


            //var LastModProp = tEntity.GetType().GetProperty("CreatedDate");
            //if (LastModProp != null)
            //{
            //    tEntity.GetType()
            //        .GetProperty("CreatedDate")
            //        .SetValue(tEntity, DateTime.Now);
            //}

            return SetAuditingProperty(tEntity, "AddedById");
        }

        private T SetAuditingProperty(T tEntity, string propertyName)
        {

            try
            {
                var user = _httpContextAccessor.HttpContext.User;
                int userId;

                if (int.TryParse(_userManager.GetUserId(user), out userId))
                {
                    var LastModProp = tEntity.GetType().GetProperty(propertyName);
                    if (LastModProp != null)
                    {
                        tEntity.GetType()
                            .GetProperty(propertyName)
                            .SetValue(tEntity, userId);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"There is An Error Occured While Setting {propertyName} => {ex.Message}");

                throw;
            }

            return tEntity;
        }
    }
}
