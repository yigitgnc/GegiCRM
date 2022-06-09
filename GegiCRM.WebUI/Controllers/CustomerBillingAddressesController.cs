using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Concrete;

namespace GegiCRM.WebUI.Controllers
{
    public class CustomerBillingAddressesController : Controller
    {
        private readonly Context _context;

        public CustomerBillingAddressesController(Context context)
        {
            _context = context;
        }

        // GET: CustomerBillingAddresses
        public async Task<IActionResult> Index()
        {
            var context = _context.CustomerBillingAddresses.Include(c => c.AddedBy).Include(c => c.Customer).Include(c => c.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: CustomerBillingAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerBillingAddresses == null)
            {
                return NotFound();
            }

            var customerBillingAddress = await _context.CustomerBillingAddresses
                .Include(c => c.AddedBy)
                .Include(c => c.Customer)
                .Include(c => c.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerBillingAddress == null)
            {
                return NotFound();
            }

            return View(customerBillingAddress);
        }

        // GET: CustomerBillingAddresses/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: CustomerBillingAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,AddressName,VergiNo,VergiDairesi,BillingAddress,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] CustomerBillingAddress customerBillingAddress)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(customerBillingAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.AddedById);
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerBillingAddress.CustomerId);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.ModifiedById);
                return View(customerBillingAddress);
            }
              
            //}
          
        }

        // GET: CustomerBillingAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerBillingAddresses == null)
            {
                return NotFound();
            }

            var customerBillingAddress = await _context.CustomerBillingAddresses.FindAsync(id);
            if (customerBillingAddress == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.AddedById);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerBillingAddress.CustomerId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.ModifiedById);
            return View(customerBillingAddress);
        }

        // POST: CustomerBillingAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,AddressName,VergiNo,VergiDairesi,BillingAddress,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] CustomerBillingAddress customerBillingAddress)
        {
            if (id != customerBillingAddress.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            try
            {
                try
                {
                    _context.Update(customerBillingAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerBillingAddressExists(customerBillingAddress.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.AddedById);
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerBillingAddress.CustomerId);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.ModifiedById);
                return View(customerBillingAddress);
            }
              
            //}
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.AddedById);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerBillingAddress.CustomerId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerBillingAddress.ModifiedById);
            return View(customerBillingAddress);
        }

        // GET: CustomerBillingAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerBillingAddresses == null)
            {
                return NotFound();
            }

            var customerBillingAddress = await _context.CustomerBillingAddresses
                .Include(c => c.AddedBy)
                .Include(c => c.Customer)
                .Include(c => c.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerBillingAddress == null)
            {
                return NotFound();
            }

            return View(customerBillingAddress);
        }

        // POST: CustomerBillingAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerBillingAddresses == null)
            {
                return Problem("Entity set 'Context.CustomerBillingAddresses'  is null.");
            }
            var customerBillingAddress = await _context.CustomerBillingAddresses.FindAsync(id);
            if (customerBillingAddress != null)
            {
                _context.CustomerBillingAddresses.Remove(customerBillingAddress);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerBillingAddressExists(int id)
        {
          return (_context.CustomerBillingAddresses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
