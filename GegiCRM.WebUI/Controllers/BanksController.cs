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
    public class BanksController : Controller
    {
        private readonly CrmDbContext _context;

        public BanksController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: Banks
        public async Task<IActionResult> Index()
        {
            var context = _context.Banks.Include(b => b.AddedBy).Include(b => b.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: Banks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Banks == null)
            {
                return NotFound();
            }

            var bank = await _context.Banks
                .Include(b => b.AddedBy)
                .Include(b => b.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }

        // GET: Banks/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: Banks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IsDeleted,BankName,BankDescirption,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById")] Bank bank)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Add(bank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", bank.AddedById);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", bank.ModifiedById);
                return View(bank);
            }
             
            //}
        }

        // GET: Banks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Banks == null)
            {
                return NotFound();
            }

            var bank = await _context.Banks.FindAsync(id);
            if (bank == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", bank.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", bank.ModifiedById);
            return View(bank);
        }

        // POST: Banks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IsDeleted,BankName,BankDescirption,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById")] Bank bank)
        {
            if (id != bank.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankExists(bank.Id))
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
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", bank.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", bank.ModifiedById);
            return View(bank);
        }

        // GET: Banks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Banks == null)
            {
                return NotFound();
            }

            var bank = await _context.Banks
                .Include(b => b.AddedBy)
                .Include(b => b.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }

        // POST: Banks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Banks == null)
            {
                return Problem("Entity set 'Context.Banks'  is null.");
            }
            var bank = await _context.Banks.FindAsync(id);
            if (bank != null)
            {
                _context.Banks.Remove(bank);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankExists(int id)
        {
          return (_context.Banks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
