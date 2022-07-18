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
    public class SectorsController : Controller
    {
        private readonly CrmDbContext _context;

        public SectorsController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: Sectors
        public async Task<IActionResult> Index()
        {
            var context = _context.Sectors.Include(s => s.AddedBy).Include(s => s.ModifiedBy);
            return View(await context.ToListAsync());
        }

        // GET: Sectors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sectors == null)
            {
                return NotFound();
            }

            var sector = await _context.Sectors
                .Include(s => s.AddedBy)
                .Include(s => s.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sector == null)
            {
                return NotFound();
            }

            return View(sector);
        }

        // GET: Sectors/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: Sectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Sector sector)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sector);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", sector.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", sector.ModifiedById);
            return View(sector);
        }

        // GET: Sectors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sectors == null)
            {
                return NotFound();
            }

            var sector = await _context.Sectors.FindAsync(id);
            if (sector == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", sector.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", sector.ModifiedById);
            return View(sector);
        }

        // POST: Sectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Id,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted")] Sector sector)
        {
            if (id != sector.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectorExists(sector.Id))
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
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", sector.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", sector.ModifiedById);
            return View(sector);
        }

        // GET: Sectors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sectors == null)
            {
                return NotFound();
            }

            var sector = await _context.Sectors
                .Include(s => s.AddedBy)
                .Include(s => s.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sector == null)
            {
                return NotFound();
            }

            return View(sector);
        }

        // POST: Sectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sectors == null)
            {
                return Problem("Entity set 'Context.Sectors'  is null.");
            }
            var sector = await _context.Sectors.FindAsync(id);
            if (sector != null)
            {
                _context.Sectors.Remove(sector);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectorExists(int id)
        {
          return (_context.Sectors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
