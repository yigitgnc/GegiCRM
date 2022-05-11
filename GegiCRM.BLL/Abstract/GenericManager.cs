using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.DAL.Abstract;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace GegiCRM.BLL.Abstract
{
    public abstract class GenericManager<T>
    {
        public UserManager<AppUser> _userManager;
        public IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<T> _logger;
        readonly IGenericDal<T> _genericDal;

        protected GenericManager(UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor, ILogger<T> logger, IGenericDal<T> genericDal)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
            _genericDal = genericDal;
        }

        public void Create(T t)
        {
            t = SetAddedBy(t);
            _genericDal.Insert(t);
        }
        public void Update(T t)
        {
            t = SetLastModifiedBy(t);
            _genericDal.Insert(t);
        }

        public void Delete(T t)
        {
            t = SetLastModifiedBy(t);
            _genericDal.Delete(t);
        }



        public List<T> GetAll()
        {
            return _genericDal.GetListAll();
        }

        public T GetById(int id)
        {
            return _genericDal.GetByID(id);
        }

        private T SetLastModifiedBy(T tEntity)
        {
            return SetAuditingProperty(tEntity, "ModifiedBy");
        }
        private T SetAddedBy(T tEntity)
        {
            return SetAuditingProperty(tEntity, "AddedBy");
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
