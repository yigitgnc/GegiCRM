using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        protected GenericManager(UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor,ILogger<T> logger)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }


        public abstract void Create(T t);
        public abstract void Delete(T t);
        public abstract void Update(T t);
        public abstract List<T> GetAll();
        public abstract T GetById(int id);

        public T SetLastModified(T tEntity)
        {
            return SetAuditingProperty(tEntity, "ModifiedBy");
        }
        public T SetAddedBy(T tEntity)
        {
            return SetAuditingProperty(tEntity, "AddedBy");
        }

        private T SetAuditingProperty(T tEntity,string propertyName)
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
