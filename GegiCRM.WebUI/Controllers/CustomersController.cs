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
    public class CustomersController : Controller
    {
        private readonly Context _context;

        public CustomersController(Context context)
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
        public async Task<IActionResult> Create([Bind("TicariUnvan,Name,Surname,SectorId,CariKodu,SegmentId,IsActive,TypeId,Tel,CurrencyId,SideSuppliers,Notes,PreferredCurrencyId,CustomerMainCompanyId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Customer customer)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customer.AddedById);
                ViewData["CustomerMainCompanyId"] = new SelectList(_context.CustomerMainCompanies, "Id", "Description", customer.CustomerMainCompanyId);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customer.ModifiedById);
                ViewData["PreferredCurrencyId"] = new SelectList(_context.Currencies, "Id", "Code", customer.PreferredCurrencyId);
                ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "Name", customer.SectorId);
                ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description", customer.SegmentId);
                ViewData["TypeId"] = new SelectList(_context.CustomerTypes, "Id", "Name", customer.TypeId);
                return View(customer);
            }
               
            //}


         
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
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customer.AddedById);
            ViewData["CustomerMainCompanyId"] = new SelectList(_context.CustomerMainCompanies, "Id", "Description", customer.CustomerMainCompanyId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customer.ModifiedById);
            ViewData["PreferredCurrencyId"] = new SelectList(_context.Currencies, "Id", "Code", customer.PreferredCurrencyId);
            ViewData["SectorId"] = new SelectList(_context.Sectors, "Id", "Name", customer.SectorId);
            ViewData["SegmentId"] = new SelectList(_context.Segments, "Id", "Description", customer.SegmentId);
            ViewData["TypeId"] = new SelectList(_context.CustomerTypes, "Id", "Name", customer.TypeId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicariUnvan,Name,Surname,SectorId,CariKodu,SegmentId,IsActive,TypeId,Tel,CurrencyId,SideSuppliers,Notes,PreferredCurrencyId,CustomerMainCompanyId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
                return RedirectToAction(nameof(Index));
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
    }
}
