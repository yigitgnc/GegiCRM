using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Utils.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    [ActivityLogger]
    public class CustomerActivityLogsController : Controller
    {
        private readonly CrmDbContext _context;

        public CustomerActivityLogsController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: CustomerActivityLogs
        public async Task<IActionResult> Index()
        {
            var context = _context.CustomerActivityLogs.Include(c => c.AddedBy).Include(c => c.Customer).Include(c => c.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: CustomerActivityLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerActivityLogs == null)
            {
                return NotFound();
            }

            var customerActivityLog = await _context.CustomerActivityLogs
                .Include(c => c.AddedBy)
                .Include(c => c.Customer)
                .Include(c => c.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerActivityLog == null)
            {
                return NotFound();
            }

            return View(customerActivityLog);
        }

        // GET: CustomerActivityLogs/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: CustomerActivityLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Note,CustomerId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] CustomerActivityLog customerActivityLog)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(customerActivityLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerActivityLog.AddedById);
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerActivityLog.CustomerId);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerActivityLog.ModifiedById);
                return View(customerActivityLog);
            }

            //}

        }

        // GET: CustomerActivityLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerActivityLogs == null)
            {
                return NotFound();
            }

            var customerActivityLog = await _context.CustomerActivityLogs.FindAsync(id);
            if (customerActivityLog == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerActivityLog.AddedById);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerActivityLog.CustomerId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerActivityLog.ModifiedById);
            return View(customerActivityLog);
        }

        // POST: CustomerActivityLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Note,CustomerId,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] CustomerActivityLog customerActivityLog)
        {
            if (id != customerActivityLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerActivityLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerActivityLogExists(customerActivityLog.Id))
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
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", customerActivityLog.AddedById);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", customerActivityLog.CustomerId);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", customerActivityLog.ModifiedById);
            return View(customerActivityLog);
        }

        // GET: CustomerActivityLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerActivityLogs == null)
            {
                return NotFound();
            }

            var customerActivityLog = await _context.CustomerActivityLogs
                .Include(c => c.AddedBy)
                .Include(c => c.Customer)
                .Include(c => c.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerActivityLog == null)
            {
                return NotFound();
            }

            return View(customerActivityLog);
        }

        // POST: CustomerActivityLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerActivityLogs == null)
            {
                return Problem("Entity set 'Context.CustomerActivityLogs'  is null.");
            }
            var customerActivityLog = await _context.CustomerActivityLogs.FindAsync(id);
            if (customerActivityLog != null)
            {
                _context.CustomerActivityLogs.Remove(customerActivityLog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerActivityLogExists(int id)
        {
            return (_context.CustomerActivityLogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
