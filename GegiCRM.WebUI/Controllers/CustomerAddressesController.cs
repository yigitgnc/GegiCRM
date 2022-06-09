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
    public class CustomerAddressesController : Controller
    {
        private readonly Context _context;

        public CustomerAddressesController(Context context)
        {
            _context = context;
        }

        // GET: CustomerAddresses
        public async Task<IActionResult> Index()
        {
            var context = _context.CustomerAddresses.Include(c => c.AddedBy).Include(c => c.Customer).Include(c => c.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: CustomerAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerAddresses == null)
            {
                return NotFound();
            }

            var customerAddress = await _context.CustomerAddresses
                .Include(c => c.AddedBy)
                .Include(c => c.Customer)
                .Include(c => c.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerAddress == null)
            {
                return NotFound();
            }

            return View(customerAddress);
        }

        // GET: CustomerAddresses/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: CustomerAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,AddressName,Il,Ilce,Address,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] CustomerAddress customerAddress)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(customerAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerAddress.AddedById);
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerAddress.CustomerId);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerAddress.ModifiedById);
                return View(customerAddress);
            }
              
            //}
         
        }

        // GET: CustomerAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerAddresses == null)
            {
                return NotFound();
            }

            var customerAddress = await _context.CustomerAddresses.FindAsync(id);
            if (customerAddress == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerAddress.AddedById);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerAddress.CustomerId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerAddress.ModifiedById);
            return View(customerAddress);
        }

        // POST: CustomerAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,AddressName,Il,Ilce,Address,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] CustomerAddress customerAddress)
        {
            if (id != customerAddress.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            try
            {
                try
                {
                    _context.Update(customerAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerAddressExists(customerAddress.Id))
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
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerAddress.AddedById);
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerAddress.CustomerId);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerAddress.ModifiedById);
                return View(customerAddress);
            }
               
            //}
        
        }

        // GET: CustomerAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerAddresses == null)
            {
                return NotFound();
            }

            var customerAddress = await _context.CustomerAddresses
                .Include(c => c.AddedBy)
                .Include(c => c.Customer)
                .Include(c => c.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerAddress == null)
            {
                return NotFound();
            }

            return View(customerAddress);
        }

        // POST: CustomerAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerAddresses == null)
            {
                return Problem("Entity set 'Context.CustomerAddresses'  is null.");
            }
            var customerAddress = await _context.CustomerAddresses.FindAsync(id);
            if (customerAddress != null)
            {
                _context.CustomerAddresses.Remove(customerAddress);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerAddressExists(int id)
        {
          return (_context.CustomerAddresses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
