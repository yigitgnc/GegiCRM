using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Concrete;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Repositories;
using GegiCRM.DAL.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using GegiCRM.WebUI.Utils.CustomActionFilters;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    [ActivityLogger]
    public class CustomersController : Controller
    {
        private readonly CrmDbContext _context;
        private readonly GenericManager<Customer> _genericmanager = new GenericManager<Customer>(new EfCustomerRepository());
        private readonly GenericManager<CustomerRepresentetiveUser> _repUserManager = new GenericManager<CustomerRepresentetiveUser>(new EfCustomerRepresentetiveUserRepository());
        private readonly GenericManager<CustomerContact> _contactManager = new GenericManager<CustomerContact>(new EfCustomerContactRepository());
        private readonly GenericManager<CustomerAddress> _addressManager = new GenericManager<CustomerAddress>(new EfCustomerAddressRepository());
        private readonly GenericManager<CustomerBillingAddress> _billingAddressManager = new GenericManager<CustomerBillingAddress>(new EfCustomerBillingAddressRepository());


        public CustomersController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var context = _context.Customers.Include(c => c.AddedBy).Include(c => c.CustomerMainCompany).Include(c => c.ModifiedBy).Include(c => c.PreferredCurrency).Include(c => c.Sector).Include(c => c.Segment).Include(c => c.Type);
            return View(await context.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.AddedBy)
                .Include(c => c.CustomerMainCompany)
                .Include(c => c.ModifiedBy)
                .Include(c => c.PreferredCurrency)
                .Include(c => c.Sector)
                .Include(c => c.Segment)
                .Include(c => c.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Edit), new { id = customer.Id });
            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["CustomerMainCompanyId"] = new SelectList(_context.CustomerMainCompanies, "Id", "Description");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["PreferredCurrencyId"] = new SelectList(_context.Currencies, "Id", "Code");
            ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "Name");
            ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description");
            ViewData["TypeId"] = new SelectList(_context.CustomerTypes, "Id", "Name");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TercihEdilenKur,TicariUnvan,Name,Surname,SectorId,CariKodu,SegmentId,IsActive,TypeId,Tel,CurrencyId,SideSuppliers,Notes,PreferredCurrencyId,CustomerMainCompanyId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Customer customer)
        {
            try
            {
                AppUser? user = await _genericmanager.GetCurrentUserAsync();
                customer.AddedById = user.Id;
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), new { id = customer.Id });

            }
            catch (Exception)
            {

            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customer.AddedById);
            ViewData["CustomerMainCompanyId"] = new SelectList(_context.CustomerMainCompanies, "Id", "Description", customer.CustomerMainCompanyId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customer.ModifiedById);
            ViewData["PreferredCurrencyId"] = new SelectList(_context.Currencies, "Id", "Code", customer.PreferredCurrencyId);
            ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "Name", customer.SectorId);
            ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description", customer.SegmentId);
            ViewData["TypeId"] = new SelectList(_context.CustomerTypes, "Id", "Name", customer.TypeId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            ViewData["Users"] = _context.Users.ToList();
            ViewData["CustomerMainCompanyId"] = new SelectList(_context.CustomerMainCompanies, "Id", "Name", customer.CustomerMainCompanyId);
            //ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customer.ModifiedById);
            ViewData["PreferredCurrencyId"] = new SelectList(_context.Currencies, "Id", "Code", customer.PreferredCurrencyId);
            ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "Name", customer.SectorId);
            ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Name", customer.SegmentId);
            ViewData["TypeId"] = new SelectList(_context.CustomerTypes, "Id", "Name", customer.TypeId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TercihEdilenKur,TicariUnvan,Name,Surname,SectorId,CariKodu,SegmentId,IsActive,TypeId,Tel,CurrencyId,SideSuppliers,Notes,PreferredCurrencyId,CustomerMainCompanyId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }
            try
            {
                try
                {
                    AppUser? user = await _genericmanager.GetCurrentUserAsync();
                    customer.ModifiedById = user.Id;
                    customer.ModifiedDate = DateTime.Now;
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit), new { id = customer.Id });
            }
            catch (Exception)
            {
                ViewData["Users"] = _context.Users.ToList();
                ViewData["CustomerMainCompanyId"] = new SelectList(_context.CustomerMainCompanies, "Id", "Description", customer.CustomerMainCompanyId);
                //ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customer.ModifiedById);
                ViewData["PreferredCurrencyId"] = new SelectList(_context.Currencies, "Id", "Code", customer.PreferredCurrencyId);
                ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "Name", customer.SectorId);
                ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description", customer.SegmentId);
                ViewData["TypeId"] = new SelectList(_context.CustomerTypes, "Id", "Name", customer.TypeId);
                return View(customer);
            }


        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.AddedBy)
                .Include(c => c.CustomerMainCompany)
                .Include(c => c.ModifiedBy)
                .Include(c => c.PreferredCurrency)
                .Include(c => c.Sector)
                .Include(c => c.Segment)
                .Include(c => c.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity set 'Context.Customers'  is null.");
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool CustomerExists(int id)
        {
            return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        GenericManager<CustomerActivityLog> activityManager = new GenericManager<CustomerActivityLog>(new GenericRepository<CustomerActivityLog>());
        public IActionResult _NewActivityLog()
        {
            CustomerActivityLog activityLog = new CustomerActivityLog();
            ViewData["CustomerId"] = _context.Customers.ToList();
            return View(activityLog);
        }

        [HttpPost]
        [Authorize]
        public IActionResult _NewActivityLog(CustomerActivityLog activityLog, string? returnUrl)
        {
            try
            {
                activityManager.Create(activityLog);
            }
            catch (Exception ex)
            {

            }
            //return Redirect(returnUrl);
            return RedirectToAction(nameof(Edit), new { id = activityLog.CustomerId });
        }


        [HttpPost]
        public async Task<string> _AddCustomerRepresentetiveUser(int customerId, string title, int userId)
        {
            try
            {
                title = title.ToUpper();

                CustomerRepresentetiveUser? existing = await _context.CustomerRepresentetiveUsers.FirstOrDefaultAsync(x => x.CustomerId == customerId && x.UserId == userId);
                if (existing == null)
                {
                    CustomerRepresentetiveUser repUser = new CustomerRepresentetiveUser()
                    {
                        CustomerId = customerId,
                        UserId = userId,
                        Title = title,
                    };
                    _repUserManager.Create(repUser);
                }
                else
                {
                    existing.Title = title;
                    existing.IsDeleted = false;
                    _repUserManager.Update(existing);
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<IActionResult> _GetRepresentetiveUsersOfCustomer(int id)
        {

            var data = _repUserManager.ListByFilter(x => x.CustomerId == id && x.IsDeleted == false, false).OrderByDescending(x => x.Id).ToList();
            return View(data);
        }

        [HttpPost]
        public async Task<string> _DeleteRepUser(int id)
        {
            try
            {
                CustomerRepresentetiveUser? existing = await _context.CustomerRepresentetiveUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (existing == null)
                {
                    return "No Data";
                }
                else
                {
                    _repUserManager.Delete(existing);
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        [HttpPost]
        public async Task<string> _DeleteContact(int id)
        {
            try
            {
                CustomerContact? existing = await _context.CustomerContacts.FirstOrDefaultAsync(x => x.Id == id);
                if (existing == null)
                {
                    return "No Data";
                }
                else
                {
                    _contactManager.Delete(existing);
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<IActionResult> _EditCustomerContact(int id)
        {
            var contact = await _context.CustomerContacts.FirstOrDefaultAsync(x => x.Id == id);
            return View(contact);
        }

        [HttpPost]
        public async Task<string> _EditCustomerContact(CustomerContact contact)
        {
            try
            {
                _contactManager.Update(contact);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<IActionResult> _GetCustomerContactsOfCustomer(int id)
        {
            var data = _contactManager.ListByFilter(x => x.CustomerId == id && x.IsDeleted == false, false).OrderByDescending(x => x.Id).ToList();
            return View(data);
        }

        [HttpPost]
        public async Task<string> _CustomerContact(int id)
        {
            try
            {

                CustomerRepresentetiveUser? existing = await _context.CustomerRepresentetiveUsers.FirstOrDefaultAsync(x => x.Id == id);
                if (existing == null)
                {
                    return "No Data";
                }
                else
                {
                    _repUserManager.Delete(existing);
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        [HttpPost]
        public async Task<string> _AddCustomerContact(CustomerContact contact)
        {
            try
            {
                var addedContact = _contactManager.Create(contact);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        public async Task<IActionResult> _GetCustomerAddresses(int id)
        {

            var data = _addressManager.ListByFilter(x => x.CustomerId == id && x.IsDeleted == false, false).OrderByDescending(x => x.Id).ToList();
            return View(data);

        }


        [HttpPost]
        public async Task<string> _AddNewCustomerAddress(int customerId, string addressName, string il, string ilce, string address)
        {
            try
            {
                CustomerAddress newAddress = new CustomerAddress
                {
                    CustomerId = customerId,
                    AddressName = addressName,
                    Il = il,
                    Ilce = ilce,
                    Address = address
                };
                _addressManager.Create(newAddress);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public async Task<IActionResult> _EditCustomerAddress(int id)
        {
            var data = await _context.CustomerAddresses.FirstOrDefaultAsync(x => x.Id == id);
            return View(data);
        }

        [HttpPost]
        public async Task<string> _EditCustomerAddress(CustomerAddress customerAddress)
        {
            try
            {
                _addressManager.Update(customerAddress);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> _DeleteCustomerAddress(int id)
        {
            try
            {
                var currentAddress = _addressManager.GetById(id, false);
                if (currentAddress == null)
                {
                    return "Not Found";
                }
                else
                {
                    _addressManager.Delete(currentAddress);
                }

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<IActionResult> _GetCustomerBillingAddresses(int id)
        {

            var data = _billingAddressManager.ListByFilter(x => x.CustomerId == id && x.IsDeleted == false, false).OrderByDescending(x => x.Id).ToList();
            return View(data);

        }


        [HttpPost]
        public async Task<string> _AddNewCustomerBillingAddress(int customerId, string addressName, string vergiNo, string vergiDairesi, string billingAddress)
        {
            try
            {
                CustomerBillingAddress newAddress = new CustomerBillingAddress
                {
                    CustomerId = customerId,
                    AddressName = addressName,
                    VergiDairesi = vergiDairesi,
                    VergiNo = vergiNo,
                    BillingAddress = billingAddress
                };
                _billingAddressManager.Create(newAddress);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public async Task<IActionResult> _EditCustomerBillingAddress(int id)
        {
            var data = await _context.CustomerBillingAddresses.FirstOrDefaultAsync(x => x.Id == id);
            return View(data);
        }

        [HttpPost]
        public async Task<string> _EditCustomerBillingAddress(CustomerBillingAddress customerBillingAddress)
        {
            try
            {
                _billingAddressManager.Update(customerBillingAddress);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> _DeleteCustomerBillingAddress(int id)
        {
            try
            {
                var currentAddress = _billingAddressManager.GetById(id, false);
                if (currentAddress == null)
                {
                    return "Not Found";
                }
                else
                {
                    _billingAddressManager.Delete(currentAddress);
                }

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<IActionResult> _GetCustomersOrders(int? id)
        {
            if (id != null)
            {
                var data = await _context.Orders.Where(x => x.CustomerId == id && x.IsDeleted == false).ToListAsync();
                return View(data);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
