using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    public class SVTController : Controller
    {
        private readonly GenericManager<Order> _orderGenericManager = new GenericManager<Order>(new GenericRepository<Order>());
        readonly AppUserManager _appUserManager;
        readonly GenericManager<Customer> _customerManager;
        readonly SignInManager<AppUser> _signInManager;
        public SVTController(SignInManager<AppUser> signInManager)
        {
            _appUserManager = new AppUserManager(new EfAppUserRepository(), signInManager);
            _signInManager = signInManager;          
            _customerManager = new GenericManager<Customer>(new EfCustomerRepository());
        }

        public IActionResult Index()
        {
            List<Order> model = _orderGenericManager.ListByFilter(x => x.IsFrequentlyUsed && x.IsDeleted == false, false);
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Order? model = _orderGenericManager.GetById(id, false);
            if(model == null)
            {
                return BadRequest();
            }

            ViewBag.Customers = _customerManager.GetAll(false);
            ViewBag.Users = _appUserManager.GetAll(false);


            return View(model);
        }

        public async Task<string> Delete(int id)
        {
            Order? order = _orderGenericManager.GetById(id, false);

            if (order != null)
            {
                try
                {
                    order.IsFrequentlyUsed = false;
                    _orderGenericManager.Update(order);
                    return "Ok";
                }
                catch (Exception ex)
                {
                    return $"Hata => {ex.Message}";
                }
            }
            return "Not Found !";
        }
    }
}
